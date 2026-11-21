using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FD7 RID: 12247
	public class TetrisRewardTipPanel : UiPanelBase
	{
		// Token: 0x0601D142 RID: 119106 RVA: 0x008E33A0 File Offset: 0x008E15A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D143 RID: 119107 RVA: 0x008E3409 File Offset: 0x008E1609
		public void SetTargetText(int target)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Tetris2UIText_003", new <>z__ReadOnlySingleElementList<object>(target));
		}

		// Token: 0x0601D144 RID: 119108 RVA: 0x008E342C File Offset: 0x008E162C
		public void SetTargetCompleted(bool isCompleted)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isCompleted);
		}

		// Token: 0x02008C58 RID: 35928
		private static class EComponents
		{
			// Token: 0x0402C6BB RID: 181947
			public const int SprFinish = 0;

			// Token: 0x0402C6BC RID: 181948
			public const int TxtTitle = 1;
		}
	}
}
