using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200104A RID: 4170
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchDifficultyItem : GridProxyAbstract<FloroRanchSubDungeonData>
{
	// Token: 0x0600A5FA RID: 42490 RVA: 0x0030D288 File Offset: 0x0030B488
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A5FB RID: 42491 RVA: 0x0030D394 File Offset: 0x0030B594
	public override void Refresh(FloroRanchSubDungeonData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		EFloroRanchDifficulty difficulty = (EFloroRanchDifficulty)data.Difficulty;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), FloroRanchDefine.FloroRanchDifficultyTextId[difficulty], Array.Empty<object>());
		UUISprite sprite = base.GetSprite(3);
		if (sprite != null)
		{
			sprite.SetUIActive(!data.IsUnLock);
		}
		UUISprite sprite2 = base.GetSprite(2);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(data.IsFinished);
		}
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.HasRedDot);
	}

	// Token: 0x0600A5FC RID: 42492 RVA: 0x0030D41A File Offset: 0x0030B61A
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(this.Data);
		}
	}

	// Token: 0x0600A5FD RID: 42493 RVA: 0x0030D435 File Offset: 0x0030B635
	public void SetToggleCallBack(Action<FloroRanchSubDungeonData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600A5FE RID: 42494 RVA: 0x0030D440 File Offset: 0x0030B640
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600A5FF RID: 42495 RVA: 0x0030D466 File Offset: 0x0030B666
	public override object GetKey(FloroRanchSubDungeonData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600A600 RID: 42496 RVA: 0x0030D473 File Offset: 0x0030B673
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (this.Data.HasRedDot)
		{
			FloroRanchController.Instance.RequestSubDungeonRead(this.Data.Id);
		}
	}

	// Token: 0x0600A601 RID: 42497 RVA: 0x0030D4B1 File Offset: 0x0030B6B1
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0400610F RID: 24847
	private FloroRanchSubDungeonData Data;

	// Token: 0x04006110 RID: 24848
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<FloroRanchSubDungeonData> OnToggleCallBack;

	// Token: 0x0200729D RID: 29341
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025528 RID: 152872
		public const int ToggleRoot = 0;

		// Token: 0x04025529 RID: 152873
		public const int TextTitle = 1;

		// Token: 0x0402552A RID: 152874
		public const int SpriteFinished = 2;

		// Token: 0x0402552B RID: 152875
		public const int SpriteLock = 3;

		// Token: 0x0402552C RID: 152876
		public const int ItemRedDot = 4;
	}
}
