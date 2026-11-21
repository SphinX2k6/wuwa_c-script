using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D05 RID: 15621
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectOverviewPhantomElementItem : GridProxyAbstract<RoleDevelopPhantomElementData>
	{
		// Token: 0x06027FC9 RID: 163785 RVA: 0x00B30580 File Offset: 0x00B2E780
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027FCA RID: 163786 RVA: 0x00B3060C File Offset: 0x00B2E80C
		[NullableContext(1)]
		public override void Refresh(RoleDevelopPhantomElementData data, bool isSelected, int gridIndex)
		{
			base.TrySetTextureByPath(PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterGroupId).FetterElementPath, base.GetTexture(0), null, null);
			base.GetText(1).SetText(data.Count.ToString(), true);
			base.GetItem(2).SetUIActive(data.ShowAdd);
		}

		// Token: 0x020098CD RID: 39117
		private enum EComponentType
		{
			// Token: 0x0402FA61 RID: 195169
			ElementIconTexture,
			// Token: 0x0402FA62 RID: 195170
			CounterText,
			// Token: 0x0402FA63 RID: 195171
			AddItem
		}
	}
}
