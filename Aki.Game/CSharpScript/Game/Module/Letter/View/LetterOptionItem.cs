using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020056CE RID: 22222
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LetterOptionItem : GridProxyAbstract<ITalkOption>
	{
		// Token: 0x06038855 RID: 231509 RVA: 0x00D6CE80 File Offset: 0x00D6B080
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

		// Token: 0x06038856 RID: 231510 RVA: 0x00D6CF28 File Offset: 0x00D6B128
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

		// Token: 0x06038857 RID: 231511 RVA: 0x00D6CF80 File Offset: 0x00D6B180
		public void SetOnClick(Action<ITalkOption> callback)
		{
			this.OnClickCallback = callback;
		}

		// Token: 0x06038858 RID: 231512 RVA: 0x00D6CF89 File Offset: 0x00D6B189
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

		// Token: 0x0401DB09 RID: 121609
		[Nullable(2)]
		private ITalkOption CurData;

		// Token: 0x0401DB0A RID: 121610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ITalkOption> OnClickCallback;

		// Token: 0x0200B8A7 RID: 47271
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037E01 RID: 228865
			public const int TxtOption = 0;

			// Token: 0x04037E02 RID: 228866
			public const int TogOption = 1;
		}
	}
}
