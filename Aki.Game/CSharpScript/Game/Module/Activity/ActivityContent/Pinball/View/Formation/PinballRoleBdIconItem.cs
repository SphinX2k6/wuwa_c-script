using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052EE RID: 21230
	public class PinballRoleBdIconItem : UiPanelBase
	{
		// Token: 0x06034D4D RID: 216397 RVA: 0x00EC4CF4 File Offset: 0x00EC2EF4
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

		// Token: 0x06034D4E RID: 216398 RVA: 0x00EC4D60 File Offset: 0x00EC2F60
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

		// Token: 0x0200AF72 RID: 44914
		private enum EComponent
		{
			// Token: 0x04036372 RID: 222066
			BgSprite,
			// Token: 0x04036373 RID: 222067
			BdTexture
		}
	}
}
