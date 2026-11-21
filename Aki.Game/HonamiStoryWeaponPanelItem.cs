using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C8 RID: 5064
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponPanelItem : UiPanelBase, IGridProxy<EHonamiStoryWeaponType>
{
	// Token: 0x0600C8AD RID: 51373 RVA: 0x003BBD08 File Offset: 0x003B9F08
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C8AE RID: 51374 RVA: 0x003BBDB3 File Offset: 0x003B9FB3
	protected override void OnStart()
	{
		this.WeaponHorizontalLayout = new GenericLayout<HonamiStoryWeaponToggleItem, IHonamiStoryWeaponToggleItemData>(base.GetHorizontalLayout(0), new Func<HonamiStoryWeaponToggleItem>(this.CreateWeaponToggleItem), null, false, true);
	}

	// Token: 0x17001340 RID: 4928
	// (get) Token: 0x0600C8AF RID: 51375 RVA: 0x003BBDD6 File Offset: 0x003B9FD6
	// (set) Token: 0x0600C8B0 RID: 51376 RVA: 0x003BBDDE File Offset: 0x003B9FDE
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IScrollViewDelegate<IGridProxy<EHonamiStoryWeaponType>, EHonamiStoryWeaponType> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001341 RID: 4929
	// (get) Token: 0x0600C8B1 RID: 51377 RVA: 0x003BBDE7 File Offset: 0x003B9FE7
	// (set) Token: 0x0600C8B2 RID: 51378 RVA: 0x003BBDEF File Offset: 0x003B9FEF
	public int GridIndex { get; set; }

	// Token: 0x17001342 RID: 4930
	// (get) Token: 0x0600C8B3 RID: 51379 RVA: 0x003BBDF8 File Offset: 0x003B9FF8
	// (set) Token: 0x0600C8B4 RID: 51380 RVA: 0x003BBE00 File Offset: 0x003BA000
	public int DisplayIndex { get; set; }

	// Token: 0x0600C8B5 RID: 51381 RVA: 0x003BBE0C File Offset: 0x003BA00C
	public UniTask RefreshAsync(EHonamiStoryWeaponType data, bool isSelected, int gridIndex)
	{
		HonamiStoryWeaponPanelItem.<RefreshAsync>d__19 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<HonamiStoryWeaponPanelItem.<RefreshAsync>d__19>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C8B6 RID: 51382 RVA: 0x003BBE57 File Offset: 0x003BA057
	public void BindWeaponToggleClick(Action<HonamiStoryWeaponToggleItem> callback)
	{
		this.WeaponToggleCallBack = callback;
	}

	// Token: 0x0600C8B7 RID: 51383 RVA: 0x003BBE60 File Offset: 0x003BA060
	public IReadOnlyList<HonamiStoryWeaponToggleItem> GetWeaponToggleList()
	{
		return this.WeaponToggleList;
	}

	// Token: 0x0600C8B8 RID: 51384 RVA: 0x003BBE68 File Offset: 0x003BA068
	private HonamiStoryWeaponToggleItem CreateWeaponToggleItem()
	{
		HonamiStoryWeaponToggleItem honamiStoryWeaponToggleItem = new HonamiStoryWeaponToggleItem();
		if (this.WeaponToggleCallBack != null)
		{
			honamiStoryWeaponToggleItem.BindWeaponToggleClick(this.WeaponToggleCallBack);
		}
		this.WeaponToggleList.Add(honamiStoryWeaponToggleItem);
		return honamiStoryWeaponToggleItem;
	}

	// Token: 0x0600C8B9 RID: 51385 RVA: 0x003BBE9C File Offset: 0x003BA09C
	public void Clear()
	{
	}

	// Token: 0x0600C8BA RID: 51386 RVA: 0x003BBE9E File Offset: 0x003BA09E
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600C8BB RID: 51387 RVA: 0x003BBEA0 File Offset: 0x003BA0A0
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600C8BC RID: 51388 RVA: 0x003BBEA2 File Offset: 0x003BA0A2
	public object GetKey(EHonamiStoryWeaponType data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0400720B RID: 29195
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EHonamiStoryWeaponType, string> BARSPRITE_MAP = new Dictionary<EHonamiStoryWeaponType, string>
	{
		{
			EHonamiStoryWeaponType.Attack,
			"SP_Offensive"
		},
		{
			EHonamiStoryWeaponType.Explore,
			"SP_Exploration"
		},
		{
			EHonamiStoryWeaponType.Support,
			"SP_Survivability"
		}
	};

	// Token: 0x0400720C RID: 29196
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<HonamiStoryWeaponToggleItem> WeaponToggleCallBack;

	// Token: 0x0400720D RID: 29197
	private GenericLayout<HonamiStoryWeaponToggleItem, IHonamiStoryWeaponToggleItemData> WeaponHorizontalLayout;

	// Token: 0x0400720E RID: 29198
	public readonly List<HonamiStoryWeaponToggleItem> WeaponToggleList = new List<HonamiStoryWeaponToggleItem>();

	// Token: 0x02007694 RID: 30356
	[NullableContext(0)]
	private enum EHonamiStoryWeaponPanelItemComponent
	{
		// Token: 0x04026800 RID: 157696
		WeaponHorizontalLayout,
		// Token: 0x04026801 RID: 157697
		WeaponToggleItem,
		// Token: 0x04026802 RID: 157698
		TypeTitleText,
		// Token: 0x04026803 RID: 157699
		TypeBgSprite
	}
}
