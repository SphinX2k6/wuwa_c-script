using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006465 RID: 25701
	internal class WishingItem : UiPanelBase
	{
		// Token: 0x0604096C RID: 264556 RVA: 0x00FA2220 File Offset: 0x00FA0420
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604096D RID: 264557 RVA: 0x00FA22CC File Offset: 0x00FA04CC
		public void RefreshItem(int moonId)
		{
			PhaseOfMoon? phaseOfMoonById = MoonSignInConfig.Instance.GetPhaseOfMoonById(moonId);
			if (phaseOfMoonById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), phaseOfMoonById.Value.Talk(0), Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phaseOfMoonById.Value.Talk(1), Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phaseOfMoonById.Value.Talk(2), Array.Empty<object>());
			base.SetTextureByPath(phaseOfMoonById.Value.Texture, base.GetTexture(5), null, null);
		}

		// Token: 0x0200C68F RID: 50831
		private class EWishingItemDefine
		{
			// Token: 0x0403BF12 RID: 245522
			public const int DesText1 = 0;

			// Token: 0x0403BF13 RID: 245523
			public const int DesText2 = 1;

			// Token: 0x0403BF14 RID: 245524
			public const int DesText3 = 2;

			// Token: 0x0403BF15 RID: 245525
			public const int MoonTexture = 5;
		}
	}
}
