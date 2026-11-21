using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004115 RID: 16661
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaMainViewModel : IPhantomArenaDeckOverviewTabViewModel, IPhantomArenaTabViewModelBase, IPhantomArenaDeckBuilderTabViewModel, IPhantomArenaRoleSelectTabViewModel, IPhantomArenaChallengeDetailTabViewModel, IPhantomArenaMainViewModel
	{
		// Token: 0x1700546A RID: 21610
		// (get) Token: 0x0602A173 RID: 172403 RVA: 0x00BE640F File Offset: 0x00BE460F
		// (set) Token: 0x0602A174 RID: 172404 RVA: 0x00BE6417 File Offset: 0x00BE4617
		public Dictionary<int, int> QuicklyBuildDeckUseTimes { get; set; } = new Dictionary<int, int>();

		// Token: 0x1700546B RID: 21611
		// (get) Token: 0x0602A175 RID: 172405 RVA: 0x00BE6420 File Offset: 0x00BE4620
		// (set) Token: 0x0602A176 RID: 172406 RVA: 0x00BE6428 File Offset: 0x00BE4628
		public int LastQuicklyBuildId { get; set; }

		// Token: 0x1700546C RID: 21612
		// (get) Token: 0x0602A177 RID: 172407 RVA: 0x00BE6431 File Offset: 0x00BE4631
		// (set) Token: 0x0602A178 RID: 172408 RVA: 0x00BE6439 File Offset: 0x00BE4639
		public int SelectedCardRoleId { get; set; }

		// Token: 0x1700546D RID: 21613
		// (get) Token: 0x0602A179 RID: 172409 RVA: 0x00BE6442 File Offset: 0x00BE4642
		// (set) Token: 0x0602A17A RID: 172410 RVA: 0x00BE644A File Offset: 0x00BE464A
		public int TextureCardRoleId { get; set; }

		// Token: 0x1700546E RID: 21614
		// (get) Token: 0x0602A17B RID: 172411 RVA: 0x00BE6453 File Offset: 0x00BE4653
		// (set) Token: 0x0602A17C RID: 172412 RVA: 0x00BE645B File Offset: 0x00BE465B
		public bool RoleTextureActive { get; set; }

		// Token: 0x1700546F RID: 21615
		// (get) Token: 0x0602A17D RID: 172413 RVA: 0x00BE6464 File Offset: 0x00BE4664
		// (set) Token: 0x0602A17E RID: 172414 RVA: 0x00BE646C File Offset: 0x00BE466C
		[Nullable(2)]
		public DeckInfo RecommendDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005470 RID: 21616
		// (get) Token: 0x0602A17F RID: 172415 RVA: 0x00BE6475 File Offset: 0x00BE4675
		// (set) Token: 0x0602A180 RID: 172416 RVA: 0x00BE647D File Offset: 0x00BE467D
		public List<DeckInfo> EditableDeckList { get; set; } = new List<DeckInfo>();

		// Token: 0x17005471 RID: 21617
		// (get) Token: 0x0602A181 RID: 172417 RVA: 0x00BE6486 File Offset: 0x00BE4686
		// (set) Token: 0x0602A182 RID: 172418 RVA: 0x00BE648E File Offset: 0x00BE468E
		public int UsedDeckIndex { get; set; }

		// Token: 0x17005472 RID: 21618
		// (get) Token: 0x0602A183 RID: 172419 RVA: 0x00BE6497 File Offset: 0x00BE4697
		// (set) Token: 0x0602A184 RID: 172420 RVA: 0x00BE649F File Offset: 0x00BE469F
		public int SelectedDeckIndex { get; set; }

		// Token: 0x17005473 RID: 21619
		// (get) Token: 0x0602A185 RID: 172421 RVA: 0x00BE64A8 File Offset: 0x00BE46A8
		// (set) Token: 0x0602A186 RID: 172422 RVA: 0x00BE64B0 File Offset: 0x00BE46B0
		public bool CanShowRewardInRoleSelectTabView { get; set; }

		// Token: 0x17005474 RID: 21620
		// (get) Token: 0x0602A187 RID: 172423 RVA: 0x00BE64B9 File Offset: 0x00BE46B9
		// (set) Token: 0x0602A188 RID: 172424 RVA: 0x00BE64C1 File Offset: 0x00BE46C1
		public bool CanShowSelectBtnInRoleSelectTabView { get; set; }

		// Token: 0x17005475 RID: 21621
		// (get) Token: 0x0602A189 RID: 172425 RVA: 0x00BE64CA File Offset: 0x00BE46CA
		// (set) Token: 0x0602A18A RID: 172426 RVA: 0x00BE64D2 File Offset: 0x00BE46D2
		public bool CanShowSelectBtnInDeckOverviewTabView { get; set; }

		// Token: 0x17005476 RID: 21622
		// (get) Token: 0x0602A18B RID: 172427 RVA: 0x00BE64DB File Offset: 0x00BE46DB
		// (set) Token: 0x0602A18C RID: 172428 RVA: 0x00BE64E3 File Offset: 0x00BE46E3
		public int NpcId { get; set; }

		// Token: 0x17005477 RID: 21623
		// (get) Token: 0x0602A18D RID: 172429 RVA: 0x00BE64EC File Offset: 0x00BE46EC
		// (set) Token: 0x0602A18E RID: 172430 RVA: 0x00BE64F4 File Offset: 0x00BE46F4
		public int NpcDeckConfigId { get; set; }

		// Token: 0x17005478 RID: 21624
		// (get) Token: 0x0602A18F RID: 172431 RVA: 0x00BE64FD File Offset: 0x00BE46FD
		// (set) Token: 0x0602A190 RID: 172432 RVA: 0x00BE6505 File Offset: 0x00BE4705
		public List<int> CardRoleList { get; set; } = new List<int>();

		// Token: 0x17005479 RID: 21625
		// (get) Token: 0x0602A191 RID: 172433 RVA: 0x00BE650E File Offset: 0x00BE470E
		// (set) Token: 0x0602A192 RID: 172434 RVA: 0x00BE6516 File Offset: 0x00BE4716
		public bool RoleSelectedConfirmFlag { get; set; }

		// Token: 0x1700547A RID: 21626
		// (get) Token: 0x0602A193 RID: 172435 RVA: 0x00BE651F File Offset: 0x00BE471F
		// (set) Token: 0x0602A194 RID: 172436 RVA: 0x00BE6527 File Offset: 0x00BE4727
		public bool DeckSelectedConfirmFlag { get; set; }

		// Token: 0x1700547B RID: 21627
		// (get) Token: 0x0602A195 RID: 172437 RVA: 0x00BE6530 File Offset: 0x00BE4730
		// (set) Token: 0x0602A196 RID: 172438 RVA: 0x00BE6538 File Offset: 0x00BE4738
		public Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x1700547C RID: 21628
		// (get) Token: 0x0602A197 RID: 172439 RVA: 0x00BE6541 File Offset: 0x00BE4741
		// (set) Token: 0x0602A198 RID: 172440 RVA: 0x00BE6549 File Offset: 0x00BE4749
		public Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x1700547D RID: 21629
		// (get) Token: 0x0602A199 RID: 172441 RVA: 0x00BE6552 File Offset: 0x00BE4752
		// (set) Token: 0x0602A19A RID: 172442 RVA: 0x00BE655A File Offset: 0x00BE475A
		public Action<bool> HideRoleTexture { get; set; }

		// Token: 0x1700547E RID: 21630
		// (get) Token: 0x0602A19B RID: 172443 RVA: 0x00BE6563 File Offset: 0x00BE4763
		// (set) Token: 0x0602A19C RID: 172444 RVA: 0x00BE656B File Offset: 0x00BE476B
		public Action PlayRoleTextureShowAnim { get; set; }

		// Token: 0x1700547F RID: 21631
		// (get) Token: 0x0602A19D RID: 172445 RVA: 0x00BE6574 File Offset: 0x00BE4774
		// (set) Token: 0x0602A19E RID: 172446 RVA: 0x00BE657C File Offset: 0x00BE477C
		public Action RefreshRoleTexture { get; set; }

		// Token: 0x17005480 RID: 21632
		// (get) Token: 0x0602A19F RID: 172447 RVA: 0x00BE6585 File Offset: 0x00BE4785
		// (set) Token: 0x0602A1A0 RID: 172448 RVA: 0x00BE658D File Offset: 0x00BE478D
		public Action<string> SetViewTitle { get; set; }

		// Token: 0x17005481 RID: 21633
		// (get) Token: 0x0602A1A1 RID: 172449 RVA: 0x00BE6596 File Offset: 0x00BE4796
		// (set) Token: 0x0602A1A2 RID: 172450 RVA: 0x00BE659E File Offset: 0x00BE479E
		public Action<string> SetViewIcon { get; set; }

		// Token: 0x17005482 RID: 21634
		// (get) Token: 0x0602A1A3 RID: 172451 RVA: 0x00BE65A7 File Offset: 0x00BE47A7
		// (set) Token: 0x0602A1A4 RID: 172452 RVA: 0x00BE65AF File Offset: 0x00BE47AF
		public Action<int> SetViewHelpId { get; set; }

		// Token: 0x17005483 RID: 21635
		// (get) Token: 0x0602A1A5 RID: 172453 RVA: 0x00BE65B8 File Offset: 0x00BE47B8
		// (set) Token: 0x0602A1A6 RID: 172454 RVA: 0x00BE65C0 File Offset: 0x00BE47C0
		public Action<bool> SetViewHelpBtnActive { get; set; }

		// Token: 0x0602A1A7 RID: 172455 RVA: 0x00BE65CC File Offset: 0x00BE47CC
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

		// Token: 0x0602A1A8 RID: 172456 RVA: 0x00BE667D File Offset: 0x00BE487D
		public void SetOverrideCloseFunc(Action func)
		{
			this.OverrideCloseFunc = func;
		}

		// Token: 0x0602A1A9 RID: 172457 RVA: 0x00BE6686 File Offset: 0x00BE4886
		public void ResetOverrideCloseFunc()
		{
			this.OverrideCloseFunc = null;
		}

		// Token: 0x0602A1AA RID: 172458 RVA: 0x00BE668F File Offset: 0x00BE488F
		[NullableContext(2)]
		public Action GetOverrideCloseFunc()
		{
			return this.OverrideCloseFunc;
		}

		// Token: 0x0602A1AB RID: 172459 RVA: 0x00BE6697 File Offset: 0x00BE4897
		public void SetGetSwitchItemFunc([Nullable(new byte[]
		{
			1,
			2
		})] Func<PhantomArenaMainViewSwitchItem> getSwitchItemFunc)
		{
			this.GetSwitchItemFunc = getSwitchItemFunc;
		}

		// Token: 0x0602A1AC RID: 172460 RVA: 0x00BE66A0 File Offset: 0x00BE48A0
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

		// Token: 0x0602A1AD RID: 172461 RVA: 0x00BE66B3 File Offset: 0x00BE48B3
		public int GetChallengeId()
		{
			return this.ChallengeId;
		}

		// Token: 0x0602A1AE RID: 172462 RVA: 0x00BE66BB File Offset: 0x00BE48BB
		[NullableContext(2)]
		public PhantomBattleChallengeInfo GetChallengeInfo()
		{
			return this.ChallengeInfo;
		}

		// Token: 0x0602A1AF RID: 172463 RVA: 0x00BE66C3 File Offset: 0x00BE48C3
		[NullableContext(2)]
		public DeckInfo GetUsedDeck()
		{
			if (this.UsedDeckIndex < 0)
			{
				return null;
			}
			return PhantomArenaModel.Instance.GetDeckByDeckId(this.UsedDeckIndex, this.ActivityId);
		}

		// Token: 0x0602A1B0 RID: 172464 RVA: 0x00BE66E8 File Offset: 0x00BE48E8
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

		// Token: 0x0602A1B1 RID: 172465 RVA: 0x00BE6780 File Offset: 0x00BE4980
		[NullableContext(2)]
		public DeckInfo GetCurEditDeck()
		{
			return this.CurEditDeck;
		}

		// Token: 0x0602A1B2 RID: 172466 RVA: 0x00BE6788 File Offset: 0x00BE4988
		public List<DeckInfo> GetEditableDeckList()
		{
			return this.EditableDeckList;
		}

		// Token: 0x0602A1B3 RID: 172467 RVA: 0x00BE6790 File Offset: 0x00BE4990
		public DeckInfo CreateEmptyTempDeck()
		{
			return PhantomArenaModel.Instance.CreateEmptyTempDeckInfo(this.ActivityId);
		}

		// Token: 0x0602A1B4 RID: 172468 RVA: 0x00BE67A2 File Offset: 0x00BE49A2
		public DeckInfo CreateTempDeckFromDeck(DeckInfo srcDeck)
		{
			return srcDeck.DeepCopy();
		}

		// Token: 0x0602A1B5 RID: 172469 RVA: 0x00BE67AA File Offset: 0x00BE49AA
		public void StartEditDeck(DeckInfo deck)
		{
			this.CurEditDeck = deck;
			DeckInfo curEditDeck = this.CurEditDeck;
			this.CurEditDeckRecordInfo = ((curEditDeck != null) ? curEditDeck.Record() : null);
		}

		// Token: 0x0602A1B6 RID: 172470 RVA: 0x00BE67CB File Offset: 0x00BE49CB
		public void EndEditDeck()
		{
			this.CurEditDeck = null;
			this.CurEditDeckRecordInfo = null;
			this.QuicklyBuildDeckUseTimes.Clear();
			this.LastQuicklyBuildId = 0;
		}

		// Token: 0x0602A1B7 RID: 172471 RVA: 0x00BE67ED File Offset: 0x00BE49ED
		public void RecordDeck(DeckInfo deck)
		{
			DeckInfo curEditDeck = this.CurEditDeck;
			this.CurEditDeckRecordInfo = ((curEditDeck != null) ? curEditDeck.Record() : null);
		}

		// Token: 0x0602A1B8 RID: 172472 RVA: 0x00BE6807 File Offset: 0x00BE4A07
		public bool CheckCurEditDeckHasChange()
		{
			return this.CurEditDeckRecordInfo != null && this.CurEditDeck != null && this.CurEditDeck.CheckDeckDifferent(this.CurEditDeckRecordInfo);
		}

		// Token: 0x0602A1B9 RID: 172473 RVA: 0x00BE682C File Offset: 0x00BE4A2C
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

		// Token: 0x0602A1BA RID: 172474 RVA: 0x00BE6870 File Offset: 0x00BE4A70
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

		// Token: 0x0602A1BB RID: 172475 RVA: 0x00BE68C0 File Offset: 0x00BE4AC0
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

		// Token: 0x0602A1BC RID: 172476 RVA: 0x00BE6910 File Offset: 0x00BE4B10
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

		// Token: 0x04016F34 RID: 94004
		private int ChallengeId;

		// Token: 0x04016F35 RID: 94005
		public int ActivityId;

		// Token: 0x04016F36 RID: 94006
		[Nullable(2)]
		private PhantomBattleChallengeInfo ChallengeInfo;

		// Token: 0x04016F3C RID: 94012
		[Nullable(2)]
		private DeckInfo CurEditDeck;

		// Token: 0x04016F52 RID: 94034
		[Nullable(2)]
		private Action OverrideCloseFunc;

		// Token: 0x04016F53 RID: 94035
		[Nullable(2)]
		private Func<PhantomArenaMainViewSwitchItem> GetSwitchItemFunc;

		// Token: 0x04016F54 RID: 94036
		[Nullable(2)]
		private DeckRecordInfo CurEditDeckRecordInfo;
	}
}
