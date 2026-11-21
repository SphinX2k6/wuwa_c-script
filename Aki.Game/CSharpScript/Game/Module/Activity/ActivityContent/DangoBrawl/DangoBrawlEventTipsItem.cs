using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005766 RID: 22374
	public class DangoBrawlEventTipsItem : UiPanelBase
	{
		// Token: 0x060372FD RID: 226045 RVA: 0x00F67B78 File Offset: 0x00F65D78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060372FE RID: 226046 RVA: 0x00F67C04 File Offset: 0x00F65E04
		public void Refresh(int eventId)
		{
			DangoBrawlShopEvt value = DangoBrawlConfig.Instance.GetShopEvtConfigById(eventId).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Desc, Array.Empty<object>());
		}

		// Token: 0x0200B372 RID: 45938
		private enum EComponents
		{
			// Token: 0x04037764 RID: 227172
			TexIcon,
			// Token: 0x04037765 RID: 227173
			TxtTitle,
			// Token: 0x04037766 RID: 227174
			TxtDesc
		}
	}
}
