using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x0200569D RID: 22173
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DirectTrainHighlightTabItem : GridProxyAbstract<IHighlightTabData>
	{
		// Token: 0x06036B55 RID: 224085 RVA: 0x00F43E24 File Offset: 0x00F42024
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036B56 RID: 224086 RVA: 0x00F43ECA File Offset: 0x00F420CA
		public void SetOnSelectCallback(Action<IHighlightTabData> callback)
		{
			this.OnSelectCallback = callback;
		}

		// Token: 0x06036B57 RID: 224087 RVA: 0x00F43ED3 File Offset: 0x00F420D3
		public override void Refresh(IHighlightTabData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTitle, Array.Empty<object>());
			this.RefreshToggleState(isSelected);
		}

		// Token: 0x06036B58 RID: 224088 RVA: 0x00F43EFF File Offset: 0x00F420FF
		public override object GetKey(IHighlightTabData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06036B59 RID: 224089 RVA: 0x00F43F0C File Offset: 0x00F4210C
		public override void OnSelected(bool fireEvent)
		{
			this.RefreshToggleState(true);
			if (fireEvent && this.Data != null)
			{
				Action<IHighlightTabData> onSelectCallback = this.OnSelectCallback;
				if (onSelectCallback == null)
				{
					return;
				}
				onSelectCallback(this.Data);
			}
		}

		// Token: 0x06036B5A RID: 224090 RVA: 0x00F43F36 File Offset: 0x00F42136
		public override void OnDeselected(bool fireEvent)
		{
			this.RefreshToggleState(false);
		}

		// Token: 0x06036B5B RID: 224091 RVA: 0x00F43F40 File Offset: 0x00F42140
		public void RefreshToggleState(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06036B5C RID: 224092 RVA: 0x00F43F69 File Offset: 0x00F42169
		private void OnToggleClick(EToggleState _)
		{
			if (this.Data != null)
			{
				Action<IHighlightTabData> onSelectCallback = this.OnSelectCallback;
				if (onSelectCallback == null)
				{
					return;
				}
				onSelectCallback(this.Data);
			}
		}

		// Token: 0x0401CE67 RID: 118375
		[Nullable(2)]
		private IHighlightTabData Data;

		// Token: 0x0401CE68 RID: 118376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IHighlightTabData> OnSelectCallback;

		// Token: 0x0200B295 RID: 45717
		[NullableContext(0)]
		private enum EHighlightTabComponents
		{
			// Token: 0x040372DB RID: 226011
			Toggle,
			// Token: 0x040372DC RID: 226012
			Text
		}
	}
}
