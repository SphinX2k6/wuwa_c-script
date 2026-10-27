using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200641C RID: 25628
	public class MotorFightTalentLine : UiPanelBase
	{
		// Token: 0x06040733 RID: 263987 RVA: 0x00F9864C File Offset: 0x00F9684C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040734 RID: 263988 RVA: 0x00F986B5 File Offset: 0x00F968B5
		public void Refresh(bool isUnlock)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(isUnlock);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(!isUnlock);
		}

		// Token: 0x0200C647 RID: 50759
		private class EMotorFightTalentLineDefine
		{
			// Token: 0x0403BDCD RID: 245197
			public const int SpriteLine = 0;

			// Token: 0x0403BDCE RID: 245198
			public const int SpriteDotLine = 1;
		}
	}
}
