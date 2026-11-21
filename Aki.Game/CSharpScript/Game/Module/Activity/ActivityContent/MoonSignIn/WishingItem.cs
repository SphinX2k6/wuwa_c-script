using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053E3 RID: 21475
	internal class WishingItem : UiPanelBase
	{
		// Token: 0x0603562D RID: 218669 RVA: 0x00EE919C File Offset: 0x00EE739C
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

		// Token: 0x0603562E RID: 218670 RVA: 0x00EE9248 File Offset: 0x00EE7448
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

		// Token: 0x0200B075 RID: 45173
		private class EWishingItemDefine
		{
			// Token: 0x0403686D RID: 223341
			public const int DesText1 = 0;

			// Token: 0x0403686E RID: 223342
			public const int DesText2 = 1;

			// Token: 0x0403686F RID: 223343
			public const int DesText3 = 2;

			// Token: 0x04036870 RID: 223344
			public const int MoonTexture = 5;
		}
	}
}
