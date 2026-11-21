using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005996 RID: 22934
	public class SolarSchoolFatigueStateItem : UiPanelBase
	{
		// Token: 0x060388E4 RID: 231652 RVA: 0x00FD2C08 File Offset: 0x00FD0E08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060388E5 RID: 231653 RVA: 0x00FD2C94 File Offset: 0x00FD0E94
		public void SetStage(ESolarSchoolFatigueStage stage)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(stage == ESolarSchoolFatigueStage.Healthy);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(stage == ESolarSchoolFatigueStage.Tired);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(stage == ESolarSchoolFatigueStage.Sick);
		}

		// Token: 0x0200B53F RID: 46399
		private class EComponents
		{
			// Token: 0x040380A3 RID: 229539
			public const int PnlStateA = 0;

			// Token: 0x040380A4 RID: 229540
			public const int PnlStateB = 1;

			// Token: 0x040380A5 RID: 229541
			public const int PnlStateC = 2;
		}
	}
}
