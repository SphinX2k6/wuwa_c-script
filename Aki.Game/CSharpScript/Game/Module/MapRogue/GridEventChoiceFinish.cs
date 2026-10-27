using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055D5 RID: 21973
	public class GridEventChoiceFinish : UiPanelBase
	{
		// Token: 0x06037FE9 RID: 229353 RVA: 0x00D435E8 File Offset: 0x00D417E8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggleSpriteTransition)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06037FEA RID: 229354 RVA: 0x00D43658 File Offset: 0x00D41858
		[NullableContext(1)]
		public void Refresh(IToggleItemData data)
		{
			UUIText text = base.GetText(0);
			if (!StringUtils.IsEmpty(data.Icon))
			{
				UUISprite spriteIcon = base.GetSprite(1);
				this.SetSpriteByPath(data.Icon, spriteIcon, false, null, delegate(bool _)
				{
					this.GetUiExtendToggleSpriteTransition(2).SetAllStateSprite(spriteIcon.GetSprite());
				});
			}
			LguiUtil.Instance.SetLocalTextNew(text, data.TitleId, Array.Empty<object>());
		}
	}
}
