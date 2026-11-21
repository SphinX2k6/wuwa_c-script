using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02003765 RID: 14181
	public class WorldMapChangeGravityButtonItem : UiPanelBase
	{
		// Token: 0x06024DDF RID: 151007 RVA: 0x00A6B4C0 File Offset: 0x00A696C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISpriteTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024DE0 RID: 151008 RVA: 0x00A6B5A8 File Offset: 0x00A697A8
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06024DE1 RID: 151009 RVA: 0x00A6B5BA File Offset: 0x00A697BA
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x06024DE2 RID: 151010 RVA: 0x00A6B5CE File Offset: 0x00A697CE
		[NullableContext(1)]
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06024DE3 RID: 151011 RVA: 0x00A6B5D8 File Offset: 0x00A697D8
		[NullableContext(1)]
		public void SetSprite(string path)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetUIActive(false);
			this.SetSpriteByPath(path, sprite, false, null, delegate(bool success)
			{
				this.GetUiSpriteTransition(3).SetAllTransitionSprite(sprite.GetSprite());
				sprite.SetUIActive(success);
			});
		}

		// Token: 0x040146EE RID: 83694
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x020094BF RID: 38079
		public static class EButtonItemDefine
		{
			// Token: 0x0402E759 RID: 190297
			public const int Button = 0;

			// Token: 0x0402E75A RID: 190298
			public const int Sprite = 1;

			// Token: 0x0402E75B RID: 190299
			public const int Text = 2;

			// Token: 0x0402E75C RID: 190300
			public const int SpriteTransition = 3;
		}
	}
}
