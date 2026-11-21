using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.RoleDevelop
{
	// Token: 0x02004B2C RID: 19244
	public class RoleDevelopItemRoleBadge : UiPanelBase
	{
		// Token: 0x0603020C RID: 197132 RVA: 0x00D6C18C File Offset: 0x00D6A38C
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

		// Token: 0x0603020D RID: 197133 RVA: 0x00D6C218 File Offset: 0x00D6A418
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
