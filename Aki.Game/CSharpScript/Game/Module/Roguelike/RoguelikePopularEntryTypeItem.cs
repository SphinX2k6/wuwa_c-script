using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DA7 RID: 15783
	public class RoguelikePopularEntryTypeItem : GridProxyAbstract<ERoguelikeEntryType>
	{
		// Token: 0x060285B0 RID: 165296 RVA: 0x00B4EFCC File Offset: 0x00B4D1CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060285B1 RID: 165297 RVA: 0x00B4F056 File Offset: 0x00B4D256
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x060285B2 RID: 165298 RVA: 0x00B4F068 File Offset: 0x00B4D268
		public override void Refresh(ERoguelikeEntryType type, bool isSelected, int gridIndex)
		{
			RogueHotEntryType? rogueHotEntryTypeConfig = RoguelikeConfig.Instance.GetRogueHotEntryTypeConfig((int)type);
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(rogueHotEntryTypeConfig.Value.Icon, texture, null, null);
		}

		// Token: 0x02009998 RID: 39320
		private class EComponent
		{
			// Token: 0x0402FE50 RID: 196176
			public const int PanelIcon = 0;

			// Token: 0x0402FE51 RID: 196177
			public const int TexIcon = 1;

			// Token: 0x0402FE52 RID: 196178
			public const int PanelEmpty = 2;
		}
	}
}
