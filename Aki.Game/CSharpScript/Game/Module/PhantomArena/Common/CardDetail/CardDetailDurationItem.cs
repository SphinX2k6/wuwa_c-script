using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200520A RID: 21002
	public class CardDetailDurationItem : UiPanelBase
	{
		// Token: 0x06035B92 RID: 220050 RVA: 0x00CB8320 File Offset: 0x00CB6520
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035B93 RID: 220051 RVA: 0x00CB8359 File Offset: 0x00CB6559
		[NullableContext(1)]
		public void Refresh(ICardDetailDurationData data)
		{
			if (!string.IsNullOrEmpty(data.Tips))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Tips, Array.Empty<object>());
			}
			base.GetText(1).SetText(data.DurationDesc, true);
		}

		// Token: 0x0200B3AD RID: 45997
		private static class EComponentDefine
		{
			// Token: 0x04036750 RID: 223056
			public const int TipsText = 0;

			// Token: 0x04036751 RID: 223057
			public const int DurationText = 1;
		}
	}
}
