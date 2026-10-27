using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006816 RID: 26646
	public class DangoBrawlEventTipsItem : UiPanelBase
	{
		// Token: 0x060427A8 RID: 272296 RVA: 0x01026634 File Offset: 0x01024834
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

		// Token: 0x060427A9 RID: 272297 RVA: 0x010266C0 File Offset: 0x010248C0
		public void Refresh(int eventId)
		{
			DangoBrawlShopEvt value = DangoBrawlConfig.Instance.GetShopEvtConfigById(eventId).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Desc, Array.Empty<object>());
		}

		// Token: 0x0200C9A5 RID: 51621
		private enum EComponents
		{
			// Token: 0x0403CE77 RID: 249463
			TexIcon,
			// Token: 0x0403CE78 RID: 249464
			TxtTitle,
			// Token: 0x0403CE79 RID: 249465
			TxtDesc
		}
	}
}
