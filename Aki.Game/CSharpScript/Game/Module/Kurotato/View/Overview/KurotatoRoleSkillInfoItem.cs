using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x0200574A RID: 22346
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoRoleSkillInfoItem : GridProxyAbstract<IKurotatoRoleSkillInfo>
	{
		// Token: 0x06038CDA RID: 232666 RVA: 0x00D7D774 File Offset: 0x00D7B974
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

		// Token: 0x06038CDB RID: 232667 RVA: 0x00D7D7BC File Offset: 0x00D7B9BC
		[NullableContext(1)]
		public override void Refresh(IKurotatoRoleSkillInfo data, bool isSelected, int gridIndex)
		{
			KurotatoProperty value = KurotatoConfig.Instance.GetPropertyById(data.AttrId).Value;
			base.GetText(0).SetText(value.Desc, true);
		}

		// Token: 0x0200B93D RID: 47421
		private enum EChildComp
		{
			// Token: 0x04038071 RID: 229489
			TextSkillDesc
		}
	}
}
