using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B5A RID: 19290
	public class TowerDefensePhantomLockItem : UiPanelBase
	{
		// Token: 0x06031F2D RID: 204589 RVA: 0x00B97560 File Offset: 0x00B95760
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F2E RID: 204590 RVA: 0x00B975EC File Offset: 0x00B957EC
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(false);
		}

		// Token: 0x06031F2F RID: 204591 RVA: 0x00B9761D File Offset: 0x00B9581D
		[NullableContext(1)]
		public void SetText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x0200ACE3 RID: 44259
		private class ELockItemComponent
		{
			// Token: 0x0403488C RID: 215180
			public const int LockSprite = 0;

			// Token: 0x0403488D RID: 215181
			public const int ActiveText = 1;

			// Token: 0x0403488E RID: 215182
			public const int FunctionButton = 2;
		}
	}
}
