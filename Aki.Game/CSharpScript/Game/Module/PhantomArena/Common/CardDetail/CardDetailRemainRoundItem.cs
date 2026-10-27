using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005225 RID: 21029
	public class CardDetailRemainRoundItem : UiPanelBase
	{
		// Token: 0x06035C2C RID: 220204 RVA: 0x00CB95A4 File Offset: 0x00CB77A4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035C2D RID: 220205 RVA: 0x00CB95DD File Offset: 0x00CB77DD
		[NullableContext(1)]
		public void Refresh(ICardDetailRemainRoundData data)
		{
		}

		// Token: 0x0200B3BA RID: 46010
		private static class EComponentDefine
		{
			// Token: 0x0403678F RID: 223119
			public const int RootItem = 0;

			// Token: 0x04036790 RID: 223120
			public const int RemainRoundText = 1;
		}
	}
}
