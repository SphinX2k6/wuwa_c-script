using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200104B RID: 4171
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchDungeonItem : GridProxyAbstract<FloroRanchDungeonData>
{
	// Token: 0x0600A603 RID: 42499 RVA: 0x0030D4C4 File Offset: 0x0030B6C4
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

	// Token: 0x0600A604 RID: 42500 RVA: 0x0030D696 File Offset: 0x0030B896
	protected override void OnStart()
	{
		this.SubDungeonLayout = new GenericLayout<FloroRanchSubDungeonItem, FloroRanchSubDungeonData>(base.GetHorizontalLayout(2), new Func<FloroRanchSubDungeonItem>(this.CreateSubDungeonItem), null, false, true);
	}

	// Token: 0x0600A605 RID: 42501 RVA: 0x0030D6B9 File Offset: 0x0030B8B9
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x0600A606 RID: 42502 RVA: 0x0030D6D7 File Offset: 0x0030B8D7
	public override void Refresh(FloroRanchDungeonData data, bool isSelected, int gridIndex)
	{
		this.RefreshItem(data);
	}

	// Token: 0x0600A607 RID: 42503 RVA: 0x0030D6E0 File Offset: 0x0030B8E0
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

	// Token: 0x0600A608 RID: 42504 RVA: 0x0030D892 File Offset: 0x0030BA92
	private void UpdateUnlock()
	{
		if (this.Data.IsUnLock)
		{
			this.RefreshItem(this.Data);
		}
	}

	// Token: 0x0600A609 RID: 42505 RVA: 0x0030D8AD File Offset: 0x0030BAAD
	private void AddTimer()
	{
		this.RemoveTimer();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.UpdateUnlock();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600A60A RID: 42506 RVA: 0x0030D8DE File Offset: 0x0030BADE
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600A60B RID: 42507 RVA: 0x0030D900 File Offset: 0x0030BB00
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x0600A60C RID: 42508 RVA: 0x0030D91E File Offset: 0x0030BB1E
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimer();
	}

	// Token: 0x0600A60D RID: 42509 RVA: 0x0030D928 File Offset: 0x0030BB28
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

	// Token: 0x0600A60E RID: 42510 RVA: 0x0030D96C File Offset: 0x0030BB6C
	private void OnClickToggle(EToggleState _)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(this.Data, this.Data.GetLatestSubDungeonData());
		}
	}

	// Token: 0x0600A60F RID: 42511 RVA: 0x0030D994 File Offset: 0x0030BB94
	public void SetToggleCallBack(Action<FloroRanchDungeonData> callBack)
	{
		this.OnToggleCallBack = delegate(FloroRanchDungeonData dungeonData, FloroRanchSubDungeonData subDungeonData)
		{
			callBack(dungeonData);
		};
	}

	// Token: 0x0600A610 RID: 42512 RVA: 0x0030D9C0 File Offset: 0x0030BBC0
	private FloroRanchSubDungeonItem CreateSubDungeonItem()
	{
		return new FloroRanchSubDungeonItem();
	}

	// Token: 0x0600A611 RID: 42513 RVA: 0x0030D9C7 File Offset: 0x0030BBC7
	public override object GetKey(FloroRanchDungeonData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600A612 RID: 42514 RVA: 0x0030D9D4 File Offset: 0x0030BBD4
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600A613 RID: 42515 RVA: 0x0030D9E6 File Offset: 0x0030BBE6
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04006111 RID: 24849
	private FloroRanchDungeonData Data;

	// Token: 0x04006112 RID: 24850
	private GenericLayout<FloroRanchSubDungeonItem, FloroRanchSubDungeonData> SubDungeonLayout;

	// Token: 0x04006113 RID: 24851
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04006114 RID: 24852
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Action<FloroRanchDungeonData, FloroRanchSubDungeonData> OnToggleCallBack;

	// Token: 0x0200729E RID: 29342
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402552D RID: 152877
		public const int ToggleRoot = 0;

		// Token: 0x0402552E RID: 152878
		public const int TextName = 1;

		// Token: 0x0402552F RID: 152879
		public const int LayoutSubIns = 2;

		// Token: 0x04025530 RID: 152880
		public const int ItemSubIns = 3;

		// Token: 0x04025531 RID: 152881
		public const int TextLock = 4;

		// Token: 0x04025532 RID: 152882
		public const int SpriteDifficultyIcon = 5;

		// Token: 0x04025533 RID: 152883
		public const int SpriteRomeNum = 6;

		// Token: 0x04025534 RID: 152884
		public const int SpriteLock = 7;

		// Token: 0x04025535 RID: 152885
		public const int SpriteDifficultyLock = 8;

		// Token: 0x04025536 RID: 152886
		public const int ItemRedDot = 9;

		// Token: 0x04025537 RID: 152887
		public const int SpriteTranRomeNum = 10;
	}
}
