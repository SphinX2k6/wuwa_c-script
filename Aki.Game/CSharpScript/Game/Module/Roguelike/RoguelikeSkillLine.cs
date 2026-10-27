using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E2C RID: 20012
	public class RoguelikeSkillLine : UiPanelBase
	{
		// Token: 0x060339AE RID: 211374 RVA: 0x00C13118 File Offset: 0x00C11318
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060339AF RID: 211375 RVA: 0x00C131E4 File Offset: 0x00C113E4
		public void Refresh(bool isUnlock, int offset, int pos)
		{
			if (isUnlock)
			{
				base.GetSprite(4).SetColor(FColor.FromHex("AA9B6AFF"));
			}
			else
			{
				base.GetSprite(4).SetColor(FColor.FromHex("43434380"));
			}
			base.GetItem(0).SetUIActive(offset == 0);
			base.GetItem(3).SetUIActive(pos == 1 && offset == 1);
			base.GetItem(2).SetUIActive(pos == 1 && offset == -1);
		}

		// Token: 0x0200AFDB RID: 45019
		public static class ERoguelikeSkillLineDefine
		{
			// Token: 0x04035636 RID: 218678
			public const int RightItem = 0;

			// Token: 0x04035637 RID: 218679
			public const int LeftItem = 1;

			// Token: 0x04035638 RID: 218680
			public const int UpItem = 2;

			// Token: 0x04035639 RID: 218681
			public const int DownItem = 3;

			// Token: 0x0403563A RID: 218682
			public const int SpriteLine = 4;
		}
	}
}
