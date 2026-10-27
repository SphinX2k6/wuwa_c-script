using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B93 RID: 7059
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchHandBookSmallSlotItem : GridProxyAbstract<FloroRanchUnlockDataBase>
{
	// Token: 0x0600D22A RID: 53802 RVA: 0x003039F0 File Offset: 0x00301BF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D22B RID: 53803 RVA: 0x00303C90 File Offset: 0x00301E90
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchHandBookSmallSlotItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchHandBookSmallSlotItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D22C RID: 53804 RVA: 0x00303CD4 File Offset: 0x00301ED4
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(7);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUISprite sprite2 = base.GetSprite(9);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(false);
	}

	// Token: 0x0600D22D RID: 53805 RVA: 0x00303D2D File Offset: 0x00301F2D
	public void SetActivityDataType(EFloroRanchActivityDataType type)
	{
		this.ActivityDataType = type;
	}

	// Token: 0x0600D22E RID: 53806 RVA: 0x00303D38 File Offset: 0x00301F38
	public override UniTask RefreshAsync(FloroRanchUnlockDataBase data, bool isSelected, int gridIndex)
	{
		FloroRanchHandBookSmallSlotItem.<RefreshAsync>d__9 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<FloroRanchHandBookSmallSlotItem.<RefreshAsync>d__9>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D22F RID: 53807 RVA: 0x00303D84 File Offset: 0x00301F84
	private void OnToggleClick(EToggleState _)
	{
		FloroRanchUnlockCardData floroRanchUnlockCardData = this.Data as FloroRanchUnlockCardData;
		if (floroRanchUnlockCardData != null)
		{
			FloroRanchCardData cardData = floroRanchUnlockCardData.GetCardData();
			if (cardData != null)
			{
				AudioSystem.Instance.PostEvent(cardData.Video);
			}
		}
		Action<FloroRanchHandBookSmallSlotItem> onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback(this);
	}

	// Token: 0x0600D230 RID: 53808 RVA: 0x00303DCC File Offset: 0x00301FCC
	public void BindClickCallback(Action<FloroRanchHandBookSmallSlotItem> callback)
	{
		this.OnClickCallback = callback;
	}

	// Token: 0x0600D231 RID: 53809 RVA: 0x00303DD8 File Offset: 0x00301FD8
	public override void OnSelected(bool fireEvent)
	{
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		if (!this.Data.IsUnLock)
		{
			return;
		}
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true);
		if (activityData == null)
		{
			return;
		}
		activityData.MarkUnlockDataAsViewed(this.Data);
	}

	// Token: 0x0600D232 RID: 53810 RVA: 0x00303E38 File Offset: 0x00302038
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04006052 RID: 24658
	public FloroRanchUnlockDataBase Data;

	// Token: 0x04006053 RID: 24659
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04006054 RID: 24660
	private FloroRanchToyLevelItem LevelItem;

	// Token: 0x04006055 RID: 24661
	private Action<FloroRanchHandBookSmallSlotItem> OnClickCallback = delegate(FloroRanchHandBookSmallSlotItem item)
	{
	};

	// Token: 0x0200811C RID: 33052
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A243 RID: 172611
		public const int Toggle = 0;

		// Token: 0x0402A244 RID: 172612
		public const int QualitySprite = 1;

		// Token: 0x0402A245 RID: 172613
		public const int IconTexture = 2;

		// Token: 0x0402A246 RID: 172614
		public const int CountDownPanel = 3;

		// Token: 0x0402A247 RID: 172615
		public const int CountdownText = 4;

		// Token: 0x0402A248 RID: 172616
		public const int NumPanel = 5;

		// Token: 0x0402A249 RID: 172617
		public const int NumText = 6;

		// Token: 0x0402A24A RID: 172618
		public const int LockSprite = 7;

		// Token: 0x0402A24B RID: 172619
		public const int HidePanel = 8;

		// Token: 0x0402A24C RID: 172620
		public const int ItemBgSprite = 9;

		// Token: 0x0402A24D RID: 172621
		public const int IconMaskTexture = 10;

		// Token: 0x0402A24E RID: 172622
		public const int UnknownPanel = 11;

		// Token: 0x0402A24F RID: 172623
		public const int ItemPhantomIcon = 12;

		// Token: 0x0402A250 RID: 172624
		public const int ItemNew = 13;

		// Token: 0x0402A251 RID: 172625
		public const int ToyRaceItem = 14;

		// Token: 0x0402A252 RID: 172626
		public const int ToyRaceIcon = 15;

		// Token: 0x0402A253 RID: 172627
		public const int LevelItem = 16;
	}
}
