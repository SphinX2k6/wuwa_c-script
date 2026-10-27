using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C70 RID: 19568
	public class SheriffQuestionTabItem : GridProxyAbstract<int>
	{
		// Token: 0x06032940 RID: 207168 RVA: 0x00BCA0B8 File Offset: 0x00BC82B8
		[NullableContext(1)]
		public SheriffQuestionTabItem(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x06032941 RID: 207169 RVA: 0x00BCA0C8 File Offset: 0x00BC82C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032942 RID: 207170 RVA: 0x00BCA173 File Offset: 0x00BC8373
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06032943 RID: 207171 RVA: 0x00BCA192 File Offset: 0x00BC8392
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06032944 RID: 207172 RVA: 0x00BCA1B8 File Offset: 0x00BC83B8
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
			base.GetItem(2).SetUIActive(gridIndex < curQuestionIndex);
			base.GetItem(3).SetUIActive(gridIndex > curQuestionIndex);
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Inference_Desc_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(2 + gridIndex);
			instance.SetLocalTextNew(text, defaultInterpolatedStringHandler.ToStringAndClear(), Array.Empty<object>());
			if (this.CheckSelectCallback != null)
			{
				this.SetSelected(this.CheckSelectCallback(gridIndex), false);
			}
		}

		// Token: 0x06032945 RID: 207173 RVA: 0x00BCA249 File Offset: 0x00BC8449
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06032946 RID: 207174 RVA: 0x00BCA262 File Offset: 0x00BC8462
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(base.GridIndex);
		}

		// Token: 0x0401AE9E RID: 110238
		protected int CurId;

		// Token: 0x0401AE9F RID: 110239
		[Nullable(1)]
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AEA0 RID: 110240
		[Nullable(2)]
		public Action<int> OnToggleStateChangedCallback;

		// Token: 0x0401AEA1 RID: 110241
		[Nullable(2)]
		public Func<int, bool> CheckSelectCallback;

		// Token: 0x0200AE23 RID: 44579
		private static class EQuestionTab
		{
			// Token: 0x04034E30 RID: 216624
			public const int TogClueTab = 0;

			// Token: 0x04034E31 RID: 216625
			public const int TxtName = 1;

			// Token: 0x04034E32 RID: 216626
			public const int PanelDone = 2;

			// Token: 0x04034E33 RID: 216627
			public const int PanelLock = 3;
		}
	}
}
