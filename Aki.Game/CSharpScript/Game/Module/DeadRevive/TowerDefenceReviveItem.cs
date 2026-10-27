using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005ACF RID: 23247
	public class TowerDefenceReviveItem : UiPanelBase
	{
		// Token: 0x0603AE05 RID: 241157 RVA: 0x00E09878 File Offset: 0x00E07A78
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

		// Token: 0x0603AE06 RID: 241158 RVA: 0x00E098C0 File Offset: 0x00E07AC0
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "TowerDefence_end", Array.Empty<object>());
		}

		// Token: 0x0401EB9B RID: 125851
		[Nullable(1)]
		private const string BUTTON_TEXT_ID = "TowerDefence_end";

		// Token: 0x0200BD22 RID: 48418
		private class EItemComponent
		{
			// Token: 0x040390B6 RID: 233654
			public const int ButtonText = 1;
		}
	}
}
