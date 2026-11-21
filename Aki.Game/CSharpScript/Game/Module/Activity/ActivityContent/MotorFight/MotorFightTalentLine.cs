using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200539A RID: 21402
	public class MotorFightTalentLine : UiPanelBase
	{
		// Token: 0x060353F4 RID: 218100 RVA: 0x00EDF5EC File Offset: 0x00EDD7EC
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

		// Token: 0x060353F5 RID: 218101 RVA: 0x00EDF655 File Offset: 0x00EDD855
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

		// Token: 0x0200B02E RID: 45102
		private class EMotorFightTalentLineDefine
		{
			// Token: 0x0403672A RID: 223018
			public const int SpriteLine = 0;

			// Token: 0x0403672B RID: 223019
			public const int SpriteDotLine = 1;
		}
	}
}
