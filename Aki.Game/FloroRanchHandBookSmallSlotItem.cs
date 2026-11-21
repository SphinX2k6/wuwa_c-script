using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001052 RID: 4178
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchHandBookSmallSlotItem : GridProxyAbstract<FloroRanchUnlockDataBase>
{
	// Token: 0x0600A63B RID: 42555 RVA: 0x0030EAC8 File Offset: 0x0030CCC8
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

	// Token: 0x0600A63C RID: 42556 RVA: 0x0030ED68 File Offset: 0x0030CF68
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchHandBookSmallSlotItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchHandBookSmallSlotItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A63D RID: 42557 RVA: 0x0030EDAC File Offset: 0x0030CFAC
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

	// Token: 0x0600A63E RID: 42558 RVA: 0x0030EE05 File Offset: 0x0030D005
	public void SetActivityDataType(EFloroRanchActivityDataType type)
	{
		this.ActivityDataType = type;
	}

	// Token: 0x0600A63F RID: 42559 RVA: 0x0030EE10 File Offset: 0x0030D010
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

	// Token: 0x0600A640 RID: 42560 RVA: 0x0030EE5C File Offset: 0x0030D05C
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

	// Token: 0x0600A641 RID: 42561 RVA: 0x0030EEA4 File Offset: 0x0030D0A4
	public void BindClickCallback(Action<FloroRanchHandBookSmallSlotItem> callback)
	{
		this.OnClickCallback = callback;
	}

	// Token: 0x0600A642 RID: 42562 RVA: 0x0030EEB0 File Offset: 0x0030D0B0
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

	// Token: 0x0600A643 RID: 42563 RVA: 0x0030EF10 File Offset: 0x0030D110
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04006121 RID: 24865
	public FloroRanchUnlockDataBase Data;

	// Token: 0x04006122 RID: 24866
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04006123 RID: 24867
	private FloroRanchToyLevelItem LevelItem;

	// Token: 0x04006124 RID: 24868
	private Action<FloroRanchHandBookSmallSlotItem> OnClickCallback = delegate(FloroRanchHandBookSmallSlotItem item)
	{
	};

	// Token: 0x020072AA RID: 29354
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04025577 RID: 152951
		public const int Toggle = 0;

		// Token: 0x04025578 RID: 152952
		public const int QualitySprite = 1;

		// Token: 0x04025579 RID: 152953
		public const int IconTexture = 2;

		// Token: 0x0402557A RID: 152954
		public const int CountDownPanel = 3;

		// Token: 0x0402557B RID: 152955
		public const int CountdownText = 4;

		// Token: 0x0402557C RID: 152956
		public const int NumPanel = 5;

		// Token: 0x0402557D RID: 152957
		public const int NumText = 6;

		// Token: 0x0402557E RID: 152958
		public const int LockSprite = 7;

		// Token: 0x0402557F RID: 152959
		public const int HidePanel = 8;

		// Token: 0x04025580 RID: 152960
		public const int ItemBgSprite = 9;

		// Token: 0x04025581 RID: 152961
		public const int IconMaskTexture = 10;

		// Token: 0x04025582 RID: 152962
		public const int UnknownPanel = 11;

		// Token: 0x04025583 RID: 152963
		public const int ItemPhantomIcon = 12;

		// Token: 0x04025584 RID: 152964
		public const int ItemNew = 13;

		// Token: 0x04025585 RID: 152965
		public const int ToyRaceItem = 14;

		// Token: 0x04025586 RID: 152966
		public const int ToyRaceIcon = 15;

		// Token: 0x04025587 RID: 152967
		public const int LevelItem = 16;
	}
}
