using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DD0 RID: 19920
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeView : UiViewBase
	{
		// Token: 0x0603368D RID: 210573 RVA: 0x00C00B1F File Offset: 0x00BFED1F
		public RoguelikeBossChallengeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603368E RID: 210574 RVA: 0x00C00B40 File Offset: 0x00BFED40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603368F RID: 210575 RVA: 0x00C00C30 File Offset: 0x00BFEE30
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeBossChallengeView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeBossChallengeView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033690 RID: 210576 RVA: 0x00C00C74 File Offset: 0x00BFEE74
		protected override void OnStart()
		{
			this.BossSwitchPanel.SetOnBossChangedCallback(new Action<ERoguelikeBossChallengeSwitchDirection>(this.OnBossIndexChanged));
			this.TexBossActor = (base.GetTexture(0).GetOwner() as AUIBaseActor);
			this.TexBossActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnBossSequenceEvent));
			this.InitBossData();
		}

		// Token: 0x06033691 RID: 210577 RVA: 0x00C00CD1 File Offset: 0x00BFEED1
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor texBossActor = this.TexBossActor;
			if (texBossActor != null)
			{
				texBossActor.OnSequencePlayEvent.Unbind();
			}
			this.TexBossActor = null;
		}

		// Token: 0x06033692 RID: 210578 RVA: 0x00C00CF0 File Offset: 0x00BFEEF0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x06033693 RID: 210579 RVA: 0x00C00D0E File Offset: 0x00BFEF0E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x06033694 RID: 210580 RVA: 0x00C00D2C File Offset: 0x00BFEF2C
		private void InitBossData()
		{
			List<RogueTowerTrialBossInfo> list = this.OpenParam as List<RogueTowerTrialBossInfo>;
			if (list == null || list.Count == 0)
			{
				return;
			}
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueInst? rogueInst = (instance != null) ? instance.GetRogueInstConfig(instanceId) : null;
			bool flag;
			if (rogueInst == null)
			{
				flag = false;
			}
			else
			{
				int specialBossIndex = rogueInst.GetValueOrDefault().SpecialBossIndex;
				flag = true;
			}
			int num = flag ? (rogueInst.Value.SpecialBossIndex - 1) : -1;
			List<RoguelikeBossChallengeBossData> list2 = new List<RoguelikeBossChallengeBossData>();
			for (int i = 0; i < list.Count; i++)
			{
				RogueTowerTrialBossInfo rogueTowerTrialBossInfo = list[i];
				list2.Add(new RoguelikeBossChallengeBossData
				{
					Id = rogueTowerTrialBossInfo.Id,
					State = RoguelikeBossChallengeDefine.ConvertProtoToBossState(rogueTowerTrialBossInfo.State),
					IsSpecial = (i == num)
				});
			}
			this.SortedBossDataList = RoguelikeBossChallengeDefine.SortBossDataListStable(list2);
			this.SelectableBossIds = new List<int>();
			foreach (RoguelikeBossChallengeBossData roguelikeBossChallengeBossData in this.SortedBossDataList)
			{
				if (roguelikeBossChallengeBossData.State == ERoguelikeBossChallengeBossState.Processing)
				{
					this.SelectableBossIds.Add(roguelikeBossChallengeBossData.Id);
				}
			}
			this.FinishedBossCount = 0;
			using (List<RoguelikeBossChallengeBossData>.Enumerator enumerator = this.SortedBossDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == ERoguelikeBossChallengeBossState.Finished)
					{
						this.FinishedBossCount++;
					}
				}
			}
			this.BossSwitchPanel.RefreshBossList(this.SelectableBossIds);
			this.RefreshBossListBySelectedBoss();
			this.RefreshCurrentBossDisplayNoAnim();
		}

		// Token: 0x06033695 RID: 210581 RVA: 0x00C00EFC File Offset: 0x00BFF0FC
		private List<RoguelikeBossChallengeBossData> BuildDisplayBossDataList(int selectedBossId)
		{
			List<RoguelikeBossChallengeBossData> list = new List<RoguelikeBossChallengeBossData>();
			foreach (RoguelikeBossChallengeBossData roguelikeBossChallengeBossData in this.SortedBossDataList)
			{
				if (roguelikeBossChallengeBossData.State == ERoguelikeBossChallengeBossState.Finished)
				{
					list.Add(roguelikeBossChallengeBossData);
				}
			}
			foreach (RoguelikeBossChallengeBossData roguelikeBossChallengeBossData2 in this.SortedBossDataList)
			{
				if (roguelikeBossChallengeBossData2.State == ERoguelikeBossChallengeBossState.Processing && roguelikeBossChallengeBossData2.Id == selectedBossId)
				{
					list.Add(roguelikeBossChallengeBossData2);
					break;
				}
			}
			foreach (RoguelikeBossChallengeBossData roguelikeBossChallengeBossData3 in this.SortedBossDataList)
			{
				if (roguelikeBossChallengeBossData3.State != ERoguelikeBossChallengeBossState.Finished && (roguelikeBossChallengeBossData3.State != ERoguelikeBossChallengeBossState.Processing || roguelikeBossChallengeBossData3.Id != selectedBossId))
				{
					list.Add(new RoguelikeBossChallengeBossData
					{
						Id = roguelikeBossChallengeBossData3.Id,
						State = ERoguelikeBossChallengeBossState.Locked,
						IsSpecial = roguelikeBossChallengeBossData3.IsSpecial
					});
				}
			}
			return list;
		}

		// Token: 0x06033696 RID: 210582 RVA: 0x00C01040 File Offset: 0x00BFF240
		private void RefreshBossListBySelectedBoss()
		{
			RoguelikeBossChallengeSwitchItem bossSwitchPanel = this.BossSwitchPanel;
			int num = (bossSwitchPanel != null) ? bossSwitchPanel.GetCurrentBossId() : 0;
			List<RoguelikeBossChallengeBossData> dataList = this.BuildDisplayBossDataList(num);
			this.BossListPanel.RefreshBossList(dataList, num);
		}

		// Token: 0x06033697 RID: 210583 RVA: 0x00C01078 File Offset: 0x00BFF278
		private void RefreshCurrentBossDisplayNoAnim()
		{
			RoguelikeBossChallengeSwitchItem bossSwitchPanel = this.BossSwitchPanel;
			int num = (bossSwitchPanel != null) ? bossSwitchPanel.GetCurrentBossId() : 0;
			if (num == 0)
			{
				return;
			}
			this.RefreshBossTexture(new int?(num));
			this.RefreshDebuffList(num);
		}

		// Token: 0x06033698 RID: 210584 RVA: 0x00C010B0 File Offset: 0x00BFF2B0
		private void RefreshCurrentBossDisplayWithAnim(ERoguelikeBossChallengeSwitchDirection direction)
		{
			RoguelikeBossChallengeSwitchItem bossSwitchPanel = this.BossSwitchPanel;
			int num = (bossSwitchPanel != null) ? bossSwitchPanel.GetCurrentBossId() : 0;
			if (num == 0)
			{
				return;
			}
			if (this.IsBossSwitchSequencePlaying())
			{
				this.StopCurrentBossSwitchSequence();
				this.RefreshBossTexture(this.PendingBossId);
			}
			this.PlayBossSwitchSequence(direction, num);
			this.RefreshDebuffList(num);
		}

		// Token: 0x06033699 RID: 210585 RVA: 0x00C01100 File Offset: 0x00BFF300
		private void PlayBossSwitchSequence(ERoguelikeBossChallengeSwitchDirection direction, int bossId)
		{
			string bossSwitchSequenceName = this.GetBossSwitchSequenceName(direction);
			this.PendingBossId = new int?(bossId);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName(bossSwitchSequenceName, true, null);
		}

		// Token: 0x0603369A RID: 210586 RVA: 0x00C0113C File Offset: 0x00BFF33C
		private void RefreshBossTexture(int? bossId)
		{
			if (bossId == null)
			{
				return;
			}
			this.PendingBossId = null;
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueTower? rogueTower = (instance != null) ? instance.GetRogueTowerConfig(bossId.Value) : null;
			if (rogueTower == null || string.IsNullOrEmpty(rogueTower.Value.Stand))
			{
				return;
			}
			base.SetTextureByPath(rogueTower.Value.Stand, base.GetTexture(0), null, null);
		}

		// Token: 0x0603369B RID: 210587 RVA: 0x00C011C8 File Offset: 0x00BFF3C8
		private void RefreshDebuffList(int currentBossId)
		{
			List<RoguelikeBossChallengeBuffData> list = new List<RoguelikeBossChallengeBuffData>();
			int num = this.FinishedBossCount - 1;
			for (int i = this.SortedBossDataList.Count - 1; i >= 0; i--)
			{
				RoguelikeBossChallengeBossData roguelikeBossChallengeBossData = this.SortedBossDataList[i];
				if (roguelikeBossChallengeBossData.State != ERoguelikeBossChallengeBossState.Locked)
				{
					if (roguelikeBossChallengeBossData.State == ERoguelikeBossChallengeBossState.Finished)
					{
						RoguelikeConfig instance = RoguelikeConfig.Instance;
						RogueTower? rogueTower = (instance != null) ? instance.GetRogueTowerConfig(roguelikeBossChallengeBossData.Id) : null;
						int? num2 = null;
						if (((rogueTower != null) ? rogueTower.GetValueOrDefault().Buffs() : null) != null && num < rogueTower.Value.BuffsLength)
						{
							num2 = new int?(rogueTower.Value.Buffs()[num]);
						}
						if (num2 != null)
						{
							int? num3 = num2;
							int num4 = 0;
							if (!(num3.GetValueOrDefault() == num4 & num3 != null))
							{
								list.Add(new RoguelikeBossChallengeBuffData
								{
									BossId = roguelikeBossChallengeBossData.Id,
									Id = num2.Value,
									IsNew = false
								});
							}
						}
						num--;
					}
					if (roguelikeBossChallengeBossData.State == ERoguelikeBossChallengeBossState.Processing && roguelikeBossChallengeBossData.Id == currentBossId)
					{
						RoguelikeConfig instance2 = RoguelikeConfig.Instance;
						RogueTower? rogueTower2 = (instance2 != null) ? instance2.GetRogueTowerConfig(roguelikeBossChallengeBossData.Id) : null;
						int? num5 = null;
						if (((rogueTower2 != null) ? rogueTower2.GetValueOrDefault().Buffs() : null) != null && this.FinishedBossCount < rogueTower2.Value.BuffsLength)
						{
							num5 = new int?(rogueTower2.Value.Buffs()[this.FinishedBossCount]);
						}
						if (num5 != null)
						{
							int? num3 = num5;
							int num4 = 0;
							if (!(num3.GetValueOrDefault() == num4 & num3 != null))
							{
								list.Add(new RoguelikeBossChallengeBuffData
								{
									BossId = roguelikeBossChallengeBossData.Id,
									Id = num5.Value,
									IsNew = true
								});
							}
						}
					}
				}
			}
			RoguelikeBossChallengeDebuffListItem debuffListPanel = this.DebuffListPanel;
			if (debuffListPanel == null)
			{
				return;
			}
			debuffListPanel.RefreshDebuffList(list, currentBossId);
		}

		// Token: 0x0603369C RID: 210588 RVA: 0x00C013F4 File Offset: 0x00BFF5F4
		private string GetBossSwitchSequenceName(ERoguelikeBossChallengeSwitchDirection direction)
		{
			if (direction != ERoguelikeBossChallengeSwitchDirection.Left)
			{
				return "SwitchR";
			}
			return "SwitchL";
		}

		// Token: 0x0603369D RID: 210589 RVA: 0x00C01404 File Offset: 0x00BFF604
		private bool IsBossSwitchSequencePlaying()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null || !uiViewSequence.HasSequenceNameInPlaying("SwitchL"))
			{
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				return uiViewSequence2 != null && uiViewSequence2.HasSequenceNameInPlaying("SwitchR");
			}
			return true;
		}

		// Token: 0x0603369E RID: 210590 RVA: 0x00C01438 File Offset: 0x00BFF638
		private bool StopCurrentBossSwitchSequence()
		{
			bool result = false;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null && uiViewSequence.HasSequenceNameInPlaying("SwitchL"))
			{
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 != null)
				{
					uiViewSequence2.StopSequenceByKey("SwitchL", false, true);
				}
				result = true;
			}
			UiBehaviorLevelSequence uiViewSequence3 = this.UiViewSequence;
			if (uiViewSequence3 != null && uiViewSequence3.HasSequenceNameInPlaying("SwitchR"))
			{
				UiBehaviorLevelSequence uiViewSequence4 = this.UiViewSequence;
				if (uiViewSequence4 != null)
				{
					uiViewSequence4.StopSequenceByKey("SwitchR", false, true);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0603369F RID: 210591 RVA: 0x00C014AE File Offset: 0x00BFF6AE
		private void OnBossSequenceEvent(string sequenceName, string eventName)
		{
			this.RefreshBossTexture(this.PendingBossId);
		}

		// Token: 0x060336A0 RID: 210592 RVA: 0x00C014BC File Offset: 0x00BFF6BC
		private void OnBossIndexChanged(ERoguelikeBossChallengeSwitchDirection direction)
		{
			this.RefreshBossListBySelectedBoss();
			this.RefreshCurrentBossDisplayWithAnim(direction);
		}

		// Token: 0x060336A1 RID: 210593 RVA: 0x00C014CB File Offset: 0x00BFF6CB
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060336A2 RID: 210594 RVA: 0x00C014D4 File Offset: 0x00BFF6D4
		private void OnConfirmClick(int _)
		{
			RoguelikeBossChallengeSwitchItem bossSwitchPanel = this.BossSwitchPanel;
			int num = (bossSwitchPanel != null) ? bossSwitchPanel.GetCurrentBossId() : 0;
			if (num == 0)
			{
				return;
			}
			RoguelikeController.Instance.RoguelikeBossChallengeSelectBossRequest(num, delegate(bool success)
			{
				if (success)
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x060336A3 RID: 210595 RVA: 0x00C0150F File Offset: 0x00BFF70F
		private void OnDescModelChange()
		{
			RoguelikeBossChallengeDebuffListItem debuffListPanel = this.DebuffListPanel;
			if (debuffListPanel == null)
			{
				return;
			}
			debuffListPanel.OnDescModelChange();
		}

		// Token: 0x060336A4 RID: 210596 RVA: 0x00C01524 File Offset: 0x00BFF724
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (!(((configParams.Length != 0) ? configParams[0] : null) == "RogueLikeBossChallengeDebuffDetail"))
			{
				return null;
			}
			int index;
			int.TryParse((configParams.Length > 1) ? configParams[1] : null, out index);
			RoguelikeBossChallengeDebuffListItem debuffListPanel = this.DebuffListPanel;
			if (debuffListPanel == null)
			{
				return null;
			}
			RoguelikeBossChallengeDebuffItem uiItemByIndex = debuffListPanel.GetUiItemByIndex(index);
			if (uiItemByIndex == null)
			{
				return null;
			}
			UUIButtonComponent detailBtn = uiItemByIndex.GetDetailBtn();
			UUIItem uuiitem = (detailBtn != null) ? detailBtn.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401B4B8 RID: 111800
		private const string SWITCH_LEFT_SEQUENCE_NAME = "SwitchL";

		// Token: 0x0401B4B9 RID: 111801
		private const string SWITCH_RIGHT_SEQUENCE_NAME = "SwitchR";

		// Token: 0x0401B4BA RID: 111802
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B4BB RID: 111803
		[Nullable(2)]
		private RoguelikeBossChallengeSwitchItem BossSwitchPanel;

		// Token: 0x0401B4BC RID: 111804
		[Nullable(2)]
		private RoguelikeBossChallengeListItem BossListPanel;

		// Token: 0x0401B4BD RID: 111805
		[Nullable(2)]
		private RoguelikeBossChallengeDebuffListItem DebuffListPanel;

		// Token: 0x0401B4BE RID: 111806
		[Nullable(2)]
		private ButtonItem ConfirmButtonItem;

		// Token: 0x0401B4BF RID: 111807
		private List<RoguelikeBossChallengeBossData> SortedBossDataList = new List<RoguelikeBossChallengeBossData>();

		// Token: 0x0401B4C0 RID: 111808
		private List<int> SelectableBossIds = new List<int>();

		// Token: 0x0401B4C1 RID: 111809
		private int FinishedBossCount;

		// Token: 0x0401B4C2 RID: 111810
		private int? PendingBossId;

		// Token: 0x0401B4C3 RID: 111811
		[Nullable(2)]
		private AUIBaseActor TexBossActor;

		// Token: 0x0200AF47 RID: 44871
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035385 RID: 217989
			public const int TexBoss = 0;

			// Token: 0x04035386 RID: 217990
			public const int CaptionItem = 1;

			// Token: 0x04035387 RID: 217991
			public const int BossSwitchItem = 2;

			// Token: 0x04035388 RID: 217992
			public const int BossListItem = 3;

			// Token: 0x04035389 RID: 217993
			public const int DebuffListItem = 4;

			// Token: 0x0403538A RID: 217994
			public const int ConfirmButtonItem = 5;
		}
	}
}
