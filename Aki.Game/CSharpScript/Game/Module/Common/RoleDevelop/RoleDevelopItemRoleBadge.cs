using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.RoleDevelop
{
	// Token: 0x02005B4D RID: 23373
	public class RoleDevelopItemRoleBadge : UiPanelBase
	{
		// Token: 0x0603B2C3 RID: 242371 RVA: 0x00E1BD44 File Offset: 0x00E19F44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B2C4 RID: 242372 RVA: 0x00E1BDD0 File Offset: 0x00E19FD0
		[NullableContext(1)]
		public void SetRoleHeadIconPath(string iconPath)
		{
			if (StringUtils.IsEmpty(iconPath))
			{
				return;
			}
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			base.SetTextureByPath(iconPath, texture, null, null);
		}
	}
}
