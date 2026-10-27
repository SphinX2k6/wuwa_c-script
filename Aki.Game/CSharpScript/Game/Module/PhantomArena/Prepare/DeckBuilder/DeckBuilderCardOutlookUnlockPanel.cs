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
	// Token: 0x02005193 RID: 20883
	[NullableContext(2)]
	[Nullable(0)]
	public class DeckBuilderCardOutlookUnlockPanel : UiPanelBase, IDeckBuilderCardInfoViewPanelSequencePlayer
	{
		// Token: 0x0603567E RID: 218750 RVA: 0x00CA60B8 File Offset: 0x00CA42B8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603567F RID: 218751 RVA: 0x00CA6114 File Offset: 0x00CA4314
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardOutlookUnlockPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardOutlookUnlockPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035680 RID: 218752 RVA: 0x00CA6157 File Offset: 0x00CA4357
		[NullableContext(1)]
		public void Refresh(IDeckBuilderCardOutlookUnlockPanelData data)
		{
			this.Data = data;
			this.CardItem.Refresh(data.CardId);
			this.RefreshOutlookUnlockedState();
		}

		// Token: 0x06035681 RID: 218753 RVA: 0x00CA6178 File Offset: 0x00CA4378
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

		// Token: 0x06035682 RID: 218754 RVA: 0x00CA62DA File Offset: 0x00CA44DA
		private void OnUnlockBtnClick(int _)
		{
			PhantomArenaController.Instance.CardOutLookUpRequest(this.Data.CardId, null);
		}

		// Token: 0x06035683 RID: 218755 RVA: 0x00CA62F4 File Offset: 0x00CA44F4
		public void PlaySwitchSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06035684 RID: 218756 RVA: 0x00CA631C File Offset: 0x00CA451C
		public void PlayShowSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0401C61A RID: 116250
		private IDeckBuilderCardOutlookUnlockPanelData Data;

		// Token: 0x0401C61B RID: 116251
		private CardOutlookPreviewItem CardItem;

		// Token: 0x0401C61C RID: 116252
		private ButtonItem UnlockBtnItem;

		// Token: 0x0401C61D RID: 116253
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B304 RID: 45828
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403640F RID: 222223
			public const int CardItem = 0;

			// Token: 0x04036410 RID: 222224
			public const int UnlockTipText = 1;

			// Token: 0x04036411 RID: 222225
			public const int UnlockBtnItem = 2;
		}
	}
}
