using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x0200635A RID: 25434
	internal class ClassComponent : UiPanelBase
	{
		// Token: 0x06040003 RID: 262147 RVA: 0x00F7B984 File Offset: 0x00F79B84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040004 RID: 262148 RVA: 0x00F7B9F0 File Offset: 0x00F79BF0
		public void RefreshItem(int classId)
		{
			PinballClassConfig? pinballClassConfigById = PinballConfig.Instance.GetPinballClassConfigById(classId);
			if (pinballClassConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(pinballClassConfigById.Value.Icon, base.GetTexture(1), null, null);
			base.GetItem(0).SetColor(FColor.FromHex(pinballClassConfigById.Value.BgColor));
		}

		// Token: 0x0200C57C RID: 50556
		private enum EClassComponent
		{
			// Token: 0x0403B9B3 RID: 244147
			BgItem,
			// Token: 0x0403B9B4 RID: 244148
			Texture
		}
	}
}
