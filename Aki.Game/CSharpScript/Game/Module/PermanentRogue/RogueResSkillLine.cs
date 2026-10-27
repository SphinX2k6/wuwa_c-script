using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200532E RID: 21294
	public class RogueResSkillLine : UiPanelBase
	{
		// Token: 0x06036711 RID: 222993 RVA: 0x00CE35CC File Offset: 0x00CE17CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite))
			};
		}

		// Token: 0x06036712 RID: 222994 RVA: 0x00CE3654 File Offset: 0x00CE1854
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
	}
}
