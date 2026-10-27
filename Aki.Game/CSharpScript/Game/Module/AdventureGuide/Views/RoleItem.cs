using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02005ED6 RID: 24278
	public class RoleItem : GridProxyAbstract<int>
	{
		// Token: 0x0603DB8F RID: 252815 RVA: 0x00EE8B08 File Offset: 0x00EE6D08
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

		// Token: 0x0603DB90 RID: 252816 RVA: 0x00EE8B50 File Offset: 0x00EE6D50
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(data);
			if (roleConfig == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(roleConfig.Value.RoleHeadIcon, base.GetTexture(0), null);
		}
	}
}
