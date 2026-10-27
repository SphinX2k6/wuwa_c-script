using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005217 RID: 21015
	public class CardDetailLockItem : UiPanelBase
	{
		// Token: 0x06035BDB RID: 220123 RVA: 0x00CB908A File Offset: 0x00CB728A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035BDC RID: 220124 RVA: 0x00CB90AD File Offset: 0x00CB72AD
		[NullableContext(1)]
		public void Refresh(ICardDetailLockData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, new <>z__ReadOnlySingleElementList<object>(data.RemainRound));
		}

		// Token: 0x0200B3B8 RID: 46008
		private static class EComponentDefine
		{
			// Token: 0x04036786 RID: 223110
			public const int LockText = 0;
		}
	}
}
