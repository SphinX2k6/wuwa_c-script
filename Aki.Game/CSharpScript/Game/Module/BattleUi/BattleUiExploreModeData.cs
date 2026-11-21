using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C68 RID: 19560
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiExploreModeData
	{
		// Token: 0x06030CAD RID: 199853 RVA: 0x00D9AEC0 File Offset: 0x00D990C0
		public void Init()
		{
			this.WaitingTime = (float)ConfigCommonParamById.GetIntConfig("ExploreModeWaitTime").Value;
			for (int i = 0; i < BattleUiExploreModeData.ActionNames.Length; i++)
			{
				string key = BattleUiExploreModeData.ActionNames[i];
				this.IsPressingList.Add(false);
				this.ActionNameMap[key] = i;
			}
			bool isAutoSwitchSkillButtonMode = BattleUiModel.Instance.GetIsAutoSwitchSkillButtonMode();
			this.SetAutoSwitch(isAutoSwitchSkillButtonMode);
		}

		// Token: 0x06030CAE RID: 199854 RVA: 0x00D9AF2B File Offset: 0x00D9912B
		public void OnLeaveLevel()
		{
		}

		// Token: 0x06030CAF RID: 199855 RVA: 0x00D9AF2D File Offset: 0x00D9912D
		public void Clear()
		{
			this.SetAutoSwitch(false);
		}

		// Token: 0x06030CB0 RID: 199856 RVA: 0x00D9AF36 File Offset: 0x00D99136
		public IReadOnlyList<string> GetActionNames()
		{
			return BattleUiExploreModeData.ActionNames;
		}

		// Token: 0x06030CB1 RID: 199857 RVA: 0x00D9AF3D File Offset: 0x00D9913D
		public bool GetIsInExploreMode()
		{
			return this.IsInExploreMode;
		}

		// Token: 0x06030CB2 RID: 199858 RVA: 0x00D9AF48 File Offset: 0x00D99148
		public void SetAutoSwitch(bool isOpen)
		{
			this.IsAutoSwitch = false;
			if (this.IsAutoSwitch)
			{
				if (this.Timer == null)
				{
					this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimer), 1000f, 1f, null, null, true);
					return;
				}
			}
			else
			{
				this.DestroyTimer();
				if (this.IsInExploreMode)
				{
					this.IsInExploreMode = false;
					EventSystem.Instance.Emit<bool>(EEventName.BattleUiExploreModeChanged, false);
				}
			}
		}

		// Token: 0x06030CB3 RID: 199859 RVA: 0x00D9AFBC File Offset: 0x00D991BC
		public void EnterBattleMode()
		{
			if (!this.IsInExploreMode)
			{
				return;
			}
			this.IsInExploreMode = false;
			EventSystem.Instance.Emit<bool>(EEventName.BattleUiExploreModeChanged, false);
		}

		// Token: 0x06030CB4 RID: 199860 RVA: 0x00D9AFDF File Offset: 0x00D991DF
		public void DelayExitBattleMode()
		{
			this.OpenExploreModeTime = (float)Time.Instance.WorldTime + this.WaitingTime;
		}

		// Token: 0x06030CB5 RID: 199861 RVA: 0x00D9AFF9 File Offset: 0x00D991F9
		public void UpdateGuidingState(bool isGuiding)
		{
			this.IsGuiding = isGuiding;
			if (isGuiding)
			{
				this.EnterBattleMode();
				return;
			}
			this.DelayExitBattleMode();
		}

		// Token: 0x06030CB6 RID: 199862 RVA: 0x00D9B012 File Offset: 0x00D99212
		public void UpdateBossState(bool isBossFight)
		{
			this.IsBossFight = isBossFight;
			if (isBossFight)
			{
				this.EnterBattleMode();
				return;
			}
			this.DelayExitBattleMode();
		}

		// Token: 0x06030CB7 RID: 199863 RVA: 0x00D9B02C File Offset: 0x00D9922C
		public void InputAction(string actionName, bool isPress)
		{
			int index;
			if (!this.ActionNameMap.TryGetValue(actionName, out index))
			{
				return;
			}
			this.IsPressingList[index] = isPress;
			if (!isPress && this.IsInExploreMode)
			{
				return;
			}
			this.EnterBattleMode();
			this.DelayExitBattleMode();
		}

		// Token: 0x06030CB8 RID: 199864 RVA: 0x00D9B070 File Offset: 0x00D99270
		public void BeHit(Entity entity)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (((curRoleData != null) ? curRoleData.EntityHandle : null) == null || curRoleData.EntityHandle.Entity != entity)
			{
				return;
			}
			this.EnterBattleMode();
			this.DelayExitBattleMode();
		}

		// Token: 0x06030CB9 RID: 199865 RVA: 0x00D9B0B1 File Offset: 0x00D992B1
		public void UpdateDungeonState()
		{
			this.IsInForbiddenDungeon = this.CheckInForbiddenDungeon();
			if (this.IsInForbiddenDungeon && this.IsInExploreMode)
			{
				this.EnterBattleMode();
			}
		}

		// Token: 0x06030CBA RID: 199866 RVA: 0x00D9B0D8 File Offset: 0x00D992D8
		private void OnTimer(float _)
		{
			if (!this.IsAutoSwitch || this.IsInExploreMode || this.IsInForbiddenDungeon)
			{
				return;
			}
			if (Time.Instance.WorldTime < (double)this.OpenExploreModeTime)
			{
				return;
			}
			if (this.IsGuiding || this.IsBossFight)
			{
				return;
			}
			using (List<bool>.Enumerator enumerator = this.IsPressingList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current)
					{
						int count = this.IsPressingList.Count;
						for (int i = 0; i < count; i++)
						{
							this.IsPressingList[i] = false;
						}
						this.DelayExitBattleMode();
						return;
					}
				}
			}
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData == null || !curRoleData.EntityHandle)
			{
				return;
			}
			if (this.IsAiming(curRoleData))
			{
				return;
			}
			this.IsInExploreMode = true;
			EventSystem.Instance.Emit<bool>(EEventName.BattleUiExploreModeChanged, true);
		}

		// Token: 0x06030CBB RID: 199867 RVA: 0x00D9B1D0 File Offset: 0x00D993D0
		private bool IsAiming(BattleUiRoleData curRoleData)
		{
			return curRoleData.EntityHandle.Entity.GetComponent<CharacterUnifiedStateComponent>().DirectionState == ECharDirectionState.AimDirection;
		}

		// Token: 0x06030CBC RID: 199868 RVA: 0x00D9B1EC File Offset: 0x00D993EC
		private bool CheckInForbiddenDungeon()
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			return instanceId != 0 && InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.InstSubType == 7;
		}

		// Token: 0x06030CBD RID: 199869 RVA: 0x00D9B227 File Offset: 0x00D99427
		private void DestroyTimer()
		{
			if (this.Timer != null)
			{
				TimerSystem.Instance.Remove(this.Timer);
				this.Timer = null;
			}
		}

		// Token: 0x04019DC7 RID: 105927
		private const int TIMER_INTERVAL = 1000;

		// Token: 0x04019DC8 RID: 105928
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNames = new string[]
		{
			"攻击",
			"技能1",
			"幻象2",
			"瞄准",
			"大招"
		};

		// Token: 0x04019DC9 RID: 105929
		private bool IsAutoSwitch = true;

		// Token: 0x04019DCA RID: 105930
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x04019DCB RID: 105931
		private bool IsInExploreMode;

		// Token: 0x04019DCC RID: 105932
		private bool IsInForbiddenDungeon;

		// Token: 0x04019DCD RID: 105933
		private readonly Dictionary<string, int> ActionNameMap = new Dictionary<string, int>();

		// Token: 0x04019DCE RID: 105934
		private readonly List<bool> IsPressingList = new List<bool>();

		// Token: 0x04019DCF RID: 105935
		private float OpenExploreModeTime;

		// Token: 0x04019DD0 RID: 105936
		private float WaitingTime = 3000f;

		// Token: 0x04019DD1 RID: 105937
		private bool IsGuiding;

		// Token: 0x04019DD2 RID: 105938
		private bool IsBossFight;
	}
}
