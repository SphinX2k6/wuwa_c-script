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
	// Token: 0x02005FC5 RID: 24517
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteRingBgItem : UiPanelBase
	{
		// Token: 0x0603AE83 RID: 241283 RVA: 0x010A530E File Offset: 0x010A350E
		public FishingQteRingBgItem(FishingQteRingInfo RingInfo, IFishingQteConfig RingConfig)
		{
			this.RingInfo = RingInfo;
			this.RingConfig = RingConfig;
		}

		// Token: 0x0603AE84 RID: 241284 RVA: 0x010A5330 File Offset: 0x010A3530
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

		// Token: 0x0603AE85 RID: 241285 RVA: 0x010A5378 File Offset: 0x010A3578
		protected override void OnStart()
		{
		}

		// Token: 0x0603AE86 RID: 241286 RVA: 0x010A537A File Offset: 0x010A357A
		protected override void OnBeforeDestroy()
		{
			this.BgItemList.Clear();
		}

		// Token: 0x0603AE87 RID: 241287 RVA: 0x010A5388 File Offset: 0x010A3588
		public UniTask SpawnBgArea()
		{
			FishingQteRingBgItem.<SpawnBgArea>d__7 <SpawnBgArea>d__;
			<SpawnBgArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SpawnBgArea>d__.<>4__this = this;
			<SpawnBgArea>d__.<>1__state = -1;
			<SpawnBgArea>d__.<>t__builder.Start<FishingQteRingBgItem.<SpawnBgArea>d__7>(ref <SpawnBgArea>d__);
			return <SpawnBgArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE88 RID: 241288 RVA: 0x010A53CC File Offset: 0x010A35CC
		public void PlayAnim(string sequenceName)
		{
			foreach (FishingQteRingBgSingleItem fishingQteRingBgSingleItem in this.BgItemList)
			{
				fishingQteRingBgSingleItem.PlayAnim(sequenceName);
			}
		}

		// Token: 0x0401EF7A RID: 126842
		protected FishingQteRingInfo RingInfo;

		// Token: 0x0401EF7B RID: 126843
		protected IFishingQteConfig RingConfig;

		// Token: 0x0401EF7C RID: 126844
		protected List<FishingQteRingBgSingleItem> BgItemList = new List<FishingQteRingBgSingleItem>();

		// Token: 0x0200B8EA RID: 47338
		[NullableContext(0)]
		private class EBgComponents
		{
			// Token: 0x04039112 RID: 233746
			public const int BgRing = 0;
		}
	}
}
