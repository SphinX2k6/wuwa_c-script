using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x020049F6 RID: 18934
	public class FunctionBottomButtonItem : UiPanelBase
	{
		// Token: 0x0602F75F RID: 194399 RVA: 0x00D3C7DB File Offset: 0x00D3A9DB
		[NullableContext(1)]
		public FunctionBottomButtonItem(UUIItem uiItem, ERedDotName redDotName)
		{
			this.RedDotName = redDotName;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602F760 RID: 194400 RVA: 0x00D3C7F8 File Offset: 0x00D3A9F8
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

		// Token: 0x0602F761 RID: 194401 RVA: 0x00D3C840 File Offset: 0x00D3AA40
		public void BindRedDot()
		{
			UUIItem item = base.GetItem(0);
			RedDotController.Instance.BindRedDot(this.RedDotName, item, null, 0);
		}

		// Token: 0x0602F762 RID: 194402 RVA: 0x00D3C868 File Offset: 0x00D3AA68
		public void UnBindRedDot()
		{
			UUIItem item = base.GetItem(0);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName, item, 0);
		}

		// Token: 0x04019243 RID: 102979
		private readonly ERedDotName RedDotName;

		// Token: 0x0200A698 RID: 42648
		private class ECompDefine
		{
			// Token: 0x040337FE RID: 210942
			public const int RedDot = 0;
		}
	}
}
