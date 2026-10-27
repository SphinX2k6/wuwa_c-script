using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006177 RID: 24951
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeRoleSelectAssistRoleItem : GridProxyAbstract<RoverlikeRoleSelectAssistRoleItemData>
	{
		// Token: 0x0603F128 RID: 258344 RVA: 0x00F3DC7C File Offset: 0x00F3BE7C
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

		// Token: 0x0603F129 RID: 258345 RVA: 0x00F3DCC4 File Offset: 0x00F3BEC4
		public override void Refresh(RoverlikeRoleSelectAssistRoleItemData data, bool isSelected, int gridIndex)
		{
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(data.BlessRoleId);
			UUITexture texture = base.GetTexture(0);
			if (blessRoleConfig != null && !string.IsNullOrEmpty(blessRoleConfig.Value.RoleIcon) && texture != null)
			{
				base.SetTextureByPath(blessRoleConfig.Value.RoleIcon, texture, null, null);
			}
		}

		// Token: 0x0603F12A RID: 258346 RVA: 0x00F3DD2C File Offset: 0x00F3BF2C
		public override object GetKey(RoverlikeRoleSelectAssistRoleItemData data, int gridIndex)
		{
			return data.BlessRoleId;
		}

		// Token: 0x0200C3E2 RID: 50146
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B1BF RID: 242111
			public const int TexRole = 0;
		}
	}
}
