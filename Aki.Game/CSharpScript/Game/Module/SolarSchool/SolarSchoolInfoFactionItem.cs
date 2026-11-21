using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B0 RID: 22960
	public class SolarSchoolInfoFactionItem : UiPanelBase
	{
		// Token: 0x060389A3 RID: 231843 RVA: 0x00FD65B4 File Offset: 0x00FD47B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389A4 RID: 231844 RVA: 0x00FD6640 File Offset: 0x00FD4840
		public void Refresh(SolarSchoolInfoFactionData data)
		{
			base.TrySetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
			if (data.Level <= 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SolarSchool_FactionNotJoined", Array.Empty<object>());
				return;
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Level);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0200B55B RID: 46427
		private class EComponent
		{
			// Token: 0x0403812D RID: 229677
			public const int TexIcon = 0;

			// Token: 0x0403812E RID: 229678
			public const int TxtTitle01 = 1;

			// Token: 0x0403812F RID: 229679
			public const int TxtTitle02 = 2;
		}
	}
}
