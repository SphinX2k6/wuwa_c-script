using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B02 RID: 15106
	public class TowerDefensePhantomLockItem : UiPanelBase
	{
		// Token: 0x06026CBC RID: 158908 RVA: 0x00ADB79C File Offset: 0x00AD999C
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

		// Token: 0x06026CBD RID: 158909 RVA: 0x00ADB828 File Offset: 0x00AD9A28
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

		// Token: 0x06026CBE RID: 158910 RVA: 0x00ADB859 File Offset: 0x00AD9A59
		[NullableContext(1)]
		public void SetText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x02009702 RID: 38658
		private class ELockItemComponent
		{
			// Token: 0x0402F235 RID: 193077
			public const int LockSprite = 0;

			// Token: 0x0402F236 RID: 193078
			public const int ActiveText = 1;

			// Token: 0x0402F237 RID: 193079
			public const int FunctionButton = 2;
		}
	}
}
