using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005228 RID: 21032
	public class CardDetailTaskDescItem : UiPanelBase
	{
		// Token: 0x06035C38 RID: 220216 RVA: 0x00CB9611 File Offset: 0x00CB7811
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035C39 RID: 220217 RVA: 0x00CB9634 File Offset: 0x00CB7834
		[NullableContext(1)]
		public void Refresh(ICardDetailTaskData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, new <>z__ReadOnlySingleElementList<object>(data.CurrentProgress));
		}

		// Token: 0x0200B3BB RID: 46011
		private static class EDescItemComponents
		{
			// Token: 0x04036791 RID: 223121
			public const int DescText = 0;
		}
	}
}
