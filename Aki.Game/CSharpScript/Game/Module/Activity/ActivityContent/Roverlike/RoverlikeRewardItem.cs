using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050BB RID: 20667
	public class RoverlikeRewardItem : UiPanelBase
	{
		// Token: 0x06033B9A RID: 211866 RVA: 0x00E7A23C File Offset: 0x00E7843C
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

		// Token: 0x06033B9B RID: 211867 RVA: 0x00E7A2C8 File Offset: 0x00E784C8
		[NullableContext(1)]
		public void Refresh(IRoverlikeSettleRewardItemData data)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameTextId, Array.Empty<object>());
			base.GetText(2).SetText(data.Num.ToString(), true);
		}

		// Token: 0x0200AD80 RID: 44416
		private class EComponents
		{
			// Token: 0x040359C2 RID: 219586
			public const int TexIcon = 0;

			// Token: 0x040359C3 RID: 219587
			public const int TxtTitle = 1;

			// Token: 0x040359C4 RID: 219588
			public const int TxtNum = 2;
		}
	}
}
