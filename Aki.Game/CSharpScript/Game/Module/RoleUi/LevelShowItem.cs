using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CDC RID: 19676
	public class LevelShowItem : UiPanelBase
	{
		// Token: 0x06032CB0 RID: 208048 RVA: 0x00BD5D70 File Offset: 0x00BD3F70
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06032CB1 RID: 208049 RVA: 0x00BD5DCA File Offset: 0x00BD3FCA
		[NullableContext(2)]
		public void Refresh(int lvPreUpgrade, int lvUpgrade, string formatId, bool? isMax)
		{
			base.GetArtText(0).SetText(lvPreUpgrade.ToString());
			base.GetArtText(1).SetText(lvUpgrade.ToString());
			base.GetItem(2).SetUIActive(isMax.GetValueOrDefault());
		}

		// Token: 0x0200AE56 RID: 44630
		private enum ELevelPanelNode
		{
			// Token: 0x04034EF4 RID: 216820
			PreUpgradeLevel,
			// Token: 0x04034EF5 RID: 216821
			UpgradeLevel,
			// Token: 0x04034EF6 RID: 216822
			SpriteMax
		}
	}
}
