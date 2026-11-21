using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C8E RID: 15502
	public class LevelShowItem : UiPanelBase
	{
		// Token: 0x06027A85 RID: 162437 RVA: 0x00B1B478 File Offset: 0x00B19678
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06027A86 RID: 162438 RVA: 0x00B1B4D2 File Offset: 0x00B196D2
		[NullableContext(2)]
		public void Refresh(int lvPreUpgrade, int lvUpgrade, string formatId, bool? isMax)
		{
			base.GetArtText(0).SetText(lvPreUpgrade.ToString());
			base.GetArtText(1).SetText(lvUpgrade.ToString());
			base.GetItem(2).SetUIActive(isMax.GetValueOrDefault());
		}

		// Token: 0x02009875 RID: 39029
		private enum ELevelPanelNode
		{
			// Token: 0x0402F89C RID: 194716
			PreUpgradeLevel,
			// Token: 0x0402F89D RID: 194717
			UpgradeLevel,
			// Token: 0x0402F89E RID: 194718
			SpriteMax
		}
	}
}
