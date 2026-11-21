using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005052 RID: 20562
	public class SolarSpeedRoleIconPanel : UiPanelBase
	{
		// Token: 0x06033762 RID: 210786 RVA: 0x00E695EF File Offset: 0x00E677EF
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x06033763 RID: 210787 RVA: 0x00E69614 File Offset: 0x00E67814
		[NullableContext(1)]
		public void Refresh(ISolarSpeedRoleIconPanelData data)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
		}

		// Token: 0x0200AD12 RID: 44306
		private enum ERoleIconComponent
		{
			// Token: 0x04035836 RID: 219190
			IconTexture
		}
	}
}
