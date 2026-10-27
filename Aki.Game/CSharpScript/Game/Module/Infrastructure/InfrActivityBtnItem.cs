using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005909 RID: 22793
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrActivityBtnItem : UiPanelBase
	{
		// Token: 0x06039E17 RID: 237079 RVA: 0x00DBF2F8 File Offset: 0x00DBD4F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039E18 RID: 237080 RVA: 0x00DBF3BF File Offset: 0x00DBD5BF
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06039E19 RID: 237081 RVA: 0x00DBF3D1 File Offset: 0x00DBD5D1
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06039E1A RID: 237082 RVA: 0x00DBF3DA File Offset: 0x00DBD5DA
		public void SetText(string text)
		{
			base.GetText(1).ShowTextNew(text);
		}

		// Token: 0x06039E1B RID: 237083 RVA: 0x00DBF3E9 File Offset: 0x00DBD5E9
		public void SetRedPointVisible(bool visible)
		{
			base.GetItem(2).SetUIActive(visible);
		}

		// Token: 0x0401E30B RID: 123659
		private Action ButtonFunction;

		// Token: 0x0200BB70 RID: 47984
		[NullableContext(0)]
		private class EButtonItemDefine
		{
			// Token: 0x0403893B RID: 231739
			public const int Button = 0;

			// Token: 0x0403893C RID: 231740
			public const int ButtonText = 1;

			// Token: 0x0403893D RID: 231741
			public const int PanelRedPoint = 2;
		}
	}
}
