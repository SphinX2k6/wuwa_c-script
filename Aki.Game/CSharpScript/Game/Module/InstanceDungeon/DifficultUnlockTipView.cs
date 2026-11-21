using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004839 RID: 18489
	public class DifficultUnlockTipView : UiViewBase
	{
		// Token: 0x0602E778 RID: 190328 RVA: 0x00CF71FA File Offset: 0x00CF53FA
		[NullableContext(1)]
		public DifficultUnlockTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602E779 RID: 190329 RVA: 0x00CF7204 File Offset: 0x00CF5404
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E77A RID: 190330 RVA: 0x00CF724C File Offset: 0x00CF544C
		protected override void OnBeforeShow()
		{
			DifficultUnlockTipsData data = this.OpenParam as DifficultUnlockTipsData;
			this.Refresh(data);
		}

		// Token: 0x0602E77B RID: 190331 RVA: 0x00CF726C File Offset: 0x00CF546C
		[NullableContext(1)]
		private void Refresh(DifficultUnlockTipsData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Text, data.Params);
		}

		// Token: 0x0602E77C RID: 190332 RVA: 0x00CF728B File Offset: 0x00CF548B
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200A4A0 RID: 42144
		private class EComponents
		{
			// Token: 0x04033017 RID: 208919
			public const int UnLockText = 0;
		}
	}
}
