using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DF5 RID: 15861
	public class RoguelikeSkillLine : UiPanelBase
	{
		// Token: 0x06028819 RID: 165913 RVA: 0x00B5C64C File Offset: 0x00B5A84C
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

		// Token: 0x0602881A RID: 165914 RVA: 0x00B5C718 File Offset: 0x00B5A918
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

		// Token: 0x02009A0D RID: 39437
		public static class ERoguelikeSkillLineDefine
		{
			// Token: 0x04030066 RID: 196710
			public const int RightItem = 0;

			// Token: 0x04030067 RID: 196711
			public const int LeftItem = 1;

			// Token: 0x04030068 RID: 196712
			public const int UpItem = 2;

			// Token: 0x04030069 RID: 196713
			public const int DownItem = 3;

			// Token: 0x0403006A RID: 196714
			public const int SpriteLine = 4;
		}
	}
}
