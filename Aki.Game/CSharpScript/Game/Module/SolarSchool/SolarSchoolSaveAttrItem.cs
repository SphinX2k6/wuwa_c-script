using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A03 RID: 23043
	public class SolarSchoolSaveAttrItem : GridProxyAbstract<SolarSchoolSaveAttrData>
	{
		// Token: 0x06038BDE RID: 232414 RVA: 0x00FE1908 File Offset: 0x00FDFB08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038BDF RID: 232415 RVA: 0x00FE1974 File Offset: 0x00FDFB74
		public override void Refresh(SolarSchoolSaveAttrData data, bool isSelected, int gridIndex)
		{
			SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(data.ActivityId, (int)data.Attr);
			if (solarSchoolAttr == null)
			{
				return;
			}
			SolarSchoolAttr value = solarSchoolAttr.Value;
			base.SetTextureByPath(value.YellowIconSmall, base.GetTexture(0), null, null);
			int num = SolarSchoolUtils.CalcAttrRankTier(value, data.Value);
			base.TrySetTextureByPath((num < value.RankIconLength) ? value.RankIcon(num) : null, base.GetTexture(1), null, null);
		}

		// Token: 0x0200B5B1 RID: 46513
		private class EComponents
		{
			// Token: 0x040382F3 RID: 230131
			public const int TexIcon = 0;

			// Token: 0x040382F4 RID: 230132
			public const int TexLevel = 1;
		}
	}
}
