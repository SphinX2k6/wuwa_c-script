using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E42 RID: 28226
	public class FishingRoundItem : GridProxyAbstract<int>
	{
		// Token: 0x06044CEE RID: 281838 RVA: 0x010FAB70 File Offset: 0x010F8D70
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

		// Token: 0x06044CEF RID: 281839 RVA: 0x010FABD9 File Offset: 0x010F8DD9
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x06044CF0 RID: 281840 RVA: 0x010FABF9 File Offset: 0x010F8DF9
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x06044CF1 RID: 281841 RVA: 0x010FABFC File Offset: 0x010F8DFC
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

		// Token: 0x06044CF2 RID: 281842 RVA: 0x010FAC5F File Offset: 0x010F8E5F
		public FishingRoundItem()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[1] = "SP_Fishing_IconMaterial";
			dictionary[0] = "SP_Fishing_IconFish";
			this.fishingIconPath = dictionary;
			base..ctor();
		}

		// Token: 0x04023CC3 RID: 146627
		[Nullable(1)]
		private Dictionary<int, string> fishingIconPath;

		// Token: 0x04023CC4 RID: 146628
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CCF7 RID: 52471
		public class EComponents
		{
			// Token: 0x0403DCEA RID: 253162
			public const int PanelFish = 0;

			// Token: 0x0403DCEB RID: 253163
			public const int SpriteIcon = 1;
		}
	}
}
