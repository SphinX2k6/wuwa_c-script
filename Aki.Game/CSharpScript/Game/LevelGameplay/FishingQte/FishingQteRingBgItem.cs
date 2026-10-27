using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E44 RID: 28228
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteRingBgItem : UiPanelBase
	{
		// Token: 0x06044CF6 RID: 281846 RVA: 0x010FAD8E File Offset: 0x010F8F8E
		public FishingQteRingBgItem(FishingQteRingInfo RingInfo, IFishingQteConfig RingConfig)
		{
			this.RingInfo = RingInfo;
			this.RingConfig = RingConfig;
		}

		// Token: 0x06044CF7 RID: 281847 RVA: 0x010FADB0 File Offset: 0x010F8FB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06044CF8 RID: 281848 RVA: 0x010FADF8 File Offset: 0x010F8FF8
		protected override void OnStart()
		{
		}

		// Token: 0x06044CF9 RID: 281849 RVA: 0x010FADFA File Offset: 0x010F8FFA
		protected override void OnBeforeDestroy()
		{
			this.BgItemList.Clear();
		}

		// Token: 0x06044CFA RID: 281850 RVA: 0x010FAE08 File Offset: 0x010F9008
		public UniTask SpawnBgArea()
		{
			FishingQteRingBgItem.<SpawnBgArea>d__7 <SpawnBgArea>d__;
			<SpawnBgArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SpawnBgArea>d__.<>4__this = this;
			<SpawnBgArea>d__.<>1__state = -1;
			<SpawnBgArea>d__.<>t__builder.Start<FishingQteRingBgItem.<SpawnBgArea>d__7>(ref <SpawnBgArea>d__);
			return <SpawnBgArea>d__.<>t__builder.Task;
		}

		// Token: 0x06044CFB RID: 281851 RVA: 0x010FAE4C File Offset: 0x010F904C
		public void PlayAnim(string sequenceName)
		{
			foreach (FishingQteRingBgSingleItem fishingQteRingBgSingleItem in this.BgItemList)
			{
				fishingQteRingBgSingleItem.PlayAnim(sequenceName);
			}
		}

		// Token: 0x04023CC5 RID: 146629
		protected FishingQteRingInfo RingInfo;

		// Token: 0x04023CC6 RID: 146630
		protected IFishingQteConfig RingConfig;

		// Token: 0x04023CC7 RID: 146631
		protected List<FishingQteRingBgSingleItem> BgItemList = new List<FishingQteRingBgSingleItem>();

		// Token: 0x0200CCFA RID: 52474
		[NullableContext(0)]
		private class EBgComponents
		{
			// Token: 0x0403DCF0 RID: 253168
			public const int BgRing = 0;
		}
	}
}
