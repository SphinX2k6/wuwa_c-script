using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A54 RID: 23124
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolSaveSlotData
	{
		// Token: 0x17006CA1 RID: 27809
		// (get) Token: 0x06038FA0 RID: 233376 RVA: 0x00FF6231 File Offset: 0x00FF4431
		// (set) Token: 0x06038FA1 RID: 233377 RVA: 0x00FF6239 File Offset: 0x00FF4439
		public int ActivityId { get; set; }

		// Token: 0x17006CA2 RID: 27810
		// (get) Token: 0x06038FA2 RID: 233378 RVA: 0x00FF6242 File Offset: 0x00FF4442
		// (set) Token: 0x06038FA3 RID: 233379 RVA: 0x00FF624A File Offset: 0x00FF444A
		public int SlotId { get; set; }

		// Token: 0x17006CA3 RID: 27811
		// (get) Token: 0x06038FA4 RID: 233380 RVA: 0x00FF6253 File Offset: 0x00FF4453
		// (set) Token: 0x06038FA5 RID: 233381 RVA: 0x00FF625B File Offset: 0x00FF445B
		public ESolarSchoolSaveViewMode Mode { get; set; }

		// Token: 0x17006CA4 RID: 27812
		// (get) Token: 0x06038FA6 RID: 233382 RVA: 0x00FF6264 File Offset: 0x00FF4464
		// (set) Token: 0x06038FA7 RID: 233383 RVA: 0x00FF626C File Offset: 0x00FF446C
		public SolarSchoolSavePreviewPb Preview { get; set; }

		// Token: 0x17006CA5 RID: 27813
		// (get) Token: 0x06038FA8 RID: 233384 RVA: 0x00FF6275 File Offset: 0x00FF4475
		// (set) Token: 0x06038FA9 RID: 233385 RVA: 0x00FF627D File Offset: 0x00FF447D
		public bool IsLastSaved { get; set; }

		// Token: 0x17006CA6 RID: 27814
		// (get) Token: 0x06038FAA RID: 233386 RVA: 0x00FF6286 File Offset: 0x00FF4486
		public bool IsAutoSlot
		{
			get
			{
				return this.SlotId == 0;
			}
		}

		// Token: 0x17006CA7 RID: 27815
		// (get) Token: 0x06038FAB RID: 233387 RVA: 0x00FF6291 File Offset: 0x00FF4491
		public bool IsEmpty
		{
			get
			{
				return this.Preview == null;
			}
		}

		// Token: 0x17006CA8 RID: 27816
		// (get) Token: 0x06038FAC RID: 233388 RVA: 0x00FF629C File Offset: 0x00FF449C
		public bool CanClick
		{
			get
			{
				if (this.Mode != ESolarSchoolSaveViewMode.Save)
				{
					return !this.IsEmpty;
				}
				return !this.IsAutoSlot;
			}
		}
	}
}
