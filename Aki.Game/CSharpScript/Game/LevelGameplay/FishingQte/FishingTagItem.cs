using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E43 RID: 28227
	public class FishingTagItem : UiPanelBase
	{
		// Token: 0x06044CF3 RID: 281843 RVA: 0x010FAC8C File Offset: 0x010F8E8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06044CF4 RID: 281844 RVA: 0x010FACF8 File Offset: 0x010F8EF8
		public void Refresh(int id)
		{
			if (id == 0)
			{
				this.SetActive(false);
				return;
			}
			FishingPoint? fishingPointConfigById = FishingConfig.Instance.GetFishingPointConfigById(id);
			FishingTag? fishingTagConfig = FishingConfig.Instance.GetFishingTagConfig(fishingPointConfigById.Value.UnlockTech);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fishingTagConfig.Value.Name, Array.Empty<object>());
			FColor color = FColor.FromHex(fishingTagConfig.Value.Color);
			base.GetSprite(1).SetColor(color);
			this.SetActive(true);
		}

		// Token: 0x0200CCF9 RID: 52473
		private class EComponents
		{
			// Token: 0x0403DCEE RID: 253166
			public const int TxtTag = 0;

			// Token: 0x0403DCEF RID: 253167
			public const int SpriteBg = 1;
		}
	}
}
