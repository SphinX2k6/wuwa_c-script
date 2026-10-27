using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060D4 RID: 24788
	public class SolarSpeedRoleIconPanel : UiPanelBase
	{
		// Token: 0x0603EA9E RID: 256670 RVA: 0x00F22827 File Offset: 0x00F20A27
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x0603EA9F RID: 256671 RVA: 0x00F2284C File Offset: 0x00F20A4C
		[NullableContext(1)]
		public void Refresh(ISolarSpeedRoleIconPanelData data)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
		}

		// Token: 0x0200C327 RID: 49959
		private enum ERoleIconComponent
		{
			// Token: 0x0403AECE RID: 241358
			IconTexture
		}
	}
}
