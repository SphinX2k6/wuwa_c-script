using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x02006358 RID: 25432
	internal class BdComponent : UiPanelBase
	{
		// Token: 0x0603FFFB RID: 262139 RVA: 0x00F7B7CC File Offset: 0x00F799CC
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

		// Token: 0x0603FFFC RID: 262140 RVA: 0x00F7B838 File Offset: 0x00F79A38
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

		// Token: 0x0200C579 RID: 50553
		private enum EBdComponent
		{
			// Token: 0x0403B9AA RID: 244138
			BgSprite,
			// Token: 0x0403B9AB RID: 244139
			BdTexture
		}
	}
}
