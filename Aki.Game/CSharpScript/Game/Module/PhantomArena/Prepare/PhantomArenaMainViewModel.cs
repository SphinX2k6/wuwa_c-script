using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005145 RID: 20805
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaMainViewModel : IPhantomArenaDeckOverviewTabViewModel, IPhantomArenaTabViewModelBase, IPhantomArenaDeckBuilderTabViewModel, IPhantomArenaRoleSelectTabViewModel, IPhantomArenaChallengeDetailTabViewModel, IPhantomArenaMainViewModel
	{
		// Token: 0x170080AA RID: 32938
		// (get) Token: 0x06035277 RID: 217719 RVA: 0x00C98F0F File Offset: 0x00C9710F
		// (set) Token: 0x06035278 RID: 217720 RVA: 0x00C98F17 File Offset: 0x00C97117
		public Dictionary<int, int> QuicklyBuildDeckUseTimes { get; set; } = new Dictionary<int, int>();

		// Token: 0x170080AB RID: 32939
		// (get) Token: 0x06035279 RID: 217721 RVA: 0x00C98F20 File Offset: 0x00C97120
		// (set) Token: 0x0603527A RID: 217722 RVA: 0x00C98F28 File Offset: 0x00C97128
		public int LastQuicklyBuildId { get; set; }

		// Token: 0x170080AC RID: 32940
		// (get) Token: 0x0603527B RID: 217723 RVA: 0x00C98F31 File Offset: 0x00C97131
		// (set) Token: 0x0603527C RID: 217724 RVA: 0x00C98F39 File Offset: 0x00C97139
		public int SelectedCardRoleId { get; set; }

		// Token: 0x170080AD RID: 32941
		// (get) Token: 0x0603527D RID: 217725 RVA: 0x00C98F42 File Offset: 0x00C97142
		// (set) Token: 0x0603527E RID: 217726 RVA: 0x00C98F4A File Offset: 0x00C9714A
		public int TextureCardRoleId { get; set; }

		// Token: 0x170080AE RID: 32942
		// (get) Token: 0x0603527F RID: 217727 RVA: 0x00C98F53 File Offset: 0x00C97153
		// (set) Token: 0x06035280 RID: 217728 RVA: 0x00C98F5B File Offset: 0x00C9715B
		public bool RoleTextureActive { get; set; }

		// Token: 0x170080AF RID: 32943
		// (get) Token: 0x06035281 RID: 217729 RVA: 0x00C98F64 File Offset: 0x00C97164
		// (set) Token: 0x06035282 RID: 217730 RVA: 0x00C98F6C File Offset: 0x00C9716C
		[Nullable(2)]
		public DeckInfo RecommendDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170080B0 RID: 32944
		// (get) Token: 0x06035283 RID: 217731 RVA: 0x00C98F75 File Offset: 0x00C97175
		// (set) Token: 0x06035284 RID: 217732 RVA: 0x00C98F7D File Offset: 0x00C9717D
		public List<DeckInfo> EditableDeckList { get; set; } = new List<DeckInfo>();

		// Token: 0x170080B1 RID: 32945
		// (get) Token: 0x06035285 RID: 217733 RVA: 0x00C98F86 File Offset: 0x00C97186
		// (set) Token: 0x06035286 RID: 217734 RVA: 0x00C98F8E File Offset: 0x00C9718E
		public int UsedDeckIndex { get; set; }

		// Token: 0x170080B2 RID: 32946
		// (get) Token: 0x06035287 RID: 217735 RVA: 0x00C98F97 File Offset: 0x00C97197
		// (set) Token: 0x06035288 RID: 217736 RVA: 0x00C98F9F File Offset: 0x00C9719F
		public int SelectedDeckIndex { get; set; }

		// Token: 0x170080B3 RID: 32947
		// (get) Token: 0x06035289 RID: 217737 RVA: 0x00C98FA8 File Offset: 0x00C971A8
		// (set) Token: 0x0603528A RID: 217738 RVA: 0x00C98FB0 File Offset: 0x00C971B0
		public bool CanShowRewardInRoleSelectTabView { get; set; }

		// Token: 0x170080B4 RID: 32948
		// (get) Token: 0x0603528B RID: 217739 RVA: 0x00C98FB9 File Offset: 0x00C971B9
		// (set) Token: 0x0603528C RID: 217740 RVA: 0x00C98FC1 File Offset: 0x00C971C1
		public bool CanShowSelectBtnInRoleSelectTabView { get; set; }

		// Token: 0x170080B5 RID: 32949
		// (get) Token: 0x0603528D RID: 217741 RVA: 0x00C98FCA File Offset: 0x00C971CA
		// (set) Token: 0x0603528E RID: 217742 RVA: 0x00C98FD2 File Offset: 0x00C971D2
		public bool CanShowSelectBtnInDeckOverviewTabView { get; set; }

		// Token: 0x170080B6 RID: 32950
		// (get) Token: 0x0603528F RID: 217743 RVA: 0x00C98FDB File Offset: 0x00C971DB
		// (set) Token: 0x06035290 RID: 217744 RVA: 0x00C98FE3 File Offset: 0x00C971E3
		public int NpcId { get; set; }

		// Token: 0x170080B7 RID: 32951
		// (get) Token: 0x06035291 RID: 217745 RVA: 0x00C98FEC File Offset: 0x00C971EC
		// (set) Token: 0x06035292 RID: 217746 RVA: 0x00C98FF4 File Offset: 0x00C971F4
		public int NpcDeckConfigId { get; set; }

		// Token: 0x170080B8 RID: 32952
		// (get) Token: 0x06035293 RID: 217747 RVA: 0x00C98FFD File Offset: 0x00C971FD
		// (set) Token: 0x06035294 RID: 217748 RVA: 0x00C99005 File Offset: 0x00C97205
		public List<int> CardRoleList { get; set; } = new List<int>();

		// Token: 0x170080B9 RID: 32953
		// (get) Token: 0x06035295 RID: 217749 RVA: 0x00C9900E File Offset: 0x00C9720E
		// (set) Token: 0x06035296 RID: 217750 RVA: 0x00C99016 File Offset: 0x00C97216
		public bool RoleSelectedConfirmFlag { get; set; }

		// Token: 0x170080BA RID: 32954
		// (get) Token: 0x06035297 RID: 217751 RVA: 0x00C9901F File Offset: 0x00C9721F
		// (set) Token: 0x06035298 RID: 217752 RVA: 0x00C99027 File Offset: 0x00C97227
		public bool DeckSelectedConfirmFlag { get; set; }

		// Token: 0x170080BB RID: 32955
		// (get) Token: 0x06035299 RID: 217753 RVA: 0x00C99030 File Offset: 0x00C97230
		// (set) Token: 0x0603529A RID: 217754 RVA: 0x00C99038 File Offset: 0x00C97238
		public Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x170080BC RID: 32956
		// (get) Token: 0x0603529B RID: 217755 RVA: 0x00C99041 File Offset: 0x00C97241
		// (set) Token: 0x0603529C RID: 217756 RVA: 0x00C99049 File Offset: 0x00C97249
		public Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x170080BD RID: 32957
		// (get) Token: 0x0603529D RID: 217757 RVA: 0x00C99052 File Offset: 0x00C97252
		// (set) Token: 0x0603529E RID: 217758 RVA: 0x00C9905A File Offset: 0x00C9725A
		public Action<bool> HideRoleTexture { get; set; }

		// Token: 0x170080BE RID: 32958
		// (get) Token: 0x0603529F RID: 217759 RVA: 0x00C99063 File Offset: 0x00C97263
		// (set) Token: 0x060352A0 RID: 217760 RVA: 0x00C9906B File Offset: 0x00C9726B
		public Action PlayRoleTextureShowAnim { get; set; }

		// Token: 0x170080BF RID: 32959
		// (get) Token: 0x060352A1 RID: 217761 RVA: 0x00C99074 File Offset: 0x00C97274
		// (set) Token: 0x060352A2 RID: 217762 RVA: 0x00C9907C File Offset: 0x00C9727C
		public Action RefreshRoleTexture { get; set; }

		// Token: 0x170080C0 RID: 32960
		// (get) Token: 0x060352A3 RID: 217763 RVA: 0x00C99085 File Offset: 0x00C97285
		// (set) Token: 0x060352A4 RID: 217764 RVA: 0x00C9908D File Offset: 0x00C9728D
		public Action<string> SetViewTitle { get; set; }

		// Token: 0x170080C1 RID: 32961
		// (get) Token: 0x060352A5 RID: 217765 RVA: 0x00C99096 File Offset: 0x00C97296
		// (set) Token: 0x060352A6 RID: 217766 RVA: 0x00C9909E File Offset: 0x00C9729E
		public Action<string> SetViewIcon { get; set; }

		// Token: 0x170080C2 RID: 32962
		// (get) Token: 0x060352A7 RID: 217767 RVA: 0x00C990A7 File Offset: 0x00C972A7
		// (set) Token: 0x060352A8 RID: 217768 RVA: 0x00C990AF File Offset: 0x00C972AF
		public Action<int> SetViewHelpId { get; set; }

		// Token: 0x170080C3 RID: 32963
		// (get) Token: 0x060352A9 RID: 217769 RVA: 0x00C990B8 File Offset: 0x00C972B8
		// (set) Token: 0x060352AA RID: 217770 RVA: 0x00C990C0 File Offset: 0x00C972C0
		public Action<bool> SetViewHelpBtnActive { get; set; }

		// Token: 0x060352AB RID: 217771 RVA: 0x00C990CC File Offset: 0x00C972CC
		public void Init(int challengeId)
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			this.ChallengeId = challengeId;
			if (challengeId > 0)
			{
				this.ChallengeInfo = instance.GetChallengeData(challengeId);
				this.CanShowSelectBtnInRoleSelectTabView = true;
				this.CanShowRewardInRoleSelectTabView = false;
				this.CanShowSelectBtnInDeckOverviewTabView = true;
			}
			else
			{
				this.CanShowSelectBtnInRoleSelectTabView = false;
				this.CanShowRewardInRoleSelectTabView = true;
				this.CanShowSelectBtnInDeckOverviewTabView = false;
			}
			int lastUsedCardRoleId = instance.GetLastUsedCardRoleId(this.ActivityId);
			this.CardRoleList = instance.GetCardRoleList(this.ActivityId);
			this.SelectedCardRoleId = lastUsedCardRoleId;
			this.TextureCardRoleId = lastUsedCardRoleId;
			int lastUsedCardDeckServerId = instance.GetLastUsedCardDeckServerId(this.ActivityId);
			this.UsedDeckIndex = ((lastUsedCardDeckServerId >= 0) ? lastUsedCardDeckServerId : -1);
			this.SelectedDeckIndex = this.UsedDeckIndex;
			this.UpdateEditableDeckList();
		}

		// Token: 0x060352AC RID: 217772 RVA: 0x00C9917D File Offset: 0x00C9737D
		public void SetOverrideCloseFunc(Action func)
		{
			this.OverrideCloseFunc = func;
		}

		// Token: 0x060352AD RID: 217773 RVA: 0x00C99186 File Offset: 0x00C97386
		public void ResetOverrideCloseFunc()
		{
			this.OverrideCloseFunc = null;
		}

		// Token: 0x060352AE RID: 217774 RVA: 0x00C9918F File Offset: 0x00C9738F
		[NullableContext(2)]
		public Action GetOverrideCloseFunc()
		{
			return this.OverrideCloseFunc;
		}

		// Token: 0x060352AF RID: 217775 RVA: 0x00C99197 File Offset: 0x00C97397
		public void SetGetSwitchItemFunc([Nullable(new byte[]
		{
			1,
			2
		})] Func<PhantomArenaMainViewSwitchItem> getSwitchItemFunc)
		{
			this.GetSwitchItemFunc = getSwitchItemFunc;
		}

		// Token: 0x060352B0 RID: 217776 RVA: 0x00C991A0 File Offset: 0x00C973A0
		[NullableContext(2)]
		public PhantomArenaMainViewSwitchItem GetSwitchItem()
		{
			Func<PhantomArenaMainViewSwitchItem> getSwitchItemFunc = this.GetSwitchItemFunc;
			if (getSwitchItemFunc == null)
			{
				return null;
			}
			return getSwitchItemFunc();
		}

		// Token: 0x060352B1 RID: 217777 RVA: 0x00C991B3 File Offset: 0x00C973B3
		public int GetChallengeId()
		{
			return this.ChallengeId;
		}

		// Token: 0x060352B2 RID: 217778 RVA: 0x00C991BB File Offset: 0x00C973BB
		[NullableContext(2)]
		public PhantomBattleChallengeInfo GetChallengeInfo()
		{
			return this.ChallengeInfo;
		}

		// Token: 0x060352B3 RID: 217779 RVA: 0x00C991C3 File Offset: 0x00C973C3
		[NullableContext(2)]
		public DeckInfo GetUsedDeck()
		{
			if (this.UsedDeckIndex < 0)
			{
				return null;
			}
			return PhantomArenaModel.Instance.GetDeckByDeckId(this.UsedDeckIndex, this.ActivityId);
		}

		// Token: 0x060352B4 RID: 217780 RVA: 0x00C991E8 File Offset: 0x00C973E8
		public void UpdateEditableDeckList()
		{
			this.EditableDeckList = PhantomArenaModel.Instance.CreateEditableDeckListFromProtocolData(this.ActivityId);
			int count = this.EditableDeckList.Count;
			int maxDeckCount = PhantomArenaModel.Instance.GetPhantomArenaActivityData(this.ActivityId).GetMaxDeckCount();
			if (this.EditableDeckList.Count < maxDeckCount)
			{
				this.EditableDeckList.Add(this.CreateEmptyTempDeck());
			}
			this.SelectedDeckIndex = MathUtils.Instance.Clamp(this.SelectedDeckIndex, 0, this.EditableDeckList.Count - 1);
			if (this.UsedDeckIndex >= count)
			{
				this.UsedDeckIndex = -1;
			}
		}

		// Token: 0x060352B5 RID: 217781 RVA: 0x00C99280 File Offset: 0x00C97480
		[NullableContext(2)]
		public DeckInfo GetCurEditDeck()
		{
			return this.CurEditDeck;
		}

		// Token: 0x060352B6 RID: 217782 RVA: 0x00C99288 File Offset: 0x00C97488
		public List<DeckInfo> GetEditableDeckList()
		{
			return this.EditableDeckList;
		}

		// Token: 0x060352B7 RID: 217783 RVA: 0x00C99290 File Offset: 0x00C97490
		public DeckInfo CreateEmptyTempDeck()
		{
			return PhantomArenaModel.Instance.CreateEmptyTempDeckInfo(this.ActivityId);
		}

		// Token: 0x060352B8 RID: 217784 RVA: 0x00C992A2 File Offset: 0x00C974A2
		public DeckInfo CreateTempDeckFromDeck(DeckInfo srcDeck)
		{
			return srcDeck.DeepCopy();
		}

		// Token: 0x060352B9 RID: 217785 RVA: 0x00C992AA File Offset: 0x00C974AA
		public void StartEditDeck(DeckInfo deck)
		{
			this.CurEditDeck = deck;
			DeckInfo curEditDeck = this.CurEditDeck;
			this.CurEditDeckRecordInfo = ((curEditDeck != null) ? curEditDeck.Record() : null);
		}

		// Token: 0x060352BA RID: 217786 RVA: 0x00C992CB File Offset: 0x00C974CB
		public void EndEditDeck()
		{
			this.CurEditDeck = null;
			this.CurEditDeckRecordInfo = null;
			this.QuicklyBuildDeckUseTimes.Clear();
			this.LastQuicklyBuildId = 0;
		}

		// Token: 0x060352BB RID: 217787 RVA: 0x00C992ED File Offset: 0x00C974ED
		public void RecordDeck(DeckInfo deck)
		{
			DeckInfo curEditDeck = this.CurEditDeck;
			this.CurEditDeckRecordInfo = ((curEditDeck != null) ? curEditDeck.Record() : null);
		}

		// Token: 0x060352BC RID: 217788 RVA: 0x00C99307 File Offset: 0x00C97507
		public bool CheckCurEditDeckHasChange()
		{
			return this.CurEditDeckRecordInfo != null && this.CurEditDeck != null && this.CurEditDeck.CheckDeckDifferent(this.CurEditDeckRecordInfo);
		}

		// Token: 0x060352BD RID: 217789 RVA: 0x00C9932C File Offset: 0x00C9752C
		public void RecordQuicklyBuildClick(int quicklyBuildId)
		{
			int num;
			if (this.QuicklyBuildDeckUseTimes.TryGetValue(quicklyBuildId, out num))
			{
				this.QuicklyBuildDeckUseTimes[quicklyBuildId] = num + 1;
			}
			else
			{
				this.QuicklyBuildDeckUseTimes[quicklyBuildId] = 1;
			}
			this.LastQuicklyBuildId = quicklyBuildId;
		}

		// Token: 0x060352BE RID: 217790 RVA: 0x00C99370 File Offset: 0x00C97570
		public void ReportDeckDelete(DeckInfo deckInfo)
		{
			PhantomArenaReportDeckUpdateContext context = new PhantomArenaReportDeckUpdateContext
			{
				ActivityId = this.ActivityId,
				DeckInfo = deckInfo,
				Operation = EPhantomArenaReportDeckOperation.Delete,
				QuicklyBuildDeckUseTimes = this.QuicklyBuildDeckUseTimes,
				LastQuicklyBuildId = this.LastQuicklyBuildId
			};
			PhantomArenaController.Instance.ReportDeckUpdate(context);
		}

		// Token: 0x060352BF RID: 217791 RVA: 0x00C993C0 File Offset: 0x00C975C0
		public void ReportDeckCreate(DeckInfo deckInfo)
		{
			PhantomArenaReportDeckUpdateContext context = new PhantomArenaReportDeckUpdateContext
			{
				ActivityId = this.ActivityId,
				DeckInfo = deckInfo,
				Operation = EPhantomArenaReportDeckOperation.Create,
				QuicklyBuildDeckUseTimes = this.QuicklyBuildDeckUseTimes,
				LastQuicklyBuildId = this.LastQuicklyBuildId
			};
			PhantomArenaController.Instance.ReportDeckUpdate(context);
		}

		// Token: 0x060352C0 RID: 217792 RVA: 0x00C99410 File Offset: 0x00C97610
		public void ReportDeckCover(DeckInfo deckInfo)
		{
			PhantomArenaReportDeckUpdateContext context = new PhantomArenaReportDeckUpdateContext
			{
				ActivityId = this.ActivityId,
				DeckInfo = deckInfo,
				Operation = EPhantomArenaReportDeckOperation.Cover,
				QuicklyBuildDeckUseTimes = this.QuicklyBuildDeckUseTimes,
				LastQuicklyBuildId = this.LastQuicklyBuildId
			};
			PhantomArenaController.Instance.ReportDeckUpdate(context);
		}

		// Token: 0x0401C4FF RID: 115967
		private int ChallengeId;

		// Token: 0x0401C500 RID: 115968
		public int ActivityId;

		// Token: 0x0401C501 RID: 115969
		[Nullable(2)]
		private PhantomBattleChallengeInfo ChallengeInfo;

		// Token: 0x0401C507 RID: 115975
		[Nullable(2)]
		private DeckInfo CurEditDeck;

		// Token: 0x0401C51D RID: 115997
		[Nullable(2)]
		private Action OverrideCloseFunc;

		// Token: 0x0401C51E RID: 115998
		[Nullable(2)]
		private Func<PhantomArenaMainViewSwitchItem> GetSwitchItemFunc;

		// Token: 0x0401C51F RID: 115999
		[Nullable(2)]
		private DeckRecordInfo CurEditDeckRecordInfo;
	}
}
