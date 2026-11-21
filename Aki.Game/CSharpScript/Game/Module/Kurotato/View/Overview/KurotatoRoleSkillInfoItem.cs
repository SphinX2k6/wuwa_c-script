using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004721 RID: 18209
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoRoleSkillInfoItem : GridProxyAbstract<IKurotatoRoleSkillInfo>
	{
		// Token: 0x0602DBEA RID: 187370 RVA: 0x00CCC030 File Offset: 0x00CCA230
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DBEB RID: 187371 RVA: 0x00CCC078 File Offset: 0x00CCA278
		[NullableContext(1)]
		public override void Refresh(IKurotatoRoleSkillInfo data, bool isSelected, int gridIndex)
		{
			KurotatoProperty value = KurotatoConfig.Instance.GetPropertyById(data.AttrId).Value;
			base.GetText(0).SetText(value.Desc, true);
		}

		// Token: 0x0200A35C RID: 41820
		private enum EChildComp
		{
			// Token: 0x04032A7B RID: 207483
			TextSkillDesc
		}
	}
}
