using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005801 RID: 22529
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreOnlineChallengePlayer : UiPanelBase
	{
		// Token: 0x06039467 RID: 234599 RVA: 0x00D95270 File Offset: 0x00D93470
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

		// Token: 0x06039468 RID: 234600 RVA: 0x00D9531C File Offset: 0x00D9351C
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreOnlineChallengePlayer.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreOnlineChallengePlayer.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039469 RID: 234601 RVA: 0x00D9535F File Offset: 0x00D9355F
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshOnlineChallengePlayer, new Action(this.OnRefreshOnlineChallengePlayer));
		}

		// Token: 0x0603946A RID: 234602 RVA: 0x00D9537D File Offset: 0x00D9357D
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshOnlineChallengePlayer, new Action(this.OnRefreshOnlineChallengePlayer));
		}

		// Token: 0x0603946B RID: 234603 RVA: 0x00D9539C File Offset: 0x00D9359C
		private UniTask InitOnlineChallengePlayerList()
		{
			RewardExploreOnlineChallengePlayer.<InitOnlineChallengePlayerList>d__18 <InitOnlineChallengePlayerList>d__;
			<InitOnlineChallengePlayerList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOnlineChallengePlayerList>d__.<>4__this = this;
			<InitOnlineChallengePlayerList>d__.<>1__state = -1;
			<InitOnlineChallengePlayerList>d__.<>t__builder.Start<RewardExploreOnlineChallengePlayer.<InitOnlineChallengePlayerList>d__18>(ref <InitOnlineChallengePlayerList>d__);
			return <InitOnlineChallengePlayerList>d__.<>t__builder.Task;
		}

		// Token: 0x0603946C RID: 234604 RVA: 0x00D953DF File Offset: 0x00D935DF
		public void FullRefresh()
		{
			this.RefreshData();
			this.RefreshView();
		}

		// Token: 0x0603946D RID: 234605 RVA: 0x00D953F0 File Offset: 0x00D935F0
		private UniTask InitView()
		{
			RewardExploreOnlineChallengePlayer.<InitView>d__20 <InitView>d__;
			<InitView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitView>d__.<>4__this = this;
			<InitView>d__.<>1__state = -1;
			<InitView>d__.<>t__builder.Start<RewardExploreOnlineChallengePlayer.<InitView>d__20>(ref <InitView>d__);
			return <InitView>d__.<>t__builder.Task;
		}

		// Token: 0x0603946E RID: 234606 RVA: 0x00D95434 File Offset: 0x00D93634
		private void RefreshData()
		{
			List<ScenePlayerData> allScenePlayers = CreatureModel.Instance.GetAllScenePlayers();
			this.LastPlayerIdList = this.PlayerIdList;
			this.PlayerIdList = Array.Empty<int>();
			foreach (ScenePlayerData scenePlayerData in allScenePlayers)
			{
				EContinuingChallenge? continuingChallengeConfirmState = OnlineModel.Instance.GetContinuingChallengeConfirmState(scenePlayerData.GetPlayerId());
				EContinuingChallenge econtinuingChallenge = EContinuingChallenge.Accept;
				if (continuingChallengeConfirmState.GetValueOrDefault() == econtinuingChallenge & continuingChallengeConfirmState != null)
				{
					this.PlayerIdList.Append(scenePlayerData.GetPlayerId());
				}
			}
		}

		// Token: 0x0603946F RID: 234607 RVA: 0x00D954D4 File Offset: 0x00D936D4
		private void RefreshView()
		{
			if (this.PlayerIdList.Length == 0)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			int[] array = this.playerItemIndicesUsedBySeq[this.PlayerIdList.Length - 1];
			for (int i = 0; i < 3; i++)
			{
				if (i < this.PlayerIdList.Length)
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

		// Token: 0x06039470 RID: 234608 RVA: 0x00D9555C File Offset: 0x00D9375C
		private void ProcessSequence()
		{
			if (this.PlayerIdList.Length <= this.LastPlayerIdList.Length)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName(this.playerItemSeqNames[this.PlayerIdList.Length - 1], false, null, false);
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

		// Token: 0x06039471 RID: 234609 RVA: 0x00D955EC File Offset: 0x00D937EC
		private void OnRefreshOnlineChallengePlayer()
		{
			this.FullRefresh();
		}

		// Token: 0x06039472 RID: 234610 RVA: 0x00D955F4 File Offset: 0x00D937F4
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
			this.LastPlayerIdList = Array.Empty<int>();
			this.PlayerIdList = Array.Empty<int>();
			base..ctor();
		}

		// Token: 0x0401DF40 RID: 122688
		private const int MAX_PLAYER_COUNT = 3;

		// Token: 0x0401DF41 RID: 122689
		private readonly int[][] playerItemIndicesUsedBySeq;

		// Token: 0x0401DF42 RID: 122690
		private const string SEQ_NAME_PLAYER_01 = "Start01";

		// Token: 0x0401DF43 RID: 122691
		private const string SEQ_NAME_PLAYER_02 = "Start02";

		// Token: 0x0401DF44 RID: 122692
		private const string SEQ_NAME_PLAYER_03 = "Start03";

		// Token: 0x0401DF45 RID: 122693
		private const string SEQ_NAME_TEX = "Start_T";

		// Token: 0x0401DF46 RID: 122694
		private readonly int[] playerItemChildTypes;

		// Token: 0x0401DF47 RID: 122695
		private readonly string[] playerItemSeqNames;

		// Token: 0x0401DF48 RID: 122696
		private bool HasTextSeqEverPlayed;

		// Token: 0x0401DF49 RID: 122697
		private RewardExploreOnlineChallengePlayerItem[] PlayerItems;

		// Token: 0x0401DF4A RID: 122698
		private int[] LastPlayerIdList;

		// Token: 0x0401DF4B RID: 122699
		private int[] PlayerIdList;

		// Token: 0x0401DF4C RID: 122700
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B9F8 RID: 47608
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038386 RID: 230278
			public const int TextTips = 0;

			// Token: 0x04038387 RID: 230279
			public const int PlayerItemMiddle = 1;

			// Token: 0x04038388 RID: 230280
			public const int PlayerItemLeft = 2;

			// Token: 0x04038389 RID: 230281
			public const int PlayerItemRight = 3;
		}
	}
}
