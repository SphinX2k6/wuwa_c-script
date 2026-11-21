using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004EBD RID: 20157
	public class RoleItem : GridProxyAbstract<int>
	{
		// Token: 0x06032B21 RID: 207649 RVA: 0x00E3A2E0 File Offset: 0x00E384E0
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

		// Token: 0x06032B22 RID: 207650 RVA: 0x00E3A328 File Offset: 0x00E38528
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
