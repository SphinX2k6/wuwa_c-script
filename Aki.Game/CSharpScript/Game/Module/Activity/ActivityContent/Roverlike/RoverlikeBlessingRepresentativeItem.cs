using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005096 RID: 20630
	public class RoverlikeBlessingRepresentativeItem : UiPanelBase
	{
		// Token: 0x06033A55 RID: 211541 RVA: 0x00E74EAC File Offset: 0x00E730AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033A56 RID: 211542 RVA: 0x00E74EF4 File Offset: 0x00E730F4
		public void Refresh(int roleId)
		{
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(roleId);
			if (blessRoleConfig == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(blessRoleConfig.Value.IconPath, base.GetTexture(0), null);
		}

		// Token: 0x0200AD5C RID: 44380
		private class EComponents
		{
			// Token: 0x04035924 RID: 219428
			public const int TextureIcon = 0;
		}
	}
}
