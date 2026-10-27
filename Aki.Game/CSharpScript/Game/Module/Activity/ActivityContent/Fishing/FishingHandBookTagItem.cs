using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006616 RID: 26134
	public class FishingHandBookTagItem : GridProxyAbstract<int>
	{
		// Token: 0x060417D8 RID: 268248 RVA: 0x00FDD170 File Offset: 0x00FDB370
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

		// Token: 0x060417D9 RID: 268249 RVA: 0x00FDD1DC File Offset: 0x00FDB3DC
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

		// Token: 0x0200C828 RID: 51240
		private class EComponentDefine
		{
			// Token: 0x0403C730 RID: 247600
			public const int TagNameText = 0;

			// Token: 0x0403C731 RID: 247601
			public const int BgItem = 1;
		}
	}
}
