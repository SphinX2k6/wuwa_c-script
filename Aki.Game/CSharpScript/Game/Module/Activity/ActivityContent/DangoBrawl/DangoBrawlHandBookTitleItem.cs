using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200575C RID: 22364
	public class DangoBrawlHandBookTitleItem : SyncGridProxyAbstract<DangBrawlHandBookTitleData>
	{
		// Token: 0x0603724B RID: 225867 RVA: 0x00F64314 File Offset: 0x00F62514
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603724C RID: 225868 RVA: 0x00F64380 File Offset: 0x00F62580
		public override void Refresh(DangBrawlHandBookTitleData data)
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
		}

		// Token: 0x0200B353 RID: 45907
		private enum ETitleComponent
		{
			// Token: 0x040376B5 RID: 226997
			TexIcon,
			// Token: 0x040376B6 RID: 226998
			TxtName
		}
	}
}
