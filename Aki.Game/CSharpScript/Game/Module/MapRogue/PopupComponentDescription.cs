using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045FE RID: 17918
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentDescription : UiPanelBase
	{
		// Token: 0x0602D0C3 RID: 184515 RVA: 0x00C98AE1 File Offset: 0x00C96CE1
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602D0C4 RID: 184516 RVA: 0x00C98B04 File Offset: 0x00C96D04
		public void SetDescriptionByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0602D0C5 RID: 184517 RVA: 0x00C98B19 File Offset: 0x00C96D19
		public void SetDescriptionByText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0602D0C6 RID: 184518 RVA: 0x00C98B29 File Offset: 0x00C96D29
		public void SetDescriptionVisible(bool bVisible)
		{
			base.GetText(1).SetUIActive(bVisible);
		}
	}
}
