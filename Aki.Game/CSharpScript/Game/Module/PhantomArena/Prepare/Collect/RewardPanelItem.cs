using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B6 RID: 20918
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RewardPanelItem : GridProxyAbstract<RewardTuple>
	{
		// Token: 0x060358ED RID: 219373 RVA: 0x00CAFBA7 File Offset: 0x00CADDA7
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x060358EE RID: 219374 RVA: 0x00CAFBCC File Offset: 0x00CADDCC
		protected override void OnStart()
		{
			AActor owner = base.GetItem(0).GetOwner();
			this.Grid = new CommonItemSmallItemGrid();
			this.Grid.Initialize(owner);
		}

		// Token: 0x060358EF RID: 219375 RVA: 0x00CAFC00 File Offset: 0x00CADE00
		public override void Refresh(RewardTuple data, bool isSelected, int gridIndex)
		{
			this.RewardData = data;
			this.Grid.RefreshByConfigId(this.RewardData.Id, new int?(this.RewardData.Num), null, false, false);
			this.Grid.SetReceivedVisible(this.RewardData.Taken);
		}

		// Token: 0x060358F0 RID: 219376 RVA: 0x00CAFC53 File Offset: 0x00CADE53
		protected override void OnBeforeDestroy()
		{
			this.RewardData = null;
		}

		// Token: 0x0401C6EB RID: 116459
		private RewardTuple RewardData;

		// Token: 0x0401C6EC RID: 116460
		private CommonItemSmallItemGrid Grid;

		// Token: 0x0200B33F RID: 45887
		[NullableContext(0)]
		private static class EItemComponents
		{
			// Token: 0x04036534 RID: 222516
			public const int ButtonItem = 0;
		}
	}
}
