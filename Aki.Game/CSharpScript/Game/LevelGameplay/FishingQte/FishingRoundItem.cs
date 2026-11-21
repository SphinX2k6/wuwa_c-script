using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FC3 RID: 24515
	public class FishingRoundItem : GridProxyAbstract<int>
	{
		// Token: 0x0603AE7B RID: 241275 RVA: 0x010A50F0 File Offset: 0x010A32F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AE7C RID: 241276 RVA: 0x010A5159 File Offset: 0x010A3359
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603AE7D RID: 241277 RVA: 0x010A5179 File Offset: 0x010A3379
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x0603AE7E RID: 241278 RVA: 0x010A517C File Offset: 0x010A337C
		public void ShowIcon(int type)
		{
			UUISprite sprite = base.GetSprite(1);
			string resourceId = this.fishingIconPath[type];
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, sprite, false, null, delegate(bool _)
			{
				sprite.SetUIActive(true);
				this.LevelSequencePlayer.PlayLevelSequenceByName("Fish", false, null, false);
			});
		}

		// Token: 0x0603AE7F RID: 241279 RVA: 0x010A51DF File Offset: 0x010A33DF
		public FishingRoundItem()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[1] = "SP_Fishing_IconMaterial";
			dictionary[0] = "SP_Fishing_IconFish";
			this.fishingIconPath = dictionary;
			base..ctor();
		}

		// Token: 0x0401EF78 RID: 126840
		[Nullable(1)]
		private Dictionary<int, string> fishingIconPath;

		// Token: 0x0401EF79 RID: 126841
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B8E7 RID: 47335
		public class EComponents
		{
			// Token: 0x0403910C RID: 233740
			public const int PanelFish = 0;

			// Token: 0x0403910D RID: 233741
			public const int SpriteIcon = 1;
		}
	}
}
