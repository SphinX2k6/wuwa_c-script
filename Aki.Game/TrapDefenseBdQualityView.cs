using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002197 RID: 8599
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdQualityView : UiViewBase
{
	// Token: 0x0601526A RID: 86634 RVA: 0x006273A7 File Offset: 0x006255A7
	public TrapDefenseBdQualityView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601526B RID: 86635 RVA: 0x006273C0 File Offset: 0x006255C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickBtnSure));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601526C RID: 86636 RVA: 0x00627594 File Offset: 0x00625794
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdQualityView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdQualityView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601526D RID: 86637 RVA: 0x006275D8 File Offset: 0x006257D8
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(9),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.TrapDefenseBuff
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0601526E RID: 86638 RVA: 0x00627614 File Offset: 0x00625814
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x0601526F RID: 86639 RVA: 0x00627616 File Offset: 0x00625816
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06015270 RID: 86640 RVA: 0x00627618 File Offset: 0x00625818
	protected override void OnBeforeShow()
	{
		if (this.ViewModel.CurSelectBdData != null)
		{
			this.UpdateData(this.ViewModel.CurSelectBdData);
		}
	}

	// Token: 0x06015271 RID: 86641 RVA: 0x00627638 File Offset: 0x00625838
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.OnViewClose();
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(9));
	}

	// Token: 0x06015272 RID: 86642 RVA: 0x00627657 File Offset: 0x00625857
	private void OnClickBtnSure()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015273 RID: 86643 RVA: 0x00627660 File Offset: 0x00625860
	public void UpdateData(TrapDefenseBdData data)
	{
		this.BdData = data;
		UUITexture texture = base.GetTexture(3);
		base.SetTextureByPath(data.Config.Icon, texture, null, null);
		base.GetText(4).ShowTextNew(data.Config.Name);
		this.SetNewQualityMode(this.ViewModel.IsNewQualityMode);
		this.UpdateBdBuffQuality();
	}

	// Token: 0x06015274 RID: 86644 RVA: 0x006276C6 File Offset: 0x006258C6
	public void SetNewQualityMode(bool isNew)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isNew);
	}

	// Token: 0x06015275 RID: 86645 RVA: 0x006276DC File Offset: 0x006258DC
	public void UpdateBdBuffQuality()
	{
		ETrapDefenseBdBuffQuality showQuality = this.ViewModel.ShowQuality;
		List<TrapDefenseBdBuffData> qualityBuffDataList = this.BdData.GetQualityBuffDataList(showQuality);
		bool flag = qualityBuffDataList.Count > 0;
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			int lastIndex = this.GetSelectGridIndex(qualityBuffDataList);
			this.LayoutBdBuff.RefreshByData(qualityBuffDataList, delegate
			{
				this.LayoutBdBuff.SelectGridProxy(Math.Max(lastIndex, 0), false);
			}, false);
		}
	}

	// Token: 0x06015276 RID: 86646 RVA: 0x00627755 File Offset: 0x00625955
	public int GetSelectGridIndex(List<TrapDefenseBdBuffData> list)
	{
		if (this.ViewModel.CurSelectBdBuffData != null)
		{
			return list.FindIndex((TrapDefenseBdBuffData item) => item.Id == this.ViewModel.CurSelectBdBuffData.Id);
		}
		return this.LayoutBdBuff.GetSelectedGridIndex();
	}

	// Token: 0x06015277 RID: 86647 RVA: 0x00627782 File Offset: 0x00625982
	private TrapDefenseBdBuffItem CreateItemBdBuff()
	{
		return new TrapDefenseBdBuffItem
		{
			OnSelectBuffItemCallback = new Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem>(this.OnSelectBdBuffItem)
		};
	}

	// Token: 0x06015278 RID: 86648 RVA: 0x0062779C File Offset: 0x0062599C
	private void OnSelectBdBuffItem(TrapDefenseBdBuffData data, TrapDefenseBdBuffItem _)
	{
		this.ViewModel.SetCurSelectBdBuffData(data);
		TrapDefenseBdBuff strengthenBeforeConfig = data.GetStrengthenBeforeConfig();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), strengthenBeforeConfig.Desc, strengthenBeforeConfig.DescArgs());
	}

	// Token: 0x06015279 RID: 86649 RVA: 0x006277DC File Offset: 0x006259DC
	private void OnBtnHelp()
	{
		int helpIdBdSum = TrapDefenseConfig.Instance.GetHelpIdBdSum();
		HelpController.Instance.OpenHelpById(helpIdBdSum);
	}

	// Token: 0x0601527A RID: 86650 RVA: 0x006277FF File Offset: 0x006259FF
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400B38B RID: 45963
	public PopupCaptionItem PopupCaption;

	// Token: 0x0400B38C RID: 45964
	public TrapDefenseBdData BdData;

	// Token: 0x0400B38D RID: 45965
	public GenericLayout<TrapDefenseBdBuffItem, TrapDefenseBdBuffData> LayoutBdBuff;

	// Token: 0x0400B38E RID: 45966
	public TrapDefenseBdQualityViewModel ViewModel = TrapDefenseModel.Instance.ViewModelBdQuality;

	// Token: 0x02008447 RID: 33863
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402AAB7 RID: 174775
		public const int ItemBgYellowLight = 0;

		// Token: 0x0402AAB8 RID: 174776
		public const int ItemBgRedLight = 1;

		// Token: 0x0402AAB9 RID: 174777
		public const int ItemCaption = 2;

		// Token: 0x0402AABA RID: 174778
		public const int TextureIcon = 3;

		// Token: 0x0402AABB RID: 174779
		public const int TextTitle = 4;

		// Token: 0x0402AABC RID: 174780
		public const int ItemNewAddRoot = 5;

		// Token: 0x0402AABD RID: 174781
		public const int TextNewAdd = 6;

		// Token: 0x0402AABE RID: 174782
		public const int LayoutBdBuff = 7;

		// Token: 0x0402AABF RID: 174783
		public const int ItemBdBuff = 8;

		// Token: 0x0402AAC0 RID: 174784
		public const int TextDesc = 9;

		// Token: 0x0402AAC1 RID: 174785
		public const int BtnSure = 10;
	}
}
