using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x02005256 RID: 21078
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballRankRoleHeadItem : GridProxyAbstract<PinballRankRoleHeadData>
	{
		// Token: 0x0603478A RID: 214922 RVA: 0x00EAEEF0 File Offset: 0x00EAD0F0
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

		// Token: 0x0603478B RID: 214923 RVA: 0x00EAEF5C File Offset: 0x00EAD15C
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

		// Token: 0x0200AEAA RID: 44714
		private enum EComponents
		{
			// Token: 0x04035F5F RID: 221023
			TexRoleIcon,
			// Token: 0x04035F60 RID: 221024
			TxtLv
		}
	}
}
