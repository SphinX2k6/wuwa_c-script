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

// Token: 0x02001A61 RID: 6753
[NullableContext(1)]
[Nullable(0)]
public class PhotoSubTabPanel : UiPanelBase
{
	// Token: 0x06010ACB RID: 68299 RVA: 0x004E0B0C File Offset: 0x004DED0C
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

	// Token: 0x06010ACC RID: 68300 RVA: 0x004E0B7C File Offset: 0x004DED7C
	protected override void OnStart()
	{
		this.TabLayout = new GenericLayout<PhotoSettingTabItem, PhotoSubTab>(base.GetVerticalLayout(2), new Func<PhotoSettingTabItem>(this.CreateTabItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.RefreshDecoration();
	}

	// Token: 0x06010ACD RID: 68301 RVA: 0x004E0BB8 File Offset: 0x004DEDB8
	private void RefreshDecoration()
	{
		bool flag = Info.Instance.IsInTouch();
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

	// Token: 0x06010ACE RID: 68302 RVA: 0x004E0BF8 File Offset: 0x004DEDF8
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

	// Token: 0x06010ACF RID: 68303 RVA: 0x004E0C4B File Offset: 0x004DEE4B
	public void SelectByKey(object key, bool fireEvent = false)
	{
		GenericLayout<PhotoSettingTabItem, PhotoSubTab> tabLayout = this.TabLayout;
		if (tabLayout == null)
		{
			return;
		}
		tabLayout.SelectGridProxyByKey(key, fireEvent);
	}

	// Token: 0x06010AD0 RID: 68304 RVA: 0x004E0C5F File Offset: 0x004DEE5F
	private PhotoSettingTabItem CreateTabItem()
	{
		return new PhotoSettingTabItem
		{
			OnSubTabClick = new Action<PhotoSubTab>(this.OnSubTabItemClick)
		};
	}

	// Token: 0x06010AD1 RID: 68305 RVA: 0x004E0C78 File Offset: 0x004DEE78
	private void OnSubTabItemClick(PhotoSubTab data)
	{
		this.OnSubTabClick(data);
	}

	// Token: 0x0400933B RID: 37691
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x0400933C RID: 37692
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PhotoSettingTabItem, PhotoSubTab> TabLayout;

	// Token: 0x02007CEE RID: 31982
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028754 RID: 165716
		SpriteDecoTop,
		// Token: 0x04028755 RID: 165717
		SpriteDecoBottom,
		// Token: 0x04028756 RID: 165718
		LayoutItemMenu,
		// Token: 0x04028757 RID: 165719
		ItemTabTemplate
	}
}
