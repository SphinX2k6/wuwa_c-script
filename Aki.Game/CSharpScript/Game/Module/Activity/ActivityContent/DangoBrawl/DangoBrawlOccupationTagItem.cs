using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006811 RID: 26641
	public class DangoBrawlOccupationTagItem : GridProxyAbstract<int>
	{
		// Token: 0x0604276A RID: 272234 RVA: 0x0102559C File Offset: 0x0102379C
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604276B RID: 272235 RVA: 0x01025628 File Offset: 0x01023828
		public override void Refresh(int tagId, bool isSelected, int gridIndex)
		{
			DangoBrawlOccupationTag? tagConfigById = DangoBrawlConfig.Instance.GetTagConfigById(tagId);
			base.SetTextureByPath(tagConfigById.Value.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), tagConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x0200C99B RID: 51611
		private enum EItemComponent
		{
			// Token: 0x0403CE3E RID: 249406
			TexTag,
			// Token: 0x0403CE3F RID: 249407
			TxtTag,
			// Token: 0x0403CE40 RID: 249408
			SprBg
		}
	}
}
