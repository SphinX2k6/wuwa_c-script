using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006673 RID: 26227
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleResultView : UiViewBase
	{
		// Token: 0x06041BAC RID: 269228 RVA: 0x00FF153B File Offset: 0x00FEF73B
		public EncircleResultView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041BAD RID: 269229 RVA: 0x00FF1544 File Offset: 0x00FEF744
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x06041BAE RID: 269230 RVA: 0x00FF15CC File Offset: 0x00FEF7CC
		protected override UniTask OnBeforeStartAsync()
		{
			EncircleResultView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EncircleResultView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041BAF RID: 269231 RVA: 0x00FF160F File Offset: 0x00FEF80F
		protected override void OnBeforeShow()
		{
			this.RefreshTitle();
			this.RefreshRewardList();
			this.RefreshRecord();
		}

		// Token: 0x06041BB0 RID: 269232 RVA: 0x00FF1623 File Offset: 0x00FEF823
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

		// Token: 0x06041BB1 RID: 269233 RVA: 0x00FF164C File Offset: 0x00FEF84C
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

		// Token: 0x06041BB2 RID: 269234 RVA: 0x00FF16D0 File Offset: 0x00FEF8D0
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

		// Token: 0x06041BB3 RID: 269235 RVA: 0x00FF17DE File Offset: 0x00FEF9DE
		private bool IsSuccess()
		{
			return this.RewardData != null && this.RewardData.GetRewardInfo().IsSuccess;
		}

		// Token: 0x06041BB4 RID: 269236 RVA: 0x00FF17FC File Offset: 0x00FEF9FC
		private UniTask InitButtonAsync()
		{
			EncircleResultView.<InitButtonAsync>d__16 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<EncircleResultView.<InitButtonAsync>d__16>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041BB5 RID: 269237 RVA: 0x00FF1840 File Offset: 0x00FEFA40
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

		// Token: 0x06041BB6 RID: 269238 RVA: 0x00FF1893 File Offset: 0x00FEFA93
		private void OnReChallengeBtnClick()
		{
			UiManager.Instance.CloseView(EUiViewName.EncircleResultView, null);
			EncirclePlayLevelController.Instance.ResetEncircle();
		}

		// Token: 0x06041BB7 RID: 269239 RVA: 0x00FF18AF File Offset: 0x00FEFAAF
		private void OnExitBtnClick()
		{
			UiManager.Instance.CloseView(EUiViewName.EncircleResultView, null);
			UiManager.Instance.CloseView(EUiViewName.EncirclePlayView, null);
		}

		// Token: 0x04022334 RID: 140084
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x04022335 RID: 140085
		private const string FAIL_OUTLINE_COLOR = "B33100FF";

		// Token: 0x04022336 RID: 140086
		private const string FAIL_TEXT_COLOR = "F08086FF";

		// Token: 0x04022337 RID: 140087
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x04022338 RID: 140088
		protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

		// Token: 0x04022339 RID: 140089
		[Nullable(2)]
		private RewardItemList RewardItemList;

		// Token: 0x0402233A RID: 140090
		[Nullable(2)]
		private EncircleRecordItem EncircleRecordItem;

		// Token: 0x0402233B RID: 140091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<IEncircleRewardInfo> RewardData;
	}
}
