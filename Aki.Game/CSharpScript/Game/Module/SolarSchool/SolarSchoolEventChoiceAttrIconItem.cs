using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005903 RID: 22787
	public class SolarSchoolEventChoiceAttrIconItem : GridProxyAbstract<int>
	{
		// Token: 0x060382D4 RID: 230100 RVA: 0x00FB42D8 File Offset: 0x00FB24D8
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

		// Token: 0x060382D5 RID: 230101 RVA: 0x00FB4320 File Offset: 0x00FB2520
		public override void Refresh(int attrId, bool isSelected, int gridIndex)
		{
			SolarSchoolAttr? attr = SolarSchoolConfig.Instance.GetAttr(attrId);
			if (attr == null)
			{
				return;
			}
			base.SetTextureByPath(attr.Value.YellowIconSmall, base.GetTexture(0), null, null);
		}

		// Token: 0x0200B4C0 RID: 46272
		private class EComponents
		{
			// Token: 0x04037E40 RID: 228928
			public const int TexAttrIcon = 0;
		}
	}
}
