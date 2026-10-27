using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AA0 RID: 19104
	public class TrapDefenseResultButton : UiPanelBase
	{
		// Token: 0x06031833 RID: 202803 RVA: 0x00B7A9F8 File Offset: 0x00B78BF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031834 RID: 202804 RVA: 0x00B7AAA0 File Offset: 0x00B78CA0
		public void BindRedDot(ERedDotName redDotName, int? uid = null)
		{
			this.RedDotName = new ERedDotName?(redDotName);
			UUIItem item = base.GetItem(1);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uid.GetValueOrDefault());
		}

		// Token: 0x06031835 RID: 202805 RVA: 0x00B7AAD8 File Offset: 0x00B78CD8
		public void UnBindRedDot()
		{
			if (this.RedDotName == null)
			{
				return;
			}
			UUIItem item = base.GetItem(1);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
		}

		// Token: 0x06031836 RID: 202806 RVA: 0x00B7AB12 File Offset: 0x00B78D12
		private void OnClickedBtn()
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb();
			}
		}

		// Token: 0x0401A776 RID: 108406
		[Nullable(2)]
		public Action OnClickCb;

		// Token: 0x0401A777 RID: 108407
		private ERedDotName? RedDotName;

		// Token: 0x0200ABF8 RID: 44024
		private class EBtn
		{
			// Token: 0x0403441A RID: 214042
			public const int Btn = 0;

			// Token: 0x0403441B RID: 214043
			public const int RedDot = 1;
		}
	}
}
