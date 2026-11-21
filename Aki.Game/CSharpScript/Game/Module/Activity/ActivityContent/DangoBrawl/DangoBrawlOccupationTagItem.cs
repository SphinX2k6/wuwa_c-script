using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005761 RID: 22369
	public class DangoBrawlOccupationTagItem : GridProxyAbstract<int>
	{
		// Token: 0x060372BF RID: 225983 RVA: 0x00F66AE0 File Offset: 0x00F64CE0
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

		// Token: 0x060372C0 RID: 225984 RVA: 0x00F66B6C File Offset: 0x00F64D6C
		public override void Refresh(int tagId, bool isSelected, int gridIndex)
		{
			DangoBrawlOccupationTag? tagConfigById = DangoBrawlConfig.Instance.GetTagConfigById(tagId);
			base.SetTextureByPath(tagConfigById.Value.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), tagConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x0200B368 RID: 45928
		private enum EItemComponent
		{
			// Token: 0x0403772B RID: 227115
			TexTag,
			// Token: 0x0403772C RID: 227116
			TxtTag,
			// Token: 0x0403772D RID: 227117
			SprBg
		}
	}
}
