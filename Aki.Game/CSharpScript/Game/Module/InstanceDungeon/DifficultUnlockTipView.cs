using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005861 RID: 22625
	public class DifficultUnlockTipView : UiViewBase
	{
		// Token: 0x0603985B RID: 235611 RVA: 0x00DA84D2 File Offset: 0x00DA66D2
		[NullableContext(1)]
		public DifficultUnlockTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603985C RID: 235612 RVA: 0x00DA84DC File Offset: 0x00DA66DC
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

		// Token: 0x0603985D RID: 235613 RVA: 0x00DA8524 File Offset: 0x00DA6724
		protected override void OnBeforeShow()
		{
			DifficultUnlockTipsData data = this.OpenParam as DifficultUnlockTipsData;
			this.Refresh(data);
		}

		// Token: 0x0603985E RID: 235614 RVA: 0x00DA8544 File Offset: 0x00DA6744
		[NullableContext(1)]
		private void Refresh(DifficultUnlockTipsData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Text, data.Params);
		}

		// Token: 0x0603985F RID: 235615 RVA: 0x00DA8563 File Offset: 0x00DA6763
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200BA89 RID: 47753
		private class EComponents
		{
			// Token: 0x04038620 RID: 230944
			public const int UnLockText = 0;
		}
	}
}
