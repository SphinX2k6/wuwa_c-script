using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F0D RID: 7949
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MascotCollectBookInfoItem : GridProxyAbstract<IMascotCollectInfoData>
{
	// Token: 0x0600F4D4 RID: 62676 RVA: 0x003B11E8 File Offset: 0x003AF3E8
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

	// Token: 0x0600F4D5 RID: 62677 RVA: 0x003B1258 File Offset: 0x003AF458
	protected override void OnStart()
	{
		this.MascotToggleLayout = new GenericLayout<MascotCollectBookMascotToggle, HonamiStoryMascotData>(base.GetHorizontalLayout(1), new Func<MascotCollectBookMascotToggle>(this.CreateMascotToggleItem), null, false, true);
	}

	// Token: 0x0600F4D6 RID: 62678 RVA: 0x003B127C File Offset: 0x003AF47C
	private MascotCollectBookMascotToggle CreateMascotToggleItem()
	{
		MascotCollectBookMascotToggle mascotCollectBookMascotToggle = new MascotCollectBookMascotToggle();
		mascotCollectBookMascotToggle.BindMascotToggleClick(this.OnMascotToggleClick);
		this.MascotToggleList.Add(mascotCollectBookMascotToggle);
		return mascotCollectBookMascotToggle;
	}

	// Token: 0x0600F4D7 RID: 62679 RVA: 0x003B12A8 File Offset: 0x003AF4A8
	public override void Refresh(IMascotCollectInfoData infoData, bool isSelected, int gridIndex)
	{
		this.InfoData = infoData;
		this.RefreshItem();
	}

	// Token: 0x0600F4D8 RID: 62680 RVA: 0x003B12B8 File Offset: 0x003AF4B8
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

	// Token: 0x0600F4D9 RID: 62681 RVA: 0x003B1351 File Offset: 0x003AF551
	public IReadOnlyList<MascotCollectBookMascotToggle> GetMascotToggleList()
	{
		return this.MascotToggleList;
	}

	// Token: 0x0600F4DA RID: 62682 RVA: 0x003B1359 File Offset: 0x003AF559
	public void BindMascotToggleClick(Action<MascotCollectBookMascotToggle> callback)
	{
		this.OnMascotToggleClick = callback;
	}

	// Token: 0x04007141 RID: 28993
	private IMascotCollectInfoData InfoData;

	// Token: 0x04007142 RID: 28994
	private GenericLayout<MascotCollectBookMascotToggle, HonamiStoryMascotData> MascotToggleLayout;

	// Token: 0x04007143 RID: 28995
	private readonly List<MascotCollectBookMascotToggle> MascotToggleList = new List<MascotCollectBookMascotToggle>();

	// Token: 0x04007144 RID: 28996
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MascotCollectBookMascotToggle> OnMascotToggleClick;

	// Token: 0x0200851A RID: 34074
	[NullableContext(0)]
	private enum EMascotCollectBookInfoItemComponent
	{
		// Token: 0x0402B513 RID: 177427
		TitleText,
		// Token: 0x0402B514 RID: 177428
		MascotToggleLayout,
		// Token: 0x0402B515 RID: 177429
		MascotToggleItem,
		// Token: 0x0402B516 RID: 177430
		EmptyPanel
	}
}
