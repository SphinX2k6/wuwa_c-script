using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050F5 RID: 20725
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeRoleSelectAssistRoleItem : GridProxyAbstract<RoverlikeRoleSelectAssistRoleItemData>
	{
		// Token: 0x06033DE8 RID: 212456 RVA: 0x00E84B44 File Offset: 0x00E82D44
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

		// Token: 0x06033DE9 RID: 212457 RVA: 0x00E84B8C File Offset: 0x00E82D8C
		public override void Refresh(RoverlikeRoleSelectAssistRoleItemData data, bool isSelected, int gridIndex)
		{
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(data.BlessRoleId);
			UUITexture texture = base.GetTexture(0);
			if (blessRoleConfig != null && !string.IsNullOrEmpty(blessRoleConfig.Value.RoleIcon) && texture != null)
			{
				base.SetTextureByPath(blessRoleConfig.Value.RoleIcon, texture, null, null);
			}
		}

		// Token: 0x06033DEA RID: 212458 RVA: 0x00E84BF4 File Offset: 0x00E82DF4
		public override object GetKey(RoverlikeRoleSelectAssistRoleItemData data, int gridIndex)
		{
			return data.BlessRoleId;
		}

		// Token: 0x0200ADC9 RID: 44489
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035B20 RID: 219936
			public const int TexRole = 0;
		}
	}
}
