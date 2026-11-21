using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AB0 RID: 19120
	public class TowerDefenceReviveItem : UiPanelBase
	{
		// Token: 0x0602FD77 RID: 195959 RVA: 0x00D5A558 File Offset: 0x00D58758
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FD78 RID: 195960 RVA: 0x00D5A5A0 File Offset: 0x00D587A0
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "TowerDefence_end", Array.Empty<object>());
		}

		// Token: 0x04019657 RID: 104023
		[Nullable(1)]
		private const string BUTTON_TEXT_ID = "TowerDefence_end";

		// Token: 0x0200A72A RID: 42794
		private class EItemComponent
		{
			// Token: 0x04033A80 RID: 211584
			public const int ButtonText = 1;
		}
	}
}
