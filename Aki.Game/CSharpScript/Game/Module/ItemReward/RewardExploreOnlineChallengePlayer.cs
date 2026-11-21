using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047D8 RID: 18392
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreOnlineChallengePlayer : UiPanelBase
	{
		// Token: 0x0602E37B RID: 189307 RVA: 0x00CE40BC File Offset: 0x00CE22BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E37C RID: 189308 RVA: 0x00CE4168 File Offset: 0x00CE2368
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreOnlineChallengePlayer.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreOnlineChallengePlayer.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E37D RID: 189309 RVA: 0x00CE41AB File Offset: 0x00CE23AB
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshOnlineChallengePlayer, new Action(this.OnRefreshOnlineChallengePlayer));
		}

		// Token: 0x0602E37E RID: 189310 RVA: 0x00CE41C9 File Offset: 0x00CE23C9
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshOnlineChallengePlayer, new Action(this.OnRefreshOnlineChallengePlayer));
		}

		// Token: 0x0602E37F RID: 189311 RVA: 0x00CE41E8 File Offset: 0x00CE23E8
		private UniTask InitOnlineChallengePlayerList()
		{
			RewardExploreOnlineChallengePlayer.<InitOnlineChallengePlayerList>d__18 <InitOnlineChallengePlayerList>d__;
			<InitOnlineChallengePlayerList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOnlineChallengePlayerList>d__.<>4__this = this;
			<InitOnlineChallengePlayerList>d__.<>1__state = -1;
			<InitOnlineChallengePlayerList>d__.<>t__builder.Start<RewardExploreOnlineChallengePlayer.<InitOnlineChallengePlayerList>d__18>(ref <InitOnlineChallengePlayerList>d__);
			return <InitOnlineChallengePlayerList>d__.<>t__builder.Task;
		}

		// Token: 0x0602E380 RID: 189312 RVA: 0x00CE422B File Offset: 0x00CE242B
		public void FullRefresh()
		{
			this.RefreshData();
			this.RefreshView();
		}

		// Token: 0x0602E381 RID: 189313 RVA: 0x00CE423C File Offset: 0x00CE243C
		private UniTask InitView()
		{
			RewardExploreOnlineChallengePlayer.<InitView>d__20 <InitView>d__;
			<InitView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitView>d__.<>4__this = this;
			<InitView>d__.<>1__state = -1;
			<InitView>d__.<>t__builder.Start<RewardExploreOnlineChallengePlayer.<InitView>d__20>(ref <InitView>d__);
			return <InitView>d__.<>t__builder.Task;
		}

		// Token: 0x0602E382 RID: 189314 RVA: 0x00CE4280 File Offset: 0x00CE2480
		private void RefreshData()
		{
			List<ScenePlayerData> allScenePlayers = CreatureModel.Instance.GetAllScenePlayers();
			this.LastPlayerIdList = this.PlayerIdList;
			this.PlayerIdList = new List<int>();
			foreach (ScenePlayerData scenePlayerData in allScenePlayers)
			{
				EContinuingChallenge? continuingChallengeConfirmState = OnlineModel.Instance.GetContinuingChallengeConfirmState(scenePlayerData.GetPlayerId());
				EContinuingChallenge econtinuingChallenge = EContinuingChallenge.Accept;
				if (continuingChallengeConfirmState.GetValueOrDefault() == econtinuingChallenge & continuingChallengeConfirmState != null)
				{
					this.PlayerIdList.Add(scenePlayerData.GetPlayerId());
				}
			}
		}

		// Token: 0x0602E383 RID: 189315 RVA: 0x00CE4320 File Offset: 0x00CE2520
		private void RefreshView()
		{
			if (this.PlayerIdList.Count == 0)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			int[] array = this.playerItemIndicesUsedBySeq[this.PlayerIdList.Count - 1];
			for (int i = 0; i < 3; i++)
			{
				if (i < this.PlayerIdList.Count)
				{
					this.PlayerItems[array[i]].SetUiActive(true);
					this.PlayerItems[array[i]].Refresh(this.PlayerIdList[i]);
				}
				else
				{
					this.PlayerItems[array[i]].SetUiActive(false);
				}
			}
		}

		// Token: 0x0602E384 RID: 189316 RVA: 0x00CE43B8 File Offset: 0x00CE25B8
		private void ProcessSequence()
		{
			if (this.PlayerIdList.Count <= this.LastPlayerIdList.Count)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName(this.playerItemSeqNames[this.PlayerIdList.Count - 1], false, null, false);
			}
			if (!this.HasTextSeqEverPlayed)
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlayLevelSequenceByName("Start_T", false, null, false);
				}
				this.HasTextSeqEverPlayed = true;
			}
		}

		// Token: 0x0602E385 RID: 189317 RVA: 0x00CE4451 File Offset: 0x00CE2651
		private void OnRefreshOnlineChallengePlayer()
		{
			this.FullRefresh();
		}

		// Token: 0x0602E386 RID: 189318 RVA: 0x00CE445C File Offset: 0x00CE265C
		public RewardExploreOnlineChallengePlayer()
		{
			int[][] array = new int[3][];
			array[0] = new int[]
			{
				0,
				1,
				2
			};
			int num = 1;
			int[] array2 = new int[3];
			array2[0] = 1;
			array2[1] = 2;
			array[num] = array2;
			array[2] = new int[]
			{
				0,
				1,
				2
			};
			this.playerItemIndicesUsedBySeq = array;
			this.playerItemChildTypes = new int[]
			{
				2,
				1,
				3
			};
			this.playerItemSeqNames = new string[]
			{
				"Start01",
				"Start02",
				"Start03"
			};
			this.PlayerItems = Array.Empty<RewardExploreOnlineChallengePlayerItem>();
			this.LastPlayerIdList = new List<int>();
			this.PlayerIdList = new List<int>();
			base..ctor();
		}

		// Token: 0x040189D7 RID: 100823
		private const int MAX_PLAYER_COUNT = 3;

		// Token: 0x040189D8 RID: 100824
		private readonly int[][] playerItemIndicesUsedBySeq;

		// Token: 0x040189D9 RID: 100825
		private const string SEQ_NAME_PLAYER_01 = "Start01";

		// Token: 0x040189DA RID: 100826
		private const string SEQ_NAME_PLAYER_02 = "Start02";

		// Token: 0x040189DB RID: 100827
		private const string SEQ_NAME_PLAYER_03 = "Start03";

		// Token: 0x040189DC RID: 100828
		private const string SEQ_NAME_TEX = "Start_T";

		// Token: 0x040189DD RID: 100829
		private readonly int[] playerItemChildTypes;

		// Token: 0x040189DE RID: 100830
		private readonly string[] playerItemSeqNames;

		// Token: 0x040189DF RID: 100831
		private bool HasTextSeqEverPlayed;

		// Token: 0x040189E0 RID: 100832
		private RewardExploreOnlineChallengePlayerItem[] PlayerItems;

		// Token: 0x040189E1 RID: 100833
		private List<int> LastPlayerIdList;

		// Token: 0x040189E2 RID: 100834
		private List<int> PlayerIdList;

		// Token: 0x040189E3 RID: 100835
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A40E RID: 41998
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032D73 RID: 208243
			public const int TextTips = 0;

			// Token: 0x04032D74 RID: 208244
			public const int PlayerItemMiddle = 1;

			// Token: 0x04032D75 RID: 208245
			public const int PlayerItemLeft = 2;

			// Token: 0x04032D76 RID: 208246
			public const int PlayerItemRight = 3;
		}
	}
}
