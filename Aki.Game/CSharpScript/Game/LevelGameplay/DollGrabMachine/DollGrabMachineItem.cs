using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006043 RID: 24643
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineItem
	{
		// Token: 0x17006FE7 RID: 28647
		// (get) Token: 0x0603B262 RID: 242274 RVA: 0x010B8F65 File Offset: 0x010B7165
		// (set) Token: 0x0603B263 RID: 242275 RVA: 0x010B8F6D File Offset: 0x010B716D
		public int ItemId { get; set; }

		// Token: 0x17006FE8 RID: 28648
		// (get) Token: 0x0603B264 RID: 242276 RVA: 0x010B8F76 File Offset: 0x010B7176
		// (set) Token: 0x0603B265 RID: 242277 RVA: 0x010B8F7E File Offset: 0x010B717E
		public int CategoryId { get; set; }

		// Token: 0x0603B266 RID: 242278 RVA: 0x010B8F88 File Offset: 0x010B7188
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

		// Token: 0x0401F1F9 RID: 127481
		[Nullable(2)]
		public BP_DollActor_C ItemActor;

		// Token: 0x0401F1FA RID: 127482
		public readonly global::Vector OriginLocation = global::Vector.Create();

		// Token: 0x0401F1FB RID: 127483
		public readonly Rotator OriginRotation = Rotator.Create();

		// Token: 0x0401F1FC RID: 127484
		public bool IsTouchGet;

		// Token: 0x0401F1FD RID: 127485
		public float? AddTime;

		// Token: 0x0401F1FE RID: 127486
		public int DropId;

		// Token: 0x0401F1FF RID: 127487
		public int EndlessScore;

		// Token: 0x0401F200 RID: 127488
		public string ItemBpPath = "";

		// Token: 0x0401F201 RID: 127489
		public bool IsEndlessStartItem;
	}
}
