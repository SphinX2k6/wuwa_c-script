using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200613D RID: 24893
	public class RoverlikeRewardItem : UiPanelBase
	{
		// Token: 0x0603EEDA RID: 257754 RVA: 0x00F3335C File Offset: 0x00F3155C
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

		// Token: 0x0603EEDB RID: 257755 RVA: 0x00F333E8 File Offset: 0x00F315E8
		[NullableContext(1)]
		public void Refresh(IRoverlikeSettleRewardItemData data)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameTextId, Array.Empty<object>());
			base.GetText(2).SetText(data.Num.ToString(), true);
		}

		// Token: 0x0200C399 RID: 50073
		private class EComponents
		{
			// Token: 0x0403B061 RID: 241761
			public const int TexIcon = 0;

			// Token: 0x0403B062 RID: 241762
			public const int TxtTitle = 1;

			// Token: 0x0403B063 RID: 241763
			public const int TxtNum = 2;
		}
	}
}
