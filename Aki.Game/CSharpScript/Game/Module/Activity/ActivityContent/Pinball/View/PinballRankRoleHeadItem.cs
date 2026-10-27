using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062D8 RID: 25304
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballRankRoleHeadItem : GridProxyAbstract<PinballRankRoleHeadData>
	{
		// Token: 0x0603FAC9 RID: 260809 RVA: 0x00F67F94 File Offset: 0x00F66194
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FACA RID: 260810 RVA: 0x00F68000 File Offset: 0x00F66200
		[NullableContext(1)]
		public override void Refresh(PinballRankRoleHeadData data, bool isSelected, int gridIndex)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(data.RoleId);
			if (pinballRoleConfigById != null)
			{
				base.SetTextureByPath(pinballRoleConfigById.Value.MiddleIcon, base.GetTexture(0), null, null);
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Level);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0200C4C3 RID: 50371
		private enum EComponents
		{
			// Token: 0x0403B5FD RID: 243197
			TexRoleIcon,
			// Token: 0x0403B5FE RID: 243198
			TxtLv
		}
	}
}
