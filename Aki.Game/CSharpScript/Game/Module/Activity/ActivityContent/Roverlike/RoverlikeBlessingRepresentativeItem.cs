using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006118 RID: 24856
	public class RoverlikeBlessingRepresentativeItem : UiPanelBase
	{
		// Token: 0x0603ED93 RID: 257427 RVA: 0x00F2E098 File Offset: 0x00F2C298
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

		// Token: 0x0603ED94 RID: 257428 RVA: 0x00F2E0E0 File Offset: 0x00F2C2E0
		public void Refresh(int roleId)
		{
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(roleId);
			if (blessRoleConfig == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(blessRoleConfig.Value.IconPath, base.GetTexture(0), null);
		}

		// Token: 0x0200C374 RID: 50036
		private class EComponents
		{
			// Token: 0x0403AFBF RID: 241599
			public const int TextureIcon = 0;
		}
	}
}
