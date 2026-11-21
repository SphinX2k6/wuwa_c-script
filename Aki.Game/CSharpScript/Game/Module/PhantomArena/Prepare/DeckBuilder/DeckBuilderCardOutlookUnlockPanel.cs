using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004163 RID: 16739
	[NullableContext(2)]
	[Nullable(0)]
	public class DeckBuilderCardOutlookUnlockPanel : UiPanelBase, IDeckBuilderCardInfoViewPanelSequencePlayer
	{
		// Token: 0x0602A579 RID: 173433 RVA: 0x00BF366C File Offset: 0x00BF186C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602A57A RID: 173434 RVA: 0x00BF36C8 File Offset: 0x00BF18C8
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardOutlookUnlockPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardOutlookUnlockPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A57B RID: 173435 RVA: 0x00BF370B File Offset: 0x00BF190B
		[NullableContext(1)]
		public void Refresh(IDeckBuilderCardOutlookUnlockPanelData data)
		{
			this.Data = data;
			this.CardItem.Refresh(data.CardId);
			this.RefreshOutlookUnlockedState();
		}

		// Token: 0x0602A57C RID: 173436 RVA: 0x00BF372C File Offset: 0x00BF192C
		public void RefreshOutlookUnlockedState()
		{
			bool flag = PhantomArenaModel.Instance.IsCardOutlookUnlock(this.Data.CardId);
			this.UnlockBtnItem.SetActive(!flag);
			base.GetText(1).SetUIActive(!flag);
			if (!flag)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.CardId);
				int itemId = phantomBattleCardConfig.UpOutLookConsumeItems()[0].ItemId;
				int count = phantomBattleCardConfig.UpOutLookConsumeItems()[0].Count;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
				bool flag2 = FunctionModel.Instance.IsOpen(EFunctionType.PhantomArenaCardOutlookUnlock);
				bool flag3 = PhantomArenaModel.Instance.IsCardUnlock(this.Data.CardId);
				bool flag4 = flag2 && flag3;
				bool flag5 = itemCountByConfigId >= count;
				string iconSmall = ItemConfig.Instance.GetConfig(itemId).Value.IconSmall;
				string textStringId = flag5 ? "PhantomBattle_1012" : "PhantomBattle_1011";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlyArray<object>(new object[]
				{
					iconSmall,
					count
				}));
				base.GetText(1).SetUIActive(flag4);
				string textId = (!flag4) ? "GenericPrompt_Unlocked_TipsText" : "PhantomBattle_1131";
				this.UnlockBtnItem.SetEnableClick(flag4 && flag5);
				this.UnlockBtnItem.SetLocalTextNew(textId, Array.Empty<object>());
			}
		}

		// Token: 0x0602A57D RID: 173437 RVA: 0x00BF388E File Offset: 0x00BF1A8E
		private void OnUnlockBtnClick(int _)
		{
			PhantomArenaController.Instance.CardOutLookUpRequest(this.Data.CardId, null);
		}

		// Token: 0x0602A57E RID: 173438 RVA: 0x00BF38A8 File Offset: 0x00BF1AA8
		public void PlaySwitchSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0602A57F RID: 173439 RVA: 0x00BF38D0 File Offset: 0x00BF1AD0
		public void PlayShowSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0401704F RID: 94287
		private IDeckBuilderCardOutlookUnlockPanelData Data;

		// Token: 0x04017050 RID: 94288
		private CardOutlookPreviewItem CardItem;

		// Token: 0x04017051 RID: 94289
		private ButtonItem UnlockBtnItem;

		// Token: 0x04017052 RID: 94290
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x02009D3D RID: 40253
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E64 RID: 200292
			public const int CardItem = 0;

			// Token: 0x04030E65 RID: 200293
			public const int UnlockTipText = 1;

			// Token: 0x04030E66 RID: 200294
			public const int UnlockBtnItem = 2;
		}
	}
}
