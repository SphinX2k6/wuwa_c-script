using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041F5 RID: 16885
	public class CardDetailRemainRoundItem : UiPanelBase
	{
		// Token: 0x0602AB27 RID: 174887 RVA: 0x00C06BE4 File Offset: 0x00C04DE4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602AB28 RID: 174888 RVA: 0x00C06C1D File Offset: 0x00C04E1D
		[NullableContext(1)]
		public void Refresh(ICardDetailRemainRoundData data)
		{
		}

		// Token: 0x02009DF2 RID: 40434
		private static class EComponentDefine
		{
			// Token: 0x040311E2 RID: 201186
			public const int RootItem = 0;

			// Token: 0x040311E3 RID: 201187
			public const int RemainRoundText = 1;
		}
	}
}
