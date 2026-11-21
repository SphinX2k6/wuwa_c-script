using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x02003023 RID: 12323
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleResultView : UiViewBase
	{
		// Token: 0x0601D3D4 RID: 119764 RVA: 0x008ED5DF File Offset: 0x008EB7DF
		public EncircleResultView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D3D5 RID: 119765 RVA: 0x008ED5E8 File Offset: 0x008EB7E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D3D6 RID: 119766 RVA: 0x008ED6B4 File Offset: 0x008EB8B4
		protected override UniTask OnBeforeStartAsync()
		{
			EncircleResultView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EncircleResultView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D3D7 RID: 119767 RVA: 0x008ED6F7 File Offset: 0x008EB8F7
		protected override void OnBeforeShow()
		{
			this.RefreshTitle();
			this.RefreshRewardList();
			this.RefreshRecord();
		}

		// Token: 0x0601D3D8 RID: 119768 RVA: 0x008ED70B File Offset: 0x008EB90B
		private void RefreshRecord()
		{
			if (this.RewardData == null)
			{
				return;
			}
			EncircleRecordItem encircleRecordItem = this.EncircleRecordItem;
			if (encircleRecordItem == null)
			{
				return;
			}
			encircleRecordItem.Refresh(this.RewardData.GetRewardInfo());
		}

		// Token: 0x0601D3D9 RID: 119769 RVA: 0x008ED734 File Offset: 0x008EB934
		private void RefreshRewardList()
		{
			if (this.RewardData == null || this.RewardItemList == null)
			{
				return;
			}
			if (!this.RewardData.GetRewardInfo().IsSuccess)
			{
				this.RewardItemList.SetUiActive(false);
				return;
			}
			if (this.RewardData.GetRewardInfo().CommonItems == null)
			{
				this.RewardItemList.SetUiActive(false);
				return;
			}
			this.RewardItemList.SetUiActive(true);
			this.RewardItemList.Refresh(this.RewardData.GetRewardInfo().CommonItems, true);
		}

		// Token: 0x0601D3DA RID: 119770 RVA: 0x008ED7B8 File Offset: 0x008EB9B8
		protected virtual void RefreshTitle()
		{
			if (this.RewardData == null)
			{
				return;
			}
			UUIText text = base.GetText(1);
			UUITexture texture = base.GetTexture(2);
			UUIEffectOutline uuieffectOutline = text.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			if (this.IsSuccess())
			{
				LguiUtil.Instance.SetLocalTextNew(text, "CorniceMeetingSettleSuccess", Array.Empty<object>());
				text.outlineColor = FColor.FromHex("C48B29FF");
				texture.SetColor(FColor.FromHex("8C754D7F"));
				uuieffectOutline.SetOutlineColor(FColor.FromHex("C48B29FF"));
				text.SetColor(FColor.FromHex("f2efd5"));
				base.PlaySequence("Success", null, false);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "GenericPromptTypes_4_GeneralText", Array.Empty<object>());
			texture.SetColor(FColor.FromHex("6e363f"));
			text.SetColor(FColor.FromHex("F08086FF"));
			text.outlineColor = FColor.FromHex("B33100FF");
			uuieffectOutline.SetOutlineColor(FColor.FromHex("B33100FF"));
			base.PlaySequence("Fail", null, false);
		}

		// Token: 0x0601D3DB RID: 119771 RVA: 0x008ED8C6 File Offset: 0x008EBAC6
		private bool IsSuccess()
		{
			return this.RewardData != null && this.RewardData.GetRewardInfo().IsSuccess;
		}

		// Token: 0x0601D3DC RID: 119772 RVA: 0x008ED8E4 File Offset: 0x008EBAE4
		private UniTask InitButtonAsync()
		{
			EncircleResultView.<InitButtonAsync>d__16 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<EncircleResultView.<InitButtonAsync>d__16>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D3DD RID: 119773 RVA: 0x008ED928 File Offset: 0x008EBB28
		private UniTask CreateButton(UUIItem uiItem, int buttonIndex, Action clickFunction)
		{
			EncircleResultView.<CreateButton>d__17 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.buttonIndex = buttonIndex;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<EncircleResultView.<CreateButton>d__17>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x0601D3DE RID: 119774 RVA: 0x008ED97B File Offset: 0x008EBB7B
		private void OnReChallengeBtnClick()
		{
			UiManager.Instance.CloseView(EUiViewName.EncircleResultView, null);
			EncirclePlayLevelController.Instance.ResetEncircle();
		}

		// Token: 0x0601D3DF RID: 119775 RVA: 0x008ED997 File Offset: 0x008EBB97
		private void OnExitBtnClick()
		{
			UiManager.Instance.CloseView(EUiViewName.EncircleResultView, null);
			UiManager.Instance.CloseView(EUiViewName.EncirclePlayView, null);
		}

		// Token: 0x0400F63E RID: 63038
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x0400F63F RID: 63039
		private const string FAIL_OUTLINE_COLOR = "B33100FF";

		// Token: 0x0400F640 RID: 63040
		private const string FAIL_TEXT_COLOR = "F08086FF";

		// Token: 0x0400F641 RID: 63041
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x0400F642 RID: 63042
		protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

		// Token: 0x0400F643 RID: 63043
		[Nullable(2)]
		private RewardItemList RewardItemList;

		// Token: 0x0400F644 RID: 63044
		[Nullable(2)]
		private EncircleRecordItem EncircleRecordItem;

		// Token: 0x0400F645 RID: 63045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<IEncircleRewardInfo> RewardData;
	}
}
