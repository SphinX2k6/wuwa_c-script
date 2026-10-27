using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A1A RID: 23066
	public class FunctionBottomButtonItem : UiPanelBase
	{
		// Token: 0x0603A816 RID: 239638 RVA: 0x00DEC24B File Offset: 0x00DEA44B
		[NullableContext(1)]
		public FunctionBottomButtonItem(UUIItem uiItem, ERedDotName redDotName)
		{
			this.RedDotName = redDotName;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603A817 RID: 239639 RVA: 0x00DEC268 File Offset: 0x00DEA468
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A818 RID: 239640 RVA: 0x00DEC2B0 File Offset: 0x00DEA4B0
		public void BindRedDot()
		{
			UUIItem item = base.GetItem(0);
			RedDotController.Instance.BindRedDot(this.RedDotName, item, null, 0);
		}

		// Token: 0x0603A819 RID: 239641 RVA: 0x00DEC2D8 File Offset: 0x00DEA4D8
		public void UnBindRedDot()
		{
			UUIItem item = base.GetItem(0);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName, item, 0);
		}

		// Token: 0x0401E79C RID: 124828
		private readonly ERedDotName RedDotName;

		// Token: 0x0200BC8F RID: 48271
		private class ECompDefine
		{
			// Token: 0x04038E33 RID: 233011
			public const int RedDot = 0;
		}
	}
}
