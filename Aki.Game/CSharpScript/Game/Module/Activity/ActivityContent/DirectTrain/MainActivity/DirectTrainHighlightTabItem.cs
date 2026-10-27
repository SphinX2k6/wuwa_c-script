using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x0200674D RID: 26445
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DirectTrainHighlightTabItem : GridProxyAbstract<IHighlightTabData>
	{
		// Token: 0x06042003 RID: 270339 RVA: 0x010029E4 File Offset: 0x01000BE4
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

		// Token: 0x06042004 RID: 270340 RVA: 0x01002A8A File Offset: 0x01000C8A
		public void SetOnSelectCallback(Action<IHighlightTabData> callback)
		{
			this.OnSelectCallback = callback;
		}

		// Token: 0x06042005 RID: 270341 RVA: 0x01002A93 File Offset: 0x01000C93
		public override void Refresh(IHighlightTabData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTitle, Array.Empty<object>());
			this.RefreshToggleState(isSelected);
		}

		// Token: 0x06042006 RID: 270342 RVA: 0x01002ABF File Offset: 0x01000CBF
		public override object GetKey(IHighlightTabData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06042007 RID: 270343 RVA: 0x01002ACC File Offset: 0x01000CCC
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

		// Token: 0x06042008 RID: 270344 RVA: 0x01002AF6 File Offset: 0x01000CF6
		public override void OnDeselected(bool fireEvent)
		{
			this.RefreshToggleState(false);
		}

		// Token: 0x06042009 RID: 270345 RVA: 0x01002B00 File Offset: 0x01000D00
		public void RefreshToggleState(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x0604200A RID: 270346 RVA: 0x01002B29 File Offset: 0x01000D29
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

		// Token: 0x0402260E RID: 140814
		[Nullable(2)]
		private IHighlightTabData Data;

		// Token: 0x0402260F RID: 140815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IHighlightTabData> OnSelectCallback;

		// Token: 0x0200C8C6 RID: 51398
		[NullableContext(0)]
		private enum EHighlightTabComponents
		{
			// Token: 0x0403C9E1 RID: 248289
			Toggle,
			// Token: 0x0403C9E2 RID: 248290
			Text
		}
	}
}
