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

// Token: 0x02001F06 RID: 7942
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponPanelItem : UiPanelBase, IGridProxy<EHonamiStoryWeaponType>
{
	// Token: 0x0600F48E RID: 62606 RVA: 0x003B0214 File Offset: 0x003AE414
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

	// Token: 0x0600F48F RID: 62607 RVA: 0x003B02BF File Offset: 0x003AE4BF
	protected override void OnStart()
	{
		this.WeaponHorizontalLayout = new GenericLayout<HonamiStoryWeaponToggleItem, IHonamiStoryWeaponToggleItemData>(base.GetHorizontalLayout(0), new Func<HonamiStoryWeaponToggleItem>(this.CreateWeaponToggleItem), null, false, true);
	}

	// Token: 0x17001316 RID: 4886
	// (get) Token: 0x0600F490 RID: 62608 RVA: 0x003B02E2 File Offset: 0x003AE4E2
	// (set) Token: 0x0600F491 RID: 62609 RVA: 0x003B02EA File Offset: 0x003AE4EA
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

	// Token: 0x17001317 RID: 4887
	// (get) Token: 0x0600F492 RID: 62610 RVA: 0x003B02F3 File Offset: 0x003AE4F3
	// (set) Token: 0x0600F493 RID: 62611 RVA: 0x003B02FB File Offset: 0x003AE4FB
	public int GridIndex { get; set; }

	// Token: 0x17001318 RID: 4888
	// (get) Token: 0x0600F494 RID: 62612 RVA: 0x003B0304 File Offset: 0x003AE504
	// (set) Token: 0x0600F495 RID: 62613 RVA: 0x003B030C File Offset: 0x003AE50C
	public int DisplayIndex { get; set; }

	// Token: 0x0600F496 RID: 62614 RVA: 0x003B0318 File Offset: 0x003AE518
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

	// Token: 0x0600F497 RID: 62615 RVA: 0x003B0363 File Offset: 0x003AE563
	public void BindWeaponToggleClick(Action<HonamiStoryWeaponToggleItem> callback)
	{
		this.WeaponToggleCallBack = callback;
	}

	// Token: 0x0600F498 RID: 62616 RVA: 0x003B036C File Offset: 0x003AE56C
	public IReadOnlyList<HonamiStoryWeaponToggleItem> GetWeaponToggleList()
	{
		return this.WeaponToggleList;
	}

	// Token: 0x0600F499 RID: 62617 RVA: 0x003B0374 File Offset: 0x003AE574
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

	// Token: 0x0600F49A RID: 62618 RVA: 0x003B03A8 File Offset: 0x003AE5A8
	public void Clear()
	{
	}

	// Token: 0x0600F49B RID: 62619 RVA: 0x003B03AA File Offset: 0x003AE5AA
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600F49C RID: 62620 RVA: 0x003B03AC File Offset: 0x003AE5AC
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600F49D RID: 62621 RVA: 0x003B03AE File Offset: 0x003AE5AE
	public object GetKey(EHonamiStoryWeaponType data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0400712A RID: 28970
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

	// Token: 0x0400712B RID: 28971
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<HonamiStoryWeaponToggleItem> WeaponToggleCallBack;

	// Token: 0x0400712C RID: 28972
	private GenericLayout<HonamiStoryWeaponToggleItem, IHonamiStoryWeaponToggleItemData> WeaponHorizontalLayout;

	// Token: 0x0400712D RID: 28973
	public readonly List<HonamiStoryWeaponToggleItem> WeaponToggleList = new List<HonamiStoryWeaponToggleItem>();

	// Token: 0x0200850F RID: 34063
	[NullableContext(0)]
	private enum EHonamiStoryWeaponPanelItemComponent
	{
		// Token: 0x0402B4DC RID: 177372
		WeaponHorizontalLayout,
		// Token: 0x0402B4DD RID: 177373
		WeaponToggleItem,
		// Token: 0x0402B4DE RID: 177374
		TypeTitleText,
		// Token: 0x0402B4DF RID: 177375
		TypeBgSprite
	}
}
