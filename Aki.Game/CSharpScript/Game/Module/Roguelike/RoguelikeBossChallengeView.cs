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
	// Token: 0x02003D99 RID: 15769
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeView : UiViewBase
	{
		// Token: 0x060284FA RID: 165114 RVA: 0x00B4A05F File Offset: 0x00B4825F
		public RoguelikeBossChallengeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060284FB RID: 165115 RVA: 0x00B4A080 File Offset: 0x00B48280
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

		// Token: 0x060284FC RID: 165116 RVA: 0x00B4A170 File Offset: 0x00B48370
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeBossChallengeView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeBossChallengeView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060284FD RID: 165117 RVA: 0x00B4A1B4 File Offset: 0x00B483B4
		protected override void OnStart()
		{
			this.BossSwitchPanel.SetOnBossChangedCallback(new Action<ERoguelikeBossChallengeSwitchDirection>(this.OnBossIndexChanged));
			this.TexBossActor = (base.GetTexture(0).GetOwner() as AUIBaseActor);
			this.TexBossActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnBossSequenceEvent));
			this.InitBossData();
		}

		// Token: 0x060284FE RID: 165118 RVA: 0x00B4A211 File Offset: 0x00B48411
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor texBossActor = this.TexBossActor;
			if (texBossActor != null)
			{
				texBossActor.OnSequencePlayEvent.Unbind();
			}
			this.TexBossActor = null;
		}

		// Token: 0x060284FF RID: 165119 RVA: 0x00B4A230 File Offset: 0x00B48430
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x06028500 RID: 165120 RVA: 0x00B4A24E File Offset: 0x00B4844E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
		}

		// Token: 0x06028501 RID: 165121 RVA: 0x00B4A26C File Offset: 0x00B4846C
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

		// Token: 0x06028502 RID: 165122 RVA: 0x00B4A43C File Offset: 0x00B4863C
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

		// Token: 0x06028503 RID: 165123 RVA: 0x00B4A580 File Offset: 0x00B48780
		private void RefreshBossListBySelectedBoss()
		{
			RoguelikeBossChallengeSwitchItem bossSwitchPanel = this.BossSwitchPanel;
			int num = (bossSwitchPanel != null) ? bossSwitchPanel.GetCurrentBossId() : 0;
			List<RoguelikeBossChallengeBossData> dataList = this.BuildDisplayBossDataList(num);
			this.BossListPanel.RefreshBossList(dataList, num);
		}

		// Token: 0x06028504 RID: 165124 RVA: 0x00B4A5B8 File Offset: 0x00B487B8
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

		// Token: 0x06028505 RID: 165125 RVA: 0x00B4A5F0 File Offset: 0x00B487F0
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

		// Token: 0x06028506 RID: 165126 RVA: 0x00B4A640 File Offset: 0x00B48840
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

		// Token: 0x06028507 RID: 165127 RVA: 0x00B4A67C File Offset: 0x00B4887C
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

		// Token: 0x06028508 RID: 165128 RVA: 0x00B4A708 File Offset: 0x00B48908
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

		// Token: 0x06028509 RID: 165129 RVA: 0x00B4A934 File Offset: 0x00B48B34
		private string GetBossSwitchSequenceName(ERoguelikeBossChallengeSwitchDirection direction)
		{
			if (direction != ERoguelikeBossChallengeSwitchDirection.Left)
			{
				return "SwitchR";
			}
			return "SwitchL";
		}

		// Token: 0x0602850A RID: 165130 RVA: 0x00B4A944 File Offset: 0x00B48B44
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

		// Token: 0x0602850B RID: 165131 RVA: 0x00B4A978 File Offset: 0x00B48B78
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

		// Token: 0x0602850C RID: 165132 RVA: 0x00B4A9EE File Offset: 0x00B48BEE
		private void OnBossSequenceEvent(string sequenceName, string eventName)
		{
			this.RefreshBossTexture(this.PendingBossId);
		}

		// Token: 0x0602850D RID: 165133 RVA: 0x00B4A9FC File Offset: 0x00B48BFC
		private void OnBossIndexChanged(ERoguelikeBossChallengeSwitchDirection direction)
		{
			this.RefreshBossListBySelectedBoss();
			this.RefreshCurrentBossDisplayWithAnim(direction);
		}

		// Token: 0x0602850E RID: 165134 RVA: 0x00B4AA0B File Offset: 0x00B48C0B
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602850F RID: 165135 RVA: 0x00B4AA14 File Offset: 0x00B48C14
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

		// Token: 0x06028510 RID: 165136 RVA: 0x00B4AA4F File Offset: 0x00B48C4F
		private void OnDescModelChange()
		{
			RoguelikeBossChallengeDebuffListItem debuffListPanel = this.DebuffListPanel;
			if (debuffListPanel == null)
			{
				return;
			}
			debuffListPanel.OnDescModelChange();
		}

		// Token: 0x06028511 RID: 165137 RVA: 0x00B4AA64 File Offset: 0x00B48C64
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

		// Token: 0x04015E8B RID: 89739
		private const string SWITCH_LEFT_SEQUENCE_NAME = "SwitchL";

		// Token: 0x04015E8C RID: 89740
		private const string SWITCH_RIGHT_SEQUENCE_NAME = "SwitchR";

		// Token: 0x04015E8D RID: 89741
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04015E8E RID: 89742
		[Nullable(2)]
		private RoguelikeBossChallengeSwitchItem BossSwitchPanel;

		// Token: 0x04015E8F RID: 89743
		[Nullable(2)]
		private RoguelikeBossChallengeListItem BossListPanel;

		// Token: 0x04015E90 RID: 89744
		[Nullable(2)]
		private RoguelikeBossChallengeDebuffListItem DebuffListPanel;

		// Token: 0x04015E91 RID: 89745
		[Nullable(2)]
		private ButtonItem ConfirmButtonItem;

		// Token: 0x04015E92 RID: 89746
		private List<RoguelikeBossChallengeBossData> SortedBossDataList = new List<RoguelikeBossChallengeBossData>();

		// Token: 0x04015E93 RID: 89747
		private List<int> SelectableBossIds = new List<int>();

		// Token: 0x04015E94 RID: 89748
		private int FinishedBossCount;

		// Token: 0x04015E95 RID: 89749
		private int? PendingBossId;

		// Token: 0x04015E96 RID: 89750
		[Nullable(2)]
		private AUIBaseActor TexBossActor;

		// Token: 0x0200997C RID: 39292
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FDBA RID: 196026
			public const int TexBoss = 0;

			// Token: 0x0402FDBB RID: 196027
			public const int CaptionItem = 1;

			// Token: 0x0402FDBC RID: 196028
			public const int BossSwitchItem = 2;

			// Token: 0x0402FDBD RID: 196029
			public const int BossListItem = 3;

			// Token: 0x0402FDBE RID: 196030
			public const int DebuffListItem = 4;

			// Token: 0x0402FDBF RID: 196031
			public const int ConfirmButtonItem = 5;
		}
	}
}
