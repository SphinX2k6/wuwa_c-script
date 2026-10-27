using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC3 RID: 28355
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineItem
	{
		// Token: 0x17009AB0 RID: 39600
		// (get) Token: 0x060450C1 RID: 282817 RVA: 0x0110EE89 File Offset: 0x0110D089
		// (set) Token: 0x060450C2 RID: 282818 RVA: 0x0110EE91 File Offset: 0x0110D091
		public int ItemId { get; set; }

		// Token: 0x17009AB1 RID: 39601
		// (get) Token: 0x060450C3 RID: 282819 RVA: 0x0110EE9A File Offset: 0x0110D09A
		// (set) Token: 0x060450C4 RID: 282820 RVA: 0x0110EEA2 File Offset: 0x0110D0A2
		public int CategoryId { get; set; }

		// Token: 0x060450C5 RID: 282821 RVA: 0x0110EEAC File Offset: 0x0110D0AC
		[NullableContext(2)]
		public DollGrabMachineItem(int itemId, int categoryId, BP_DollActor_C itemActor, global::Vector relOriginLocation, Rotator relOriginRotation)
		{
			this.ItemId = itemId;
			this.CategoryId = categoryId;
			this.ItemActor = itemActor;
			if (relOriginLocation != null)
			{
				this.OriginLocation.DeepCopy(relOriginLocation);
			}
			if (relOriginRotation != null)
			{
				this.OriginRotation.DeepCopy(relOriginRotation);
			}
			DollGrabItemsCsv? config = ConfigDollGrabItemsCsvById.GetConfig(this.CategoryId, true);
			if (config != null)
			{
				this.IsTouchGet = config.Value.IsTouchGet;
				if (config.Value.AddTime > 0)
				{
					this.AddTime = new float?((float)config.Value.AddTime);
				}
				this.EndlessScore = config.Value.InfiniteModeScore;
				this.ItemBpPath = config.Value.ItemBpPath + "_C";
				this.DropId = config.Value.DropId;
			}
		}

		// Token: 0x04023F46 RID: 147270
		[Nullable(2)]
		public BP_DollActor_C ItemActor;

		// Token: 0x04023F47 RID: 147271
		public readonly global::Vector OriginLocation = global::Vector.Create();

		// Token: 0x04023F48 RID: 147272
		public readonly Rotator OriginRotation = Rotator.Create();

		// Token: 0x04023F49 RID: 147273
		public bool IsTouchGet;

		// Token: 0x04023F4A RID: 147274
		public float? AddTime;

		// Token: 0x04023F4B RID: 147275
		public int DropId;

		// Token: 0x04023F4C RID: 147276
		public int EndlessScore;

		// Token: 0x04023F4D RID: 147277
		public string ItemBpPath = "";

		// Token: 0x04023F4E RID: 147278
		public bool IsEndlessStartItem;
	}
}
