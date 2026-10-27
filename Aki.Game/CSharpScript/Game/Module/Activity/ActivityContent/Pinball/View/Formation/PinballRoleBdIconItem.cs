using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x02006370 RID: 25456
	public class PinballRoleBdIconItem : UiPanelBase
	{
		// Token: 0x0604008C RID: 262284 RVA: 0x00F7DD94 File Offset: 0x00F7BF94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604008D RID: 262285 RVA: 0x00F7DE00 File Offset: 0x00F7C000
		public void RefreshItem(int bdId)
		{
			PinballBdConfig? pinballBdConfigById = PinballConfig.Instance.GetPinballBdConfigById(bdId);
			if (pinballBdConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(pinballBdConfigById.Value.Icon, base.GetTexture(1), null, null);
			base.GetSprite(0).SetColor(FColor.FromHex(pinballBdConfigById.Value.BgColor));
		}

		// Token: 0x0200C58B RID: 50571
		private enum EComponent
		{
			// Token: 0x0403BA10 RID: 244240
			BgSprite,
			// Token: 0x0403BA11 RID: 244241
			BdTexture
		}
	}
}
