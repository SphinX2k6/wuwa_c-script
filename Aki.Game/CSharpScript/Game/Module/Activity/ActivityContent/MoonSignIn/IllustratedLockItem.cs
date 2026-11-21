using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053E2 RID: 21474
	internal class IllustratedLockItem : UiPanelBase
	{
		// Token: 0x0603562A RID: 218666 RVA: 0x00EE90B8 File Offset: 0x00EE72B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603562B RID: 218667 RVA: 0x00EE9124 File Offset: 0x00EE7324
		public void RefreshItem(int moonId)
		{
			PhaseOfMoon? phaseOfMoonById = MoonSignInConfig.Instance.GetPhaseOfMoonById(moonId);
			if (phaseOfMoonById == null)
			{
				return;
			}
			base.SetTextureByPath(phaseOfMoonById.Value.Texture, base.GetTexture(0), null, null);
			base.SetTextureByPath(phaseOfMoonById.Value.Texture, base.GetTexture(1), null, null);
		}

		// Token: 0x0200B074 RID: 45172
		private class EIllustratedLockItemDefine
		{
			// Token: 0x0403686B RID: 223339
			public const int MoonTexture = 0;

			// Token: 0x0403686C RID: 223340
			public const int MoonMaskTexture = 1;
		}
	}
}
