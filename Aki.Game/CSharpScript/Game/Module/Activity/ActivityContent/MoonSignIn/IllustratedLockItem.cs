using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006464 RID: 25700
	internal class IllustratedLockItem : UiPanelBase
	{
		// Token: 0x06040969 RID: 264553 RVA: 0x00FA213C File Offset: 0x00FA033C
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

		// Token: 0x0604096A RID: 264554 RVA: 0x00FA21A8 File Offset: 0x00FA03A8
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

		// Token: 0x0200C68E RID: 50830
		private class EIllustratedLockItemDefine
		{
			// Token: 0x0403BF10 RID: 245520
			public const int MoonTexture = 0;

			// Token: 0x0403BF11 RID: 245521
			public const int MoonMaskTexture = 1;
		}
	}
}
