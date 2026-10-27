using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B8B RID: 7051
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchDifficultyItem : GridProxyAbstract<FloroRanchSubDungeonData>
{
	// Token: 0x0600D1E9 RID: 53737 RVA: 0x003021B0 File Offset: 0x003003B0
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

	// Token: 0x0600D1EA RID: 53738 RVA: 0x003022BC File Offset: 0x003004BC
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

	// Token: 0x0600D1EB RID: 53739 RVA: 0x00302342 File Offset: 0x00300542
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(this.Data);
		}
	}

	// Token: 0x0600D1EC RID: 53740 RVA: 0x0030235D File Offset: 0x0030055D
	public void SetToggleCallBack(Action<FloroRanchSubDungeonData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600D1ED RID: 53741 RVA: 0x00302368 File Offset: 0x00300568
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600D1EE RID: 53742 RVA: 0x0030238E File Offset: 0x0030058E
	public override object GetKey(FloroRanchSubDungeonData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600D1EF RID: 53743 RVA: 0x0030239B File Offset: 0x0030059B
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

	// Token: 0x0600D1F0 RID: 53744 RVA: 0x003023D9 File Offset: 0x003005D9
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04006040 RID: 24640
	private FloroRanchSubDungeonData Data;

	// Token: 0x04006041 RID: 24641
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<FloroRanchSubDungeonData> OnToggleCallBack;

	// Token: 0x0200810F RID: 33039
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A1F4 RID: 172532
		public const int ToggleRoot = 0;

		// Token: 0x0402A1F5 RID: 172533
		public const int TextTitle = 1;

		// Token: 0x0402A1F6 RID: 172534
		public const int SpriteFinished = 2;

		// Token: 0x0402A1F7 RID: 172535
		public const int SpriteLock = 3;

		// Token: 0x0402A1F8 RID: 172536
		public const int ItemRedDot = 4;
	}
}
