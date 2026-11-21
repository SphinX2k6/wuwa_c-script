using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004708 RID: 18184
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AttributeItem : GridProxyAbstract<IKurotatoRoleSkillInfo>
	{
		// Token: 0x0602DB06 RID: 187142 RVA: 0x00CC6ADC File Offset: 0x00CC4CDC
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DB07 RID: 187143 RVA: 0x00CC6B68 File Offset: 0x00CC4D68
		[NullableContext(1)]
		public override void Refresh(IKurotatoRoleSkillInfo data, bool isSelected, int gridIndex)
		{
			KurotatoProperty value = KurotatoConfig.Instance.GetPropertyById(data.AttrId).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(0), null, null);
			base.GetText(1).ShowTextNew(value.ShowName);
			base.GetText(2).SetText(KurotatoUtil.GetPropertyShowValue(data.AttrId, (float)data.Value), true);
		}

		// Token: 0x0200A324 RID: 41764
		private class EAttributeComps
		{
			// Token: 0x04032963 RID: 207203
			public const int TextureIcon = 0;

			// Token: 0x04032964 RID: 207204
			public const int TextName = 1;

			// Token: 0x04032965 RID: 207205
			public const int TextValue = 2;
		}
	}
}
