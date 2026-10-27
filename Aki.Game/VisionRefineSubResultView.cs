using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001774 RID: 6004
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineSubResultView : UiViewBase
{
	// Token: 0x0600AE24 RID: 44580 RVA: 0x00273D69 File Offset: 0x00271F69
	public VisionRefineSubResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AE25 RID: 44581 RVA: 0x00273D74 File Offset: 0x00271F74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
	}

	// Token: 0x0600AE26 RID: 44582 RVA: 0x00273E54 File Offset: 0x00272054
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineSubResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineSubResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE27 RID: 44583 RVA: 0x00273E97 File Offset: 0x00272097
	private VisionRefineAttributeItem InitAttrItem()
	{
		return new VisionRefineAttributeItem();
	}

	// Token: 0x0600AE28 RID: 44584 RVA: 0x00273EA0 File Offset: 0x002720A0
	private void RefreshAvailableAttrTips(VisionRefineBatchResultViewData data)
	{
		if (!data.HasRecommendData)
		{
			UUIText text = base.GetText(7);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIText text2 = base.GetText(8);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
			return;
		}
		else
		{
			int num = this.CalcRecommentCount(data.LeftAttrList);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Text_Refresh_HaveAvailableAttr", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
			UUIText text3 = base.GetText(7);
			if (text3 != null)
			{
				text3.SetUIActive(true);
			}
			int num2 = this.CalcRecommentCount(data.RightAttrList);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Text_Refresh_HaveAvailableAttr", new <>z__ReadOnlySingleElementList<object>(num2.ToString()));
			UUIText text4 = base.GetText(8);
			if (text4 == null)
			{
				return;
			}
			text4.SetUIActive(true);
			return;
		}
	}

	// Token: 0x0600AE29 RID: 44585 RVA: 0x00273F60 File Offset: 0x00272160
	private int CalcRecommentCount(VisionRefineAttributeItemData[] attrList)
	{
		int num = 0;
		for (int i = 0; i < attrList.Length; i++)
		{
			if (attrList[i].IsRecommend)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600AE2A RID: 44586 RVA: 0x00273F90 File Offset: 0x00272190
	private void OnClickCancel()
	{
		VisionRefineBatchResultViewData visionRefineBatchResultViewData = this.OpenParam as VisionRefineBatchResultViewData;
		int num = this.CalcRecommentCount(visionRefineBatchResultViewData.LeftAttrList);
		int num2 = this.CalcRecommentCount(visionRefineBatchResultViewData.RightAttrList);
		if (num < num2)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionRefineSubResultConfirm);
			Action value = delegate()
			{
				this.OnClickCancelInternal().Forget();
			};
			confirmBoxDataNew.FunctionMap[2] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (!PhantomBattleModel.Instance.PhantomRefineRejectIgnore)
		{
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomRefreshRejectConfirm);
			Action value2 = delegate()
			{
				this.OnClickCancelInternal().Forget();
			};
			confirmBoxDataNew2.FunctionMap[2] = value2;
			confirmBoxDataNew2.HasToggle = true;
			confirmBoxDataNew2.ToggleTextKey = "PhantomProject_CommonText";
			confirmBoxDataNew2.SetToggleFunction(delegate(bool isSelect)
			{
				PhantomBattleModel.Instance.PhantomRefineRejectIgnore = isSelect;
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
			return;
		}
		this.OnClickCancelInternal().Forget();
	}

	// Token: 0x0600AE2B RID: 44587 RVA: 0x00274080 File Offset: 0x00272280
	private UniTask OnClickCancelInternal()
	{
		VisionRefineSubResultView.<OnClickCancelInternal>d__13 <OnClickCancelInternal>d__;
		<OnClickCancelInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnClickCancelInternal>d__.<>4__this = this;
		<OnClickCancelInternal>d__.<>1__state = -1;
		<OnClickCancelInternal>d__.<>t__builder.Start<VisionRefineSubResultView.<OnClickCancelInternal>d__13>(ref <OnClickCancelInternal>d__);
		return <OnClickCancelInternal>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE2C RID: 44588 RVA: 0x002740C4 File Offset: 0x002722C4
	private void OnClickConfirm()
	{
		if (PhantomBattleModel.Instance.PhantomRefineAcceptIgnore)
		{
			this.OnClickConfirmInternal().Forget();
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomRefreshAcceptConfirm);
		Action value = delegate()
		{
			this.OnClickConfirmInternal().Forget();
		};
		confirmBoxDataNew.FunctionMap[2] = value;
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleTextKey = "PhantomProject_CommonText";
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelect)
		{
			PhantomBattleModel.Instance.PhantomRefineAcceptIgnore = isSelect;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600AE2D RID: 44589 RVA: 0x00274154 File Offset: 0x00272354
	private UniTask OnClickConfirmInternal()
	{
		VisionRefineSubResultView.<OnClickConfirmInternal>d__15 <OnClickConfirmInternal>d__;
		<OnClickConfirmInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnClickConfirmInternal>d__.<>4__this = this;
		<OnClickConfirmInternal>d__.<>1__state = -1;
		<OnClickConfirmInternal>d__.<>t__builder.Start<VisionRefineSubResultView.<OnClickConfirmInternal>d__15>(ref <OnClickConfirmInternal>d__);
		return <OnClickConfirmInternal>d__.<>t__builder.Task;
	}

	// Token: 0x04004F1F RID: 20255
	[Nullable(2)]
	private VisionRefineSlotItem SlotItem;

	// Token: 0x04004F20 RID: 20256
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineAttributeItem, VisionRefineAttributeItemData> LeftVert;

	// Token: 0x04004F21 RID: 20257
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineAttributeItem, VisionRefineAttributeItemData> RightVert;

	// Token: 0x04004F22 RID: 20258
	[Nullable(2)]
	private VisionRefineBatchResultButton LeftBtn;

	// Token: 0x04004F23 RID: 20259
	[Nullable(2)]
	private VisionRefineBatchResultButton RightBtn;

	// Token: 0x02007D6A RID: 32106
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029123 RID: 168227
		SlotItem,
		// Token: 0x04029124 RID: 168228
		LeftVertical,
		// Token: 0x04029125 RID: 168229
		RightVertical,
		// Token: 0x04029126 RID: 168230
		VerticalItem,
		// Token: 0x04029127 RID: 168231
		LeftButtonItem,
		// Token: 0x04029128 RID: 168232
		RightButtonItem,
		// Token: 0x04029129 RID: 168233
		MidDownTipText,
		// Token: 0x0402912A RID: 168234
		LeftVerticalTips,
		// Token: 0x0402912B RID: 168235
		RightVerticalTips
	}
}
