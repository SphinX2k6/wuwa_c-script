using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052D8 RID: 21208
	internal class ClassComponent : UiPanelBase
	{
		// Token: 0x06034CC4 RID: 216260 RVA: 0x00EC28E4 File Offset: 0x00EC0AE4
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

		// Token: 0x06034CC5 RID: 216261 RVA: 0x00EC2950 File Offset: 0x00EC0B50
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

		// Token: 0x0200AF63 RID: 44899
		private enum EClassComponent
		{
			// Token: 0x04036315 RID: 221973
			BgItem,
			// Token: 0x04036316 RID: 221974
			Texture
		}
	}
}
