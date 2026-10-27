using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BDA RID: 23514
	public class CiacconaGalReChoosePlainTextItem : UiPanelBase
	{
		// Token: 0x0603B71C RID: 243484 RVA: 0x00E2CCDC File Offset: 0x00E2AEDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B71D RID: 243485 RVA: 0x00E2CD24 File Offset: 0x00E2AF24
		[NullableContext(1)]
		public void Refresh(string text)
		{
			if (StringUtils.IsEmpty(text))
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), text, Array.Empty<object>());
		}

		// Token: 0x0200BDBA RID: 48570
		public class EPlainTextComponentDefine
		{
			// Token: 0x0403936F RID: 234351
			public const int Text = 0;
		}
	}
}
