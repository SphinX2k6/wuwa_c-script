using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FC4 RID: 24516
	public class FishingTagItem : UiPanelBase
	{
		// Token: 0x0603AE80 RID: 241280 RVA: 0x010A520C File Offset: 0x010A340C
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

		// Token: 0x0603AE81 RID: 241281 RVA: 0x010A5278 File Offset: 0x010A3478
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

		// Token: 0x0200B8E9 RID: 47337
		private class EComponents
		{
			// Token: 0x04039110 RID: 233744
			public const int TxtTag = 0;

			// Token: 0x04039111 RID: 233745
			public const int SpriteBg = 1;
		}
	}
}
