using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005628 RID: 22056
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentDescription : UiPanelBase
	{
		// Token: 0x060381C5 RID: 229829 RVA: 0x00D4AD99 File Offset: 0x00D48F99
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x060381C6 RID: 229830 RVA: 0x00D4ADBC File Offset: 0x00D48FBC
		public void SetDescriptionByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x060381C7 RID: 229831 RVA: 0x00D4ADD1 File Offset: 0x00D48FD1
		public void SetDescriptionByText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x060381C8 RID: 229832 RVA: 0x00D4ADE1 File Offset: 0x00D48FE1
		public void SetDescriptionVisible(bool bVisible)
		{
			base.GetText(1).SetUIActive(bVisible);
		}
	}
}
