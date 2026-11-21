using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200060D RID: 1549
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MutexGroupItem : GridProxyAbstract<IBabelTowerMutexGroupData>
{
	// Token: 0x06004885 RID: 18565 RVA: 0x0018924C File Offset: 0x0018744C
	[NullableContext(1)]
	public void SetParentItem(BabelTowerSvBuffItem parent)
	{
		this.ParentItem = parent;
	}

	// Token: 0x06004886 RID: 18566 RVA: 0x00189255 File Offset: 0x00187455
	public bool IsQuickSelectMode()
	{
		BabelTowerSvBuffItem parentItem = this.ParentItem;
		return parentItem != null && parentItem.IsQuickSelectMode();
	}

	// Token: 0x06004887 RID: 18567 RVA: 0x00189268 File Offset: 0x00187468
	public bool GetIsNecessary()
	{
		return this.IsNecessary;
	}

	// Token: 0x06004888 RID: 18568 RVA: 0x00189270 File Offset: 0x00187470
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004889 RID: 18569 RVA: 0x001892DC File Offset: 0x001874DC
	protected override UniTask OnBeforeStartAsync()
	{
		MutexGroupItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MutexGroupItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600488A RID: 18570 RVA: 0x00189320 File Offset: 0x00187520
	[NullableContext(1)]
	public override void Refresh(IBabelTowerMutexGroupData data, bool isSelected, int gridIndex)
	{
		this.IsNecessary = data.IsNecessary.GetValueOrDefault();
		List<int> deTermList = data.DeTermList;
		GenericLayout<SvBuffGridItem, int> buffLayout = this.BuffLayout;
		if (buffLayout == null)
		{
			return;
		}
		Func<bool> <>9__2;
		Func<bool> <>9__3;
		buffLayout.RefreshByData(deTermList, delegate
		{
			List<SvBuffGridItem> layoutItemList = this.BuffLayout.GetLayoutItemList();
			foreach (SvBuffGridItem svBuffGridItem in layoutItemList)
			{
				svBuffGridItem.SuppressToggleCallback(true);
			}
			foreach (SvBuffGridItem svBuffGridItem2 in layoutItemList)
			{
				IBabelTowerSelectInfo valueOrDefault = BabelTowerModel.Instance.DeTermSelectInfo.GetValueOrDefault(svBuffGridItem2.BuffId);
				if (valueOrDefault != null && valueOrDefault.State == EBabelTowerDeTermState.Lock)
				{
					svBuffGridItem2.SetToggleState(EToggleState.ETT_UnDetermined);
					svBuffGridItem2.SetCanClickCallBack(() => true);
				}
				else if ((valueOrDefault != null && valueOrDefault.State == EBabelTowerDeTermState.Select) || (valueOrDefault != null && valueOrDefault.State == EBabelTowerDeTermState.StaticSelect))
				{
					svBuffGridItem2.SetToggleState(EToggleState.ETT_Checked);
					SvBuffGridItem svBuffGridItem3 = svBuffGridItem2;
					Func<bool> canClickCallBack;
					if ((canClickCallBack = <>9__2) == null)
					{
						canClickCallBack = (<>9__2 = delegate()
						{
							if (this.IsNecessary)
							{
								ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerNecessaryDeTerm", Array.Empty<object>());
								return false;
							}
							return true;
						});
					}
					svBuffGridItem3.SetCanClickCallBack(canClickCallBack);
				}
				else
				{
					svBuffGridItem2.SetToggleState(EToggleState.ETT_UnChecked);
					SvBuffGridItem svBuffGridItem4 = svBuffGridItem2;
					Func<bool> canClickCallBack2;
					if ((canClickCallBack2 = <>9__3) == null)
					{
						canClickCallBack2 = (<>9__3 = delegate()
						{
							if (this.IsNecessary)
							{
								ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerNecessaryDeTerm", Array.Empty<object>());
								return false;
							}
							return true;
						});
					}
					svBuffGridItem4.SetCanClickCallBack(canClickCallBack2);
				}
			}
			foreach (SvBuffGridItem svBuffGridItem5 in layoutItemList)
			{
				svBuffGridItem5.SuppressToggleCallback(false);
			}
			this.CurrentDeTermId = data.CurrentDeTermId.GetValueOrDefault();
			this.RefreshItemColor();
		}, false);
	}

	// Token: 0x0600488B RID: 18571 RVA: 0x00189384 File Offset: 0x00187584
	public void HandleToggle(int deTermId, UUIExtendToggle toggle)
	{
		if (this.IsNecessary)
		{
			return;
		}
		if (this.IsHandlingToggle)
		{
			return;
		}
		this.IsHandlingToggle = true;
		int currentDeTermId = this.CurrentDeTermId;
		if (deTermId != 0)
		{
			BabelTowerSelectInfo babelTowerSelectInfo = new BabelTowerSelectInfo();
			babelTowerSelectInfo.State = EBabelTowerDeTermState.Normal;
			BabelTowerModel instance = BabelTowerModel.Instance;
			int deTermSelectIndex = instance.DeTermSelectIndex;
			instance.DeTermSelectIndex = deTermSelectIndex + 1;
			babelTowerSelectInfo.SelectIndex = deTermSelectIndex;
			BabelTowerSelectInfo value = babelTowerSelectInfo;
			BabelTowerModel.Instance.DeTermSelectInfo[currentDeTermId] = value;
			BabelTowerSelectInfo babelTowerSelectInfo2 = new BabelTowerSelectInfo();
			babelTowerSelectInfo2.State = EBabelTowerDeTermState.Select;
			BabelTowerModel instance2 = BabelTowerModel.Instance;
			deTermSelectIndex = instance2.DeTermSelectIndex;
			instance2.DeTermSelectIndex = deTermSelectIndex + 1;
			babelTowerSelectInfo2.SelectIndex = deTermSelectIndex;
			BabelTowerSelectInfo value2 = babelTowerSelectInfo2;
			BabelTowerModel.Instance.DeTermSelectInfo[deTermId] = value2;
		}
		else
		{
			BabelTowerSelectInfo babelTowerSelectInfo3 = new BabelTowerSelectInfo();
			babelTowerSelectInfo3.State = EBabelTowerDeTermState.Normal;
			BabelTowerModel instance3 = BabelTowerModel.Instance;
			int deTermSelectIndex = instance3.DeTermSelectIndex;
			instance3.DeTermSelectIndex = deTermSelectIndex + 1;
			babelTowerSelectInfo3.SelectIndex = deTermSelectIndex;
			BabelTowerSelectInfo value3 = babelTowerSelectInfo3;
			BabelTowerModel.Instance.DeTermSelectInfo[currentDeTermId] = value3;
		}
		this.CurrentDeTermId = deTermId;
		this.IsHandlingToggle = false;
		EventSystem.Instance.Emit(EEventName.BabelTowerRefreshLevelInfo);
		BabelTowerSvBuffItem parentItem = this.ParentItem;
		if (parentItem == null)
		{
			return;
		}
		parentItem.NotifyDeTermToggle(deTermId);
	}

	// Token: 0x0600488C RID: 18572 RVA: 0x00189494 File Offset: 0x00187694
	private void RefreshItemColor()
	{
		GenericLayout<SvBuffGridItem, int> buffLayout = this.BuffLayout;
		List<SvBuffGridItem> list = (buffLayout != null) ? buffLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return;
		}
		foreach (SvBuffGridItem svBuffGridItem in list)
		{
			IBabelTowerSelectInfo valueOrDefault = BabelTowerModel.Instance.DeTermSelectInfo.GetValueOrDefault(svBuffGridItem.BuffId);
			bool flag = valueOrDefault != null && valueOrDefault.State == EBabelTowerDeTermState.Normal;
			svBuffGridItem.UseChangeColor(flag && this.CurrentDeTermId != 0);
		}
	}

	// Token: 0x0600488D RID: 18573 RVA: 0x0018952C File Offset: 0x0018772C
	[NullableContext(1)]
	private SvBuffGridItem CreateBuffItem()
	{
		SvBuffGridItem svBuffGridItem = new SvBuffGridItem();
		svBuffGridItem.SetParentItem(this);
		svBuffGridItem.OnClickCallBack = new Action<int, UUIExtendToggle>(this.OnBuffItemClick);
		return svBuffGridItem;
	}

	// Token: 0x0600488E RID: 18574 RVA: 0x0018954C File Offset: 0x0018774C
	private void OnBuffItemClick(int deTermId, UUIExtendToggle toggle)
	{
		this.HandleToggle(deTermId, toggle);
	}

	// Token: 0x0600488F RID: 18575 RVA: 0x00189558 File Offset: 0x00187758
	public SvBuffGridItem GetBuffItemById(int deTermId)
	{
		GenericLayout<SvBuffGridItem, int> buffLayout = this.BuffLayout;
		List<SvBuffGridItem> list = (buffLayout != null) ? buffLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return null;
		}
		foreach (SvBuffGridItem svBuffGridItem in list)
		{
			if (svBuffGridItem.BuffId == deTermId)
			{
				return svBuffGridItem;
			}
		}
		return null;
	}

	// Token: 0x0400365D RID: 13917
	public Action<int, UUIExtendToggle> OnBuffClick;

	// Token: 0x0400365E RID: 13918
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SvBuffGridItem, int> BuffLayout;

	// Token: 0x0400365F RID: 13919
	private bool IsNecessary;

	// Token: 0x04003660 RID: 13920
	private int CurrentDeTermId;

	// Token: 0x04003661 RID: 13921
	private bool IsHandlingToggle;

	// Token: 0x04003662 RID: 13922
	private BabelTowerSvBuffItem ParentItem;

	// Token: 0x020068A8 RID: 26792
	[NullableContext(0)]
	private class EBuffItemSubComponent
	{
		// Token: 0x040227DE RID: 141278
		public const int GridLayout = 0;

		// Token: 0x040227DF RID: 141279
		public const int ItemGroup = 1;
	}
}
