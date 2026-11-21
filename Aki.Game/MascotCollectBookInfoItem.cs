using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013CF RID: 5071
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MascotCollectBookInfoItem : GridProxyAbstract<IMascotCollectInfoData>
{
	// Token: 0x0600C8F3 RID: 51443 RVA: 0x003BCCD4 File Offset: 0x003BAED4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600C8F4 RID: 51444 RVA: 0x003BCD44 File Offset: 0x003BAF44
	protected override void OnStart()
	{
		this.MascotToggleLayout = new GenericLayout<MascotCollectBookMascotToggle, HonamiStoryMascotData>(base.GetHorizontalLayout(1), new Func<MascotCollectBookMascotToggle>(this.CreateMascotToggleItem), null, false, true);
	}

	// Token: 0x0600C8F5 RID: 51445 RVA: 0x003BCD68 File Offset: 0x003BAF68
	private MascotCollectBookMascotToggle CreateMascotToggleItem()
	{
		MascotCollectBookMascotToggle mascotCollectBookMascotToggle = new MascotCollectBookMascotToggle();
		mascotCollectBookMascotToggle.BindMascotToggleClick(this.OnMascotToggleClick);
		this.MascotToggleList.Add(mascotCollectBookMascotToggle);
		return mascotCollectBookMascotToggle;
	}

	// Token: 0x0600C8F6 RID: 51446 RVA: 0x003BCD94 File Offset: 0x003BAF94
	public override void Refresh(IMascotCollectInfoData infoData, bool isSelected, int gridIndex)
	{
		this.InfoData = infoData;
		this.RefreshItem();
	}

	// Token: 0x0600C8F7 RID: 51447 RVA: 0x003BCDA4 File Offset: 0x003BAFA4
	private void RefreshItem()
	{
		HonamiStoryAreaData areaData = this.InfoData.AreaData;
		bool isAreaUnlock = areaData.IsAreaUnlock;
		base.GetItem(3).SetUIActive(!isAreaUnlock);
		this.MascotToggleLayout.GetRootUiItem().SetUIActive(isAreaUnlock);
		if (isAreaUnlock)
		{
			base.GetText(0).ShowTextNew(areaData.Name);
			List<HonamiStoryMascotData> mascotDataList = this.InfoData.MascotDataList;
			base.GetItem(3).SetActive(mascotDataList.Count == 0, false);
			this.MascotToggleLayout.RefreshByData(mascotDataList, null, false);
			return;
		}
		base.GetText(0).SetText("???", true);
	}

	// Token: 0x0600C8F8 RID: 51448 RVA: 0x003BCE3D File Offset: 0x003BB03D
	public IReadOnlyList<MascotCollectBookMascotToggle> GetMascotToggleList()
	{
		return this.MascotToggleList;
	}

	// Token: 0x0600C8F9 RID: 51449 RVA: 0x003BCE45 File Offset: 0x003BB045
	public void BindMascotToggleClick(Action<MascotCollectBookMascotToggle> callback)
	{
		this.OnMascotToggleClick = callback;
	}

	// Token: 0x04007222 RID: 29218
	private IMascotCollectInfoData InfoData;

	// Token: 0x04007223 RID: 29219
	private GenericLayout<MascotCollectBookMascotToggle, HonamiStoryMascotData> MascotToggleLayout;

	// Token: 0x04007224 RID: 29220
	private readonly List<MascotCollectBookMascotToggle> MascotToggleList = new List<MascotCollectBookMascotToggle>();

	// Token: 0x04007225 RID: 29221
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MascotCollectBookMascotToggle> OnMascotToggleClick;

	// Token: 0x0200769F RID: 30367
	[NullableContext(0)]
	private enum EMascotCollectBookInfoItemComponent
	{
		// Token: 0x04026837 RID: 157751
		TitleText,
		// Token: 0x04026838 RID: 157752
		MascotToggleLayout,
		// Token: 0x04026839 RID: 157753
		MascotToggleItem,
		// Token: 0x0402683A RID: 157754
		EmptyPanel
	}
}
