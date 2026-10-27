using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C29 RID: 23593
	public class BossPilingFetterItem : UiPanelBase
	{
		// Token: 0x0603B98E RID: 244110 RVA: 0x00E379E8 File Offset: 0x00E35BE8
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

		// Token: 0x0603B98F RID: 244111 RVA: 0x00E37A54 File Offset: 0x00E35C54
		public void Refresh(int id)
		{
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(id);
			if (elementConfig == null)
			{
				return;
			}
			FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
			base.GetSprite(0).SetColor(color);
			base.SetTextureByPath(elementConfig.Value.Icon5, base.GetTexture(1), null, null);
		}

		// Token: 0x0200BE13 RID: 48659
		private enum EFetter
		{
			// Token: 0x0403951B RID: 234779
			Sprite,
			// Token: 0x0403951C RID: 234780
			Tex
		}
	}
}
