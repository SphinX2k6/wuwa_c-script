using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B8C RID: 7052
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchDungeonItem : GridProxyAbstract<FloroRanchDungeonData>
{
	// Token: 0x0600D1F2 RID: 53746 RVA: 0x003023EC File Offset: 0x003005EC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIExtendToggleSpriteTransition));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D1F3 RID: 53747 RVA: 0x003025BE File Offset: 0x003007BE
	protected override void OnStart()
	{
		this.SubDungeonLayout = new GenericLayout<FloroRanchSubDungeonItem, FloroRanchSubDungeonData>(base.GetHorizontalLayout(2), new Func<FloroRanchSubDungeonItem>(this.CreateSubDungeonItem), null, false, true);
	}

	// Token: 0x0600D1F4 RID: 53748 RVA: 0x003025E1 File Offset: 0x003007E1
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x0600D1F5 RID: 53749 RVA: 0x003025FF File Offset: 0x003007FF
	public override void Refresh(FloroRanchDungeonData data, bool isSelected, int gridIndex)
	{
		this.RefreshItem(data);
	}

	// Token: 0x0600D1F6 RID: 53750 RVA: 0x00302608 File Offset: 0x00300808
	private void RefreshItem(FloroRanchDungeonData data)
	{
		this.Data = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.GetDungeonName(), Array.Empty<object>());
		List<FloroRanchSubDungeonData> subDungeonData = data.GetSubDungeonData();
		this.SubDungeonLayout.RefreshByData(subDungeonData, null, false);
		if (!this.Data.IsUnLock)
		{
			this.AddTimer();
		}
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetUIActive(!data.IsUnLock);
		}
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
		if (horizontalLayout != null)
		{
			horizontalLayout.RootUIComp.Get().SetUIActive(data.IsUnLock);
		}
		UUISprite sprite = base.GetSprite(7);
		if (sprite != null)
		{
			sprite.SetUIActive(!data.IsUnLock && !data.IsDifficulty);
		}
		UUISprite sprite2 = base.GetSprite(8);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(!data.IsUnLock && data.IsDifficulty);
		}
		UUISprite sprite3 = base.GetSprite(5);
		if (sprite3 != null)
		{
			sprite3.SetUIActive(data.IsDifficulty);
		}
		UUISprite numSprite = base.GetSprite(6);
		this.SetSpriteByPath(data.RomeNumIcon, numSprite, false, null, delegate(bool _)
		{
			UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = this.GetUiExtendToggleSpriteTransition(10);
			if (data.IsDifficulty)
			{
				FColor color = FColor.FromHex("C8564BFF");
				FExtendToggleSpriteTransitionState transitionState = uiExtendToggleSpriteTransition.TransitionState;
				transitionState.UnCheckedHoverState.Color = color;
				transitionState.UnCheckedPressedState.Color = color;
				transitionState.UnCheckedUnHoverState.Color = color;
			}
			uiExtendToggleSpriteTransition.SetAllStateSprite(numSprite.GetSprite());
		});
		UUISprite numSprite2 = numSprite;
		if (numSprite2 != null)
		{
			numSprite2.SetUIActive(data.IsUnLock);
		}
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.HasRedDot);
	}

	// Token: 0x0600D1F7 RID: 53751 RVA: 0x003027BA File Offset: 0x003009BA
	private void UpdateUnlock()
	{
		if (this.Data.IsUnLock)
		{
			this.RefreshItem(this.Data);
		}
	}

	// Token: 0x0600D1F8 RID: 53752 RVA: 0x003027D5 File Offset: 0x003009D5
	private void AddTimer()
	{
		this.RemoveTimer();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.UpdateUnlock();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600D1F9 RID: 53753 RVA: 0x00302806 File Offset: 0x00300A06
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600D1FA RID: 53754 RVA: 0x00302828 File Offset: 0x00300A28
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x0600D1FB RID: 53755 RVA: 0x00302846 File Offset: 0x00300A46
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimer();
	}

	// Token: 0x0600D1FC RID: 53756 RVA: 0x00302850 File Offset: 0x00300A50
	private void OnRefreshRedDot(int activityId)
	{
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		if (activityData == null || activityData.Id != activityId)
		{
			return;
		}
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.Data.HasRedDot);
	}

	// Token: 0x0600D1FD RID: 53757 RVA: 0x00302894 File Offset: 0x00300A94
	private void OnClickToggle(EToggleState _)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(this.Data, this.Data.GetLatestSubDungeonData());
		}
	}

	// Token: 0x0600D1FE RID: 53758 RVA: 0x003028BC File Offset: 0x00300ABC
	public void SetToggleCallBack(Action<FloroRanchDungeonData> callBack)
	{
		this.OnToggleCallBack = delegate(FloroRanchDungeonData dungeonData, FloroRanchSubDungeonData subDungeonData)
		{
			callBack(dungeonData);
		};
	}

	// Token: 0x0600D1FF RID: 53759 RVA: 0x003028E8 File Offset: 0x00300AE8
	private FloroRanchSubDungeonItem CreateSubDungeonItem()
	{
		return new FloroRanchSubDungeonItem();
	}

	// Token: 0x0600D200 RID: 53760 RVA: 0x003028EF File Offset: 0x00300AEF
	public override object GetKey(FloroRanchDungeonData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600D201 RID: 53761 RVA: 0x003028FC File Offset: 0x00300AFC
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600D202 RID: 53762 RVA: 0x0030290E File Offset: 0x00300B0E
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04006042 RID: 24642
	private FloroRanchDungeonData Data;

	// Token: 0x04006043 RID: 24643
	private GenericLayout<FloroRanchSubDungeonItem, FloroRanchSubDungeonData> SubDungeonLayout;

	// Token: 0x04006044 RID: 24644
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04006045 RID: 24645
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Action<FloroRanchDungeonData, FloroRanchSubDungeonData> OnToggleCallBack;

	// Token: 0x02008110 RID: 33040
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A1F9 RID: 172537
		public const int ToggleRoot = 0;

		// Token: 0x0402A1FA RID: 172538
		public const int TextName = 1;

		// Token: 0x0402A1FB RID: 172539
		public const int LayoutSubIns = 2;

		// Token: 0x0402A1FC RID: 172540
		public const int ItemSubIns = 3;

		// Token: 0x0402A1FD RID: 172541
		public const int TextLock = 4;

		// Token: 0x0402A1FE RID: 172542
		public const int SpriteDifficultyIcon = 5;

		// Token: 0x0402A1FF RID: 172543
		public const int SpriteRomeNum = 6;

		// Token: 0x0402A200 RID: 172544
		public const int SpriteLock = 7;

		// Token: 0x0402A201 RID: 172545
		public const int SpriteDifficultyLock = 8;

		// Token: 0x0402A202 RID: 172546
		public const int ItemRedDot = 9;

		// Token: 0x0402A203 RID: 172547
		public const int SpriteTranRomeNum = 10;
	}
}
