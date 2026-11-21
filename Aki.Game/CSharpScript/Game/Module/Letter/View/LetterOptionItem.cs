using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020046A5 RID: 18085
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LetterOptionItem : GridProxyAbstract<ITalkOption>
	{
		// Token: 0x0602D765 RID: 186213 RVA: 0x00CBB438 File Offset: 0x00CB9638
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D766 RID: 186214 RVA: 0x00CBB4E0 File Offset: 0x00CB96E0
		public override void Refresh(ITalkOption data, bool isSelected, int gridIndex)
		{
			this.CurData = data;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
			}
			UUIText text = base.GetText(0);
			if (text != null && !string.IsNullOrEmpty(data.TidTalkOption))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.TidTalkOption, Array.Empty<object>());
			}
		}

		// Token: 0x0602D767 RID: 186215 RVA: 0x00CBB538 File Offset: 0x00CB9738
		public void SetOnClick(Action<ITalkOption> callback)
		{
			this.OnClickCallback = callback;
		}

		// Token: 0x0602D768 RID: 186216 RVA: 0x00CBB541 File Offset: 0x00CB9741
		private void OnClickToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.CurData == null)
			{
				return;
			}
			Action<ITalkOption> onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback(this.CurData);
		}

		// Token: 0x0401859F RID: 99743
		[Nullable(2)]
		private ITalkOption CurData;

		// Token: 0x040185A0 RID: 99744
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ITalkOption> OnClickCallback;

		// Token: 0x0200A2CE RID: 41678
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403281B RID: 206875
			public const int TxtOption = 0;

			// Token: 0x0403281C RID: 206876
			public const int TogOption = 1;
		}
	}
}
