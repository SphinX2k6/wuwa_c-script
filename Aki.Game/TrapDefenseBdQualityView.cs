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

// Token: 0x02002C1C RID: 11292
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdQualityView : UiViewBase
{
	// Token: 0x06017838 RID: 96312 RVA: 0x005FA983 File Offset: 0x005F8B83
	public TrapDefenseBdQualityView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06017839 RID: 96313 RVA: 0x005FA99C File Offset: 0x005F8B9C
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

	// Token: 0x0601783A RID: 96314 RVA: 0x005FAB70 File Offset: 0x005F8D70
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdQualityView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdQualityView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601783B RID: 96315 RVA: 0x005FABB4 File Offset: 0x005F8DB4
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

	// Token: 0x0601783C RID: 96316 RVA: 0x005FABF0 File Offset: 0x005F8DF0
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x0601783D RID: 96317 RVA: 0x005FABF2 File Offset: 0x005F8DF2
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x0601783E RID: 96318 RVA: 0x005FABF4 File Offset: 0x005F8DF4
	protected override void OnBeforeShow()
	{
		if (this.ViewModel.CurSelectBdData != null)
		{
			this.UpdateData(this.ViewModel.CurSelectBdData);
		}
	}

	// Token: 0x0601783F RID: 96319 RVA: 0x005FAC14 File Offset: 0x005F8E14
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.OnViewClose();
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(9));
	}

	// Token: 0x06017840 RID: 96320 RVA: 0x005FAC33 File Offset: 0x005F8E33
	private void OnClickBtnSure()
	{
		base.CloseMe(null);
	}

	// Token: 0x06017841 RID: 96321 RVA: 0x005FAC3C File Offset: 0x005F8E3C
	public void UpdateData(TrapDefenseBdData data)
	{
		this.BdData = data;
		UUITexture texture = base.GetTexture(3);
		base.SetTextureByPath(data.Config.Icon, texture, null, null);
		base.GetText(4).ShowTextNew(data.Config.Name);
		this.SetNewQualityMode(this.ViewModel.IsNewQualityMode);
		this.UpdateBdBuffQuality();
	}

	// Token: 0x06017842 RID: 96322 RVA: 0x005FACA2 File Offset: 0x005F8EA2
	public void SetNewQualityMode(bool isNew)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isNew);
	}

	// Token: 0x06017843 RID: 96323 RVA: 0x005FACB8 File Offset: 0x005F8EB8
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

	// Token: 0x06017844 RID: 96324 RVA: 0x005FAD31 File Offset: 0x005F8F31
	public int GetSelectGridIndex(List<TrapDefenseBdBuffData> list)
	{
		if (this.ViewModel.CurSelectBdBuffData != null)
		{
			return list.FindIndex((TrapDefenseBdBuffData item) => item.Id == this.ViewModel.CurSelectBdBuffData.Id);
		}
		return this.LayoutBdBuff.GetSelectedGridIndex();
	}

	// Token: 0x06017845 RID: 96325 RVA: 0x005FAD5E File Offset: 0x005F8F5E
	private TrapDefenseBdBuffItem CreateItemBdBuff()
	{
		return new TrapDefenseBdBuffItem
		{
			OnSelectBuffItemCallback = new Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem>(this.OnSelectBdBuffItem)
		};
	}

	// Token: 0x06017846 RID: 96326 RVA: 0x005FAD78 File Offset: 0x005F8F78
	private void OnSelectBdBuffItem(TrapDefenseBdBuffData data, TrapDefenseBdBuffItem _)
	{
		this.ViewModel.SetCurSelectBdBuffData(data);
		TrapDefenseBdBuff strengthenBeforeConfig = data.GetStrengthenBeforeConfig();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), strengthenBeforeConfig.Desc, strengthenBeforeConfig.DescArgs());
	}

	// Token: 0x06017847 RID: 96327 RVA: 0x005FADB8 File Offset: 0x005F8FB8
	private void OnBtnHelp()
	{
		int helpIdBdSum = TrapDefenseConfig.Instance.GetHelpIdBdSum();
		HelpController.Instance.OpenHelpById(helpIdBdSum);
	}

	// Token: 0x06017848 RID: 96328 RVA: 0x005FADDB File Offset: 0x005F8FDB
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AF86 RID: 44934
	public PopupCaptionItem PopupCaption;

	// Token: 0x0400AF87 RID: 44935
	public TrapDefenseBdData BdData;

	// Token: 0x0400AF88 RID: 44936
	public GenericLayout<TrapDefenseBdBuffItem, TrapDefenseBdBuffData> LayoutBdBuff;

	// Token: 0x0400AF89 RID: 44937
	public TrapDefenseBdQualityViewModel ViewModel = TrapDefenseModel.Instance.ViewModelBdQuality;

	// Token: 0x02009204 RID: 37380
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F3B6 RID: 193462
		public const int ItemBgYellowLight = 0;

		// Token: 0x0402F3B7 RID: 193463
		public const int ItemBgRedLight = 1;

		// Token: 0x0402F3B8 RID: 193464
		public const int ItemCaption = 2;

		// Token: 0x0402F3B9 RID: 193465
		public const int TextureIcon = 3;

		// Token: 0x0402F3BA RID: 193466
		public const int TextTitle = 4;

		// Token: 0x0402F3BB RID: 193467
		public const int ItemNewAddRoot = 5;

		// Token: 0x0402F3BC RID: 193468
		public const int TextNewAdd = 6;

		// Token: 0x0402F3BD RID: 193469
		public const int LayoutBdBuff = 7;

		// Token: 0x0402F3BE RID: 193470
		public const int ItemBdBuff = 8;

		// Token: 0x0402F3BF RID: 193471
		public const int TextDesc = 9;

		// Token: 0x0402F3C0 RID: 193472
		public const int BtnSure = 10;
	}
}
