using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002576 RID: 9590
[NullableContext(1)]
[Nullable(0)]
public class PhotoSubTabPanel : UiPanelBase
{
	// Token: 0x060135E8 RID: 79336 RVA: 0x004D1EA4 File Offset: 0x004D00A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060135E9 RID: 79337 RVA: 0x004D1F14 File Offset: 0x004D0114
	protected override void OnStart()
	{
		this.TabLayout = new GenericLayout<PhotoSettingTabItem, PhotoSubTab>(base.GetVerticalLayout(2), new Func<PhotoSettingTabItem>(this.CreateTabItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.RefreshDecoration();
	}

	// Token: 0x060135EA RID: 79338 RVA: 0x004D1F50 File Offset: 0x004D0150
	private void RefreshDecoration()
	{
		bool flag = Info.Instance.IsMobilePlatform();
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(flag);
		}
		UUISprite sprite2 = base.GetSprite(1);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(!flag);
	}

	// Token: 0x060135EB RID: 79339 RVA: 0x004D1F90 File Offset: 0x004D0190
	public UniTask RefreshByDataAsync(IReadOnlyList<PhotoSubTab> dataList, bool playGridAnim = false)
	{
		PhotoSubTabPanel.<RefreshByDataAsync>d__6 <RefreshByDataAsync>d__;
		<RefreshByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByDataAsync>d__.<>4__this = this;
		<RefreshByDataAsync>d__.dataList = dataList;
		<RefreshByDataAsync>d__.playGridAnim = playGridAnim;
		<RefreshByDataAsync>d__.<>1__state = -1;
		<RefreshByDataAsync>d__.<>t__builder.Start<PhotoSubTabPanel.<RefreshByDataAsync>d__6>(ref <RefreshByDataAsync>d__);
		return <RefreshByDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060135EC RID: 79340 RVA: 0x004D1FE3 File Offset: 0x004D01E3
	public void SelectByKey(object key, bool fireEvent = false)
	{
		GenericLayout<PhotoSettingTabItem, PhotoSubTab> tabLayout = this.TabLayout;
		if (tabLayout == null)
		{
			return;
		}
		tabLayout.SelectGridProxyByKey(key, fireEvent);
	}

	// Token: 0x060135ED RID: 79341 RVA: 0x004D1FF7 File Offset: 0x004D01F7
	private PhotoSettingTabItem CreateTabItem()
	{
		return new PhotoSettingTabItem
		{
			OnSubTabClick = new Action<PhotoSubTab>(this.OnSubTabItemClick)
		};
	}

	// Token: 0x060135EE RID: 79342 RVA: 0x004D2010 File Offset: 0x004D0210
	private void OnSubTabItemClick(PhotoSubTab data)
	{
		this.OnSubTabClick(data);
	}

	// Token: 0x040091E2 RID: 37346
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x040091E3 RID: 37347
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PhotoSettingTabItem, PhotoSubTab> TabLayout;

	// Token: 0x02008B68 RID: 35688
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D447 RID: 185415
		SpriteDecoTop,
		// Token: 0x0402D448 RID: 185416
		SpriteDecoBottom,
		// Token: 0x0402D449 RID: 185417
		LayoutItemMenu,
		// Token: 0x0402D44A RID: 185418
		ItemTabTemplate
	}
}
