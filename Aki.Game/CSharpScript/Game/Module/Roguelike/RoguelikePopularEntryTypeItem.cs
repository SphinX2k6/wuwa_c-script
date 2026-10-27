using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DDE RID: 19934
	public class RoguelikePopularEntryTypeItem : GridProxyAbstract<ERoguelikeEntryType>
	{
		// Token: 0x06033745 RID: 210757 RVA: 0x00C05ABC File Offset: 0x00C03CBC
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

		// Token: 0x06033746 RID: 210758 RVA: 0x00C05B46 File Offset: 0x00C03D46
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06033747 RID: 210759 RVA: 0x00C05B58 File Offset: 0x00C03D58
		public override void Refresh(ERoguelikeEntryType type, bool isSelected, int gridIndex)
		{
			RogueHotEntryType? rogueHotEntryTypeConfig = RoguelikeConfig.Instance.GetRogueHotEntryTypeConfig((int)type);
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(rogueHotEntryTypeConfig.Value.Icon, texture, null, null);
		}

		// Token: 0x0200AF63 RID: 44899
		private class EComponent
		{
			// Token: 0x0403541D RID: 218141
			public const int PanelIcon = 0;

			// Token: 0x0403541E RID: 218142
			public const int TexIcon = 1;

			// Token: 0x0403541F RID: 218143
			public const int PanelEmpty = 2;
		}
	}
}
