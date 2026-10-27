using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001159 RID: 4441
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MutexGroupItem : GridProxyAbstract<IBabelTowerMutexGroupData>
{
	// Token: 0x060074EE RID: 29934 RVA: 0x0018071C File Offset: 0x0017E91C
	[NullableContext(1)]
	public void SetParentItem(BabelTowerSvBuffItem parent)
	{
		this.ParentItem = parent;
	}

	// Token: 0x060074EF RID: 29935 RVA: 0x00180725 File Offset: 0x0017E925
	public bool IsQuickSelectMode()
	{
		BabelTowerSvBuffItem parentItem = this.ParentItem;
		return parentItem != null && parentItem.IsQuickSelectMode();
	}

	// Token: 0x060074F0 RID: 29936 RVA: 0x00180738 File Offset: 0x0017E938
	public bool GetIsNecessary()
	{
		return this.IsNecessary;
	}

	// Token: 0x060074F1 RID: 29937 RVA: 0x00180740 File Offset: 0x0017E940
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

	// Token: 0x060074F2 RID: 29938 RVA: 0x001807AC File Offset: 0x0017E9AC
	protected override UniTask OnBeforeStartAsync()
	{
		MutexGroupItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MutexGroupItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060074F3 RID: 29939 RVA: 0x001807F0 File Offset: 0x0017E9F0
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

	// Token: 0x060074F4 RID: 29940 RVA: 0x00180854 File Offset: 0x0017EA54
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

	// Token: 0x060074F5 RID: 29941 RVA: 0x00180964 File Offset: 0x0017EB64
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

	// Token: 0x060074F6 RID: 29942 RVA: 0x001809FC File Offset: 0x0017EBFC
	[NullableContext(1)]
	private SvBuffGridItem CreateBuffItem()
	{
		SvBuffGridItem svBuffGridItem = new SvBuffGridItem();
		svBuffGridItem.SetParentItem(this);
		svBuffGridItem.OnClickCallBack = new Action<int, UUIExtendToggle>(this.OnBuffItemClick);
		return svBuffGridItem;
	}

	// Token: 0x060074F7 RID: 29943 RVA: 0x00180A1C File Offset: 0x0017EC1C
	private void OnBuffItemClick(int deTermId, UUIExtendToggle toggle)
	{
		this.HandleToggle(deTermId, toggle);
	}

	// Token: 0x060074F8 RID: 29944 RVA: 0x00180A28 File Offset: 0x0017EC28
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

	// Token: 0x040035C4 RID: 13764
	public Action<int, UUIExtendToggle> OnBuffClick;

	// Token: 0x040035C5 RID: 13765
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SvBuffGridItem, int> BuffLayout;

	// Token: 0x040035C6 RID: 13766
	private bool IsNecessary;

	// Token: 0x040035C7 RID: 13767
	private int CurrentDeTermId;

	// Token: 0x040035C8 RID: 13768
	private bool IsHandlingToggle;

	// Token: 0x040035C9 RID: 13769
	private BabelTowerSvBuffItem ParentItem;

	// Token: 0x0200771A RID: 30490
	[NullableContext(0)]
	private class EBuffItemSubComponent
	{
		// Token: 0x0402749F RID: 160927
		public const int GridLayout = 0;

		// Token: 0x040274A0 RID: 160928
		public const int ItemGroup = 1;
	}
}
