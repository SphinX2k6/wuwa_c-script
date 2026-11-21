using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C21 RID: 15393
	public class SheriffQuestionTabItem : GridProxyAbstract<int>
	{
		// Token: 0x060276F3 RID: 161523 RVA: 0x00B0ED1C File Offset: 0x00B0CF1C
		[NullableContext(1)]
		public SheriffQuestionTabItem(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x060276F4 RID: 161524 RVA: 0x00B0ED2C File Offset: 0x00B0CF2C
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

		// Token: 0x060276F5 RID: 161525 RVA: 0x00B0EDD7 File Offset: 0x00B0CFD7
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x060276F6 RID: 161526 RVA: 0x00B0EDF6 File Offset: 0x00B0CFF6
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x060276F7 RID: 161527 RVA: 0x00B0EE1C File Offset: 0x00B0D01C
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

		// Token: 0x060276F8 RID: 161528 RVA: 0x00B0EEAD File Offset: 0x00B0D0AD
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060276F9 RID: 161529 RVA: 0x00B0EEC6 File Offset: 0x00B0D0C6
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(base.GridIndex);
		}

		// Token: 0x040157FB RID: 88059
		protected int CurId;

		// Token: 0x040157FC RID: 88060
		[Nullable(1)]
		protected SheriffMainProxy Proxy;

		// Token: 0x040157FD RID: 88061
		[Nullable(2)]
		public Action<int> OnToggleStateChangedCallback;

		// Token: 0x040157FE RID: 88062
		[Nullable(2)]
		public Func<int, bool> CheckSelectCallback;

		// Token: 0x02009841 RID: 38977
		private static class EQuestionTab
		{
			// Token: 0x0402F7D5 RID: 194517
			public const int TogClueTab = 0;

			// Token: 0x0402F7D6 RID: 194518
			public const int TxtName = 1;

			// Token: 0x0402F7D7 RID: 194519
			public const int PanelDone = 2;

			// Token: 0x0402F7D8 RID: 194520
			public const int PanelLock = 3;
		}
	}
}
