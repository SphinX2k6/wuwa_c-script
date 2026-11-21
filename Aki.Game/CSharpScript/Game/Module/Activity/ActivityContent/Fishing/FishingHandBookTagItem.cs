using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005594 RID: 21908
	public class FishingHandBookTagItem : GridProxyAbstract<int>
	{
		// Token: 0x0603649D RID: 222365 RVA: 0x00F24208 File Offset: 0x00F22408
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603649E RID: 222366 RVA: 0x00F24274 File Offset: 0x00F22474
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			FishingTag? fishingTagConfig = FishingConfig.Instance.GetFishingTagConfig(data);
			if (fishingTagConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fishingTagConfig.Value.Name, Array.Empty<object>());
			FColor color = FColor.FromHex(fishingTagConfig.Value.Color);
			base.GetItem(1).SetColor(color);
		}

		// Token: 0x0200B20A RID: 45578
		private class EComponentDefine
		{
			// Token: 0x04037075 RID: 225397
			public const int TagNameText = 0;

			// Token: 0x04037076 RID: 225398
			public const int BgItem = 1;
		}
	}
}
