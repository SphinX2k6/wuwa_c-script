using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x02004186 RID: 16774
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RewardPanelItem : GridProxyAbstract<RewardTuple>
	{
		// Token: 0x0602A7E8 RID: 174056 RVA: 0x00BFD1E3 File Offset: 0x00BFB3E3
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x0602A7E9 RID: 174057 RVA: 0x00BFD208 File Offset: 0x00BFB408
		protected override void OnStart()
		{
			AActor owner = base.GetItem(0).GetOwner();
			this.Grid = new CommonItemSmallItemGrid();
			this.Grid.Initialize(owner);
		}

		// Token: 0x0602A7EA RID: 174058 RVA: 0x00BFD23C File Offset: 0x00BFB43C
		public override void Refresh(RewardTuple data, bool isSelected, int gridIndex)
		{
			this.RewardData = data;
			this.Grid.RefreshByConfigId(this.RewardData.Id, new int?(this.RewardData.Num), null, false, false);
			this.Grid.SetReceivedVisible(this.RewardData.Taken);
		}

		// Token: 0x0602A7EB RID: 174059 RVA: 0x00BFD28F File Offset: 0x00BFB48F
		protected override void OnBeforeDestroy()
		{
			this.RewardData = null;
		}

		// Token: 0x04017120 RID: 94496
		private RewardTuple RewardData;

		// Token: 0x04017121 RID: 94497
		private CommonItemSmallItemGrid Grid;

		// Token: 0x02009D77 RID: 40311
		[NullableContext(0)]
		private static class EItemComponents
		{
			// Token: 0x04030F87 RID: 200583
			public const int ButtonItem = 0;
		}
	}
}
