using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200562C RID: 22060
	public class PopupComponentInfoItem : UiPanelBase
	{
		// Token: 0x060381CF RID: 229839 RVA: 0x00D4AF34 File Offset: 0x00D49134
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x060381D0 RID: 229840 RVA: 0x00D4AF90 File Offset: 0x00D49190
		[NullableContext(1)]
		public void Refresh(string titleId, int itemId, string valueTxt)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), titleId, Array.Empty<object>());
			base.SetItemIcon(base.GetTexture(1), itemId, null, null);
			base.GetText(2).SetText(valueTxt, true);
		}
	}
}
