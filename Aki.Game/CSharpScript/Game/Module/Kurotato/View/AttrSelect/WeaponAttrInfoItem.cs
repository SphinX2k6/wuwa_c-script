using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004750 RID: 18256
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class WeaponAttrInfoItem : SyncGridProxyAbstract<IKurotatoAttrDisplay>
	{
		// Token: 0x0602DD58 RID: 187736 RVA: 0x00CD4758 File Offset: 0x00CD2958
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

		// Token: 0x0602DD59 RID: 187737 RVA: 0x00CD47C4 File Offset: 0x00CD29C4
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

		// Token: 0x0200A3AE RID: 41902
		private class EWeaponAttrInfoComp
		{
			// Token: 0x04032BDE RID: 207838
			public const int TextTitle = 0;

			// Token: 0x04032BDF RID: 207839
			public const int ItemAttrInfo = 1;
		}
	}
}
