using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02005779 RID: 22393
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class WeaponAttrInfoItem : SyncGridProxyAbstract<IKurotatoAttrDisplay>
	{
		// Token: 0x06038E48 RID: 233032 RVA: 0x00D85A98 File Offset: 0x00D83C98
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038E49 RID: 233033 RVA: 0x00D85B04 File Offset: 0x00D83D04
		[NullableContext(1)]
		public override void Refresh(IKurotatoAttrDisplay data)
		{
			KurotatoProperty? propertyById = KurotatoConfig.Instance.GetPropertyById(data.PropertyId);
			if (propertyById != null)
			{
				base.GetText(0).ShowTextNew(propertyById.Value.ShowName);
			}
			else
			{
				base.GetText(0).SetText("", true);
			}
			base.GetText(1).SetText(data.Text, true);
		}

		// Token: 0x0200B996 RID: 47510
		private class EWeaponAttrInfoComp
		{
			// Token: 0x040381E9 RID: 229865
			public const int TextTitle = 0;

			// Token: 0x040381EA RID: 229866
			public const int ItemAttrInfo = 1;
		}
	}
}
