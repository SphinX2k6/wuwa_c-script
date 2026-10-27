using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005636 RID: 22070
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentRecommendTip : UiPanelBase
	{
		// Token: 0x060381EE RID: 229870 RVA: 0x00D4B3CE File Offset: 0x00D495CE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x060381EF RID: 229871 RVA: 0x00D4B408 File Offset: 0x00D49608
		public void SetTextChangeColor(bool bUseChange)
		{
			UUIItem sprite = base.GetSprite(1);
			FColor? fcolor = new FColor?(base.GetSprite(1).changeColor);
			sprite.SetChangeColor(bUseChange, fcolor);
		}

		// Token: 0x060381F0 RID: 229872 RVA: 0x00D4B436 File Offset: 0x00D49636
		public void SetDescriptionByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x060381F1 RID: 229873 RVA: 0x00D4B44B File Offset: 0x00D4964B
		public void SetDescriptionByText(string text)
		{
			base.GetText(0).SetText(text, true);
		}
	}
}
