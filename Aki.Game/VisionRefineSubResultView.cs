using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C2D RID: 3117
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineSubResultView : UiViewBase
{
	// Token: 0x0600820B RID: 33291 RVA: 0x0027E22D File Offset: 0x0027C42D
	public VisionRefineSubResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600820C RID: 33292 RVA: 0x0027E238 File Offset: 0x0027C438
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

	// Token: 0x0600820D RID: 33293 RVA: 0x0027E318 File Offset: 0x0027C518
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineSubResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineSubResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600820E RID: 33294 RVA: 0x0027E35B File Offset: 0x0027C55B
	private VisionRefineAttributeItem InitAttrItem()
	{
		return new VisionRefineAttributeItem();
	}

	// Token: 0x0600820F RID: 33295 RVA: 0x0027E364 File Offset: 0x0027C564
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

	// Token: 0x06008210 RID: 33296 RVA: 0x0027E424 File Offset: 0x0027C624
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

	// Token: 0x06008211 RID: 33297 RVA: 0x0027E454 File Offset: 0x0027C654
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

	// Token: 0x06008212 RID: 33298 RVA: 0x0027E544 File Offset: 0x0027C744
	private UniTask OnClickCancelInternal()
	{
		VisionRefineSubResultView.<OnClickCancelInternal>d__13 <OnClickCancelInternal>d__;
		<OnClickCancelInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnClickCancelInternal>d__.<>4__this = this;
		<OnClickCancelInternal>d__.<>1__state = -1;
		<OnClickCancelInternal>d__.<>t__builder.Start<VisionRefineSubResultView.<OnClickCancelInternal>d__13>(ref <OnClickCancelInternal>d__);
		return <OnClickCancelInternal>d__.<>t__builder.Task;
	}

	// Token: 0x06008213 RID: 33299 RVA: 0x0027E588 File Offset: 0x0027C788
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

	// Token: 0x06008214 RID: 33300 RVA: 0x0027E618 File Offset: 0x0027C818
	private UniTask OnClickConfirmInternal()
	{
		VisionRefineSubResultView.<OnClickConfirmInternal>d__15 <OnClickConfirmInternal>d__;
		<OnClickConfirmInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnClickConfirmInternal>d__.<>4__this = this;
		<OnClickConfirmInternal>d__.<>1__state = -1;
		<OnClickConfirmInternal>d__.<>t__builder.Start<VisionRefineSubResultView.<OnClickConfirmInternal>d__15>(ref <OnClickConfirmInternal>d__);
		return <OnClickConfirmInternal>d__.<>t__builder.Task;
	}

	// Token: 0x04004FC9 RID: 20425
	[Nullable(2)]
	private VisionRefineSlotItem SlotItem;

	// Token: 0x04004FCA RID: 20426
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineAttributeItem, VisionRefineAttributeItemData> LeftVert;

	// Token: 0x04004FCB RID: 20427
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineAttributeItem, VisionRefineAttributeItemData> RightVert;

	// Token: 0x04004FCC RID: 20428
	[Nullable(2)]
	private VisionRefineBatchResultButton LeftBtn;

	// Token: 0x04004FCD RID: 20429
	[Nullable(2)]
	private VisionRefineBatchResultButton RightBtn;

	// Token: 0x02006EF0 RID: 28400
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402444E RID: 148558
		SlotItem,
		// Token: 0x0402444F RID: 148559
		LeftVertical,
		// Token: 0x04024450 RID: 148560
		RightVertical,
		// Token: 0x04024451 RID: 148561
		VerticalItem,
		// Token: 0x04024452 RID: 148562
		LeftButtonItem,
		// Token: 0x04024453 RID: 148563
		RightButtonItem,
		// Token: 0x04024454 RID: 148564
		MidDownTipText,
		// Token: 0x04024455 RID: 148565
		LeftVerticalTips,
		// Token: 0x04024456 RID: 148566
		RightVerticalTips
	}
}
