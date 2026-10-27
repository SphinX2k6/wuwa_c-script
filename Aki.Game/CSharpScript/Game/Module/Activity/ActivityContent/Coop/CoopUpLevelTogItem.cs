using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068EB RID: 26859
	public class CoopUpLevelTogItem : UiPanelBase
	{
		// Token: 0x06042FFA RID: 274426 RVA: 0x01051EDC File Offset: 0x010500DC
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

		// Token: 0x06042FFB RID: 274427 RVA: 0x01051F90 File Offset: 0x01050190
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

		// Token: 0x06042FFC RID: 274428 RVA: 0x01051FF3 File Offset: 0x010501F3
		public void SetRomaNumArtTxt(int num)
		{
			base.GetArtText(5).SetText(num.ToString());
			base.GetArtText(6).SetText(num.ToString());
			base.GetArtText(4).SetText(num.ToString());
		}
	}
}
