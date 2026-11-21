using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E7 RID: 16871
	public class CardDetailLockItem : UiPanelBase
	{
		// Token: 0x0602AAD6 RID: 174806 RVA: 0x00C066CE File Offset: 0x00C048CE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602AAD7 RID: 174807 RVA: 0x00C066F1 File Offset: 0x00C048F1
		[NullableContext(1)]
		public void Refresh(ICardDetailLockData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, new <>z__ReadOnlySingleElementList<object>(data.RemainRound));
		}

		// Token: 0x02009DF0 RID: 40432
		private static class EComponentDefine
		{
			// Token: 0x040311D9 RID: 201177
			public const int LockText = 0;
		}
	}
}
