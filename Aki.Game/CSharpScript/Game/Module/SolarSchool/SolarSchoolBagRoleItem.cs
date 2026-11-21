using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005989 RID: 22921
	public class SolarSchoolBagRoleItem : GridProxyAbstract<int>
	{
		// Token: 0x0603883C RID: 231484 RVA: 0x00FCF8B8 File Offset: 0x00FCDAB8
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

		// Token: 0x0603883D RID: 231485 RVA: 0x00FCF900 File Offset: 0x00FCDB00
		public override void Refresh(int roleId, bool isSelected, int gridIndex)
		{
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(roleId);
			if (role == null)
			{
				return;
			}
			base.SetTextureByPath(role.Value.HeadIcon, base.GetTexture(0), null, null);
		}

		// Token: 0x0603883E RID: 231486 RVA: 0x00FCF949 File Offset: 0x00FCDB49
		[NullableContext(1)]
		public override object GetKey(int roleId, int displayIndex)
		{
			return roleId;
		}

		// Token: 0x0200B52B RID: 46379
		private class EComponents
		{
			// Token: 0x0403802D RID: 229421
			public const int TexHead = 0;
		}
	}
}
