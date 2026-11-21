using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x0200583B RID: 22587
	public class CoopUpLevelTogItem : UiPanelBase
	{
		// Token: 0x06037B52 RID: 228178 RVA: 0x00F93504 File Offset: 0x00F91704
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIArtText)),
				new ValueTuple<int, Type>(5, typeof(UUIArtText)),
				new ValueTuple<int, Type>(6, typeof(UUIArtText))
			};
		}

		// Token: 0x06037B53 RID: 228179 RVA: 0x00F935B8 File Offset: 0x00F917B8
		[NullableContext(1)]
		public void RefreshView(CoopLevelData levelData)
		{
			ECoopLevelStatus state = levelData.State;
			base.GetItem(3).SetUIActive(state == ECoopLevelStatus.Doing);
			base.GetItem(0).SetUIActive(state == ECoopLevelStatus.Doing);
			base.GetItem(1).SetUIActive(state == ECoopLevelStatus.Lock);
			base.GetItem(2).SetUIActive(state >= ECoopLevelStatus.Reward);
			this.SetRomaNumArtTxt(levelData.Level);
		}

		// Token: 0x06037B54 RID: 228180 RVA: 0x00F9361B File Offset: 0x00F9181B
		public void SetRomaNumArtTxt(int num)
		{
			base.GetArtText(5).SetText(num.ToString());
			base.GetArtText(6).SetText(num.ToString());
			base.GetArtText(4).SetText(num.ToString());
		}
	}
}
