using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004602 RID: 17922
	public class PopupComponentInfoItem : UiPanelBase
	{
		// Token: 0x0602D0CD RID: 184525 RVA: 0x00C98C7C File Offset: 0x00C96E7C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602D0CE RID: 184526 RVA: 0x00C98CD8 File Offset: 0x00C96ED8
		[NullableContext(1)]
		public void Refresh(string titleId, int itemId, string valueTxt)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), titleId, Array.Empty<object>());
			base.SetItemIcon(base.GetTexture(1), itemId, null, null);
			base.GetText(2).SetText(valueTxt, true);
		}
	}
}
