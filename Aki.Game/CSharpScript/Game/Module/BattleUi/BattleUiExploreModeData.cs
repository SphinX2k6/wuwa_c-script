using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C87 RID: 23687
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiExploreModeData
	{
		// Token: 0x0603BD5F RID: 245087 RVA: 0x00E4A944 File Offset: 0x00E48B44
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

		// Token: 0x0603BD60 RID: 245088 RVA: 0x00E4A9AF File Offset: 0x00E48BAF
		public void OnLeaveLevel()
		{
		}

		// Token: 0x0603BD61 RID: 245089 RVA: 0x00E4A9B1 File Offset: 0x00E48BB1
		public void Clear()
		{
			this.SetAutoSwitch(false);
		}

		// Token: 0x0603BD62 RID: 245090 RVA: 0x00E4A9BA File Offset: 0x00E48BBA
		public IReadOnlyList<string> GetActionNames()
		{
			return BattleUiExploreModeData.ActionNames;
		}

		// Token: 0x0603BD63 RID: 245091 RVA: 0x00E4A9C1 File Offset: 0x00E48BC1
		public bool GetIsInExploreMode()
		{
			return this.IsInExploreMode;
		}

		// Token: 0x0603BD64 RID: 245092 RVA: 0x00E4A9CC File Offset: 0x00E48BCC
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

		// Token: 0x0603BD65 RID: 245093 RVA: 0x00E4AA40 File Offset: 0x00E48C40
		public void EnterBattleMode()
		{
			if (!this.IsInExploreMode)
			{
				return;
			}
			this.IsInExploreMode = false;
			EventSystem.Instance.Emit<bool>(EEventName.BattleUiExploreModeChanged, false);
		}

		// Token: 0x0603BD66 RID: 245094 RVA: 0x00E4AA63 File Offset: 0x00E48C63
		public void DelayExitBattleMode()
		{
			this.OpenExploreModeTime = (float)Time.Instance.WorldTime + this.WaitingTime;
		}

		// Token: 0x0603BD67 RID: 245095 RVA: 0x00E4AA7D File Offset: 0x00E48C7D
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

		// Token: 0x0603BD68 RID: 245096 RVA: 0x00E4AA96 File Offset: 0x00E48C96
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

		// Token: 0x0603BD69 RID: 245097 RVA: 0x00E4AAB0 File Offset: 0x00E48CB0
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

		// Token: 0x0603BD6A RID: 245098 RVA: 0x00E4AAF4 File Offset: 0x00E48CF4
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

		// Token: 0x0603BD6B RID: 245099 RVA: 0x00E4AB35 File Offset: 0x00E48D35
		public void UpdateDungeonState()
		{
			this.IsInForbiddenDungeon = this.CheckInForbiddenDungeon();
			if (this.IsInForbiddenDungeon && this.IsInExploreMode)
			{
				this.EnterBattleMode();
			}
		}

		// Token: 0x0603BD6C RID: 245100 RVA: 0x00E4AB5C File Offset: 0x00E48D5C
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

		// Token: 0x0603BD6D RID: 245101 RVA: 0x00E4AC54 File Offset: 0x00E48E54
		private bool IsAiming(BattleUiRoleData curRoleData)
		{
			return curRoleData.EntityHandle.Entity.GetComponent<CharacterUnifiedStateComponent>().DirectionState == ECharDirectionState.AimDirection;
		}

		// Token: 0x0603BD6E RID: 245102 RVA: 0x00E4AC70 File Offset: 0x00E48E70
		private bool CheckInForbiddenDungeon()
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			return instanceId != 0 && InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.InstSubType == 7;
		}

		// Token: 0x0603BD6F RID: 245103 RVA: 0x00E4ACAB File Offset: 0x00E48EAB
		private void DestroyTimer()
		{
			if (this.Timer != null)
			{
				TimerSystem.Instance.Remove(this.Timer);
				this.Timer = null;
			}
		}

		// Token: 0x0401F311 RID: 127761
		private const int TIMER_INTERVAL = 1000;

		// Token: 0x0401F312 RID: 127762
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNames = new string[]
		{
			"攻击",
			"技能1",
			"幻象2",
			"瞄准",
			"大招"
		};

		// Token: 0x0401F313 RID: 127763
		private bool IsAutoSwitch = true;

		// Token: 0x0401F314 RID: 127764
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401F315 RID: 127765
		private bool IsInExploreMode;

		// Token: 0x0401F316 RID: 127766
		private bool IsInForbiddenDungeon;

		// Token: 0x0401F317 RID: 127767
		private readonly Dictionary<string, int> ActionNameMap = new Dictionary<string, int>();

		// Token: 0x0401F318 RID: 127768
		private readonly List<bool> IsPressingList = new List<bool>();

		// Token: 0x0401F319 RID: 127769
		private float OpenExploreModeTime;

		// Token: 0x0401F31A RID: 127770
		private float WaitingTime = 3000f;

		// Token: 0x0401F31B RID: 127771
		private bool IsGuiding;

		// Token: 0x0401F31C RID: 127772
		private bool IsBossFight;
	}
}
