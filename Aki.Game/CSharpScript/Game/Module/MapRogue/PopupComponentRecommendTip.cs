using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200460C RID: 17932
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentRecommendTip : UiPanelBase
	{
		// Token: 0x0602D0EC RID: 184556 RVA: 0x00C99116 File Offset: 0x00C97316
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0602D0ED RID: 184557 RVA: 0x00C99150 File Offset: 0x00C97350
		public void SetTextChangeColor(bool bUseChange)
		{
			UUIItem sprite = base.GetSprite(1);
			FColor? fcolor = new FColor?(base.GetSprite(1).changeColor);
			sprite.SetChangeColor(bUseChange, fcolor);
		}

		// Token: 0x0602D0EE RID: 184558 RVA: 0x00C9917E File Offset: 0x00C9737E
		public void SetDescriptionByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x0602D0EF RID: 184559 RVA: 0x00C99193 File Offset: 0x00C97393
		public void SetDescriptionByText(string text)
		{
			base.GetText(0).SetText(text, true);
		}
	}
}
