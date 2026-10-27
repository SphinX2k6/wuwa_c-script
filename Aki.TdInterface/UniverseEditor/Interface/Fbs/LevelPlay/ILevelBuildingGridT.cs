using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E3 RID: 17635
	public class ILevelBuildingGridT
	{
		// Token: 0x17007C8A RID: 31882
		// (get) Token: 0x0601A61E RID: 108062 RVA: 0x003C4244 File Offset: 0x003C2444
		// (set) Token: 0x0601A61F RID: 108063 RVA: 0x003C424C File Offset: 0x003C244C
		public int Id { get; set; }

		// Token: 0x17007C8B RID: 31883
		// (get) Token: 0x0601A620 RID: 108064 RVA: 0x003C4255 File Offset: 0x003C2455
		// (set) Token: 0x0601A621 RID: 108065 RVA: 0x003C425D File Offset: 0x003C245D
		public string Guid { get; set; }

		// Token: 0x17007C8C RID: 31884
		// (get) Token: 0x0601A622 RID: 108066 RVA: 0x003C4266 File Offset: 0x003C2466
		// (set) Token: 0x0601A623 RID: 108067 RVA: 0x003C426E File Offset: 0x003C246E
		public IVectorInfoT Position { get; set; }

		// Token: 0x17007C8D RID: 31885
		// (get) Token: 0x0601A624 RID: 108068 RVA: 0x003C4277 File Offset: 0x003C2477
		// (set) Token: 0x0601A625 RID: 108069 RVA: 0x003C427F File Offset: 0x003C247F
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x17007C8E RID: 31886
		// (get) Token: 0x0601A626 RID: 108070 RVA: 0x003C4288 File Offset: 0x003C2488
		// (set) Token: 0x0601A627 RID: 108071 RVA: 0x003C4290 File Offset: 0x003C2490
		public IVector2T Size { get; set; }

		// Token: 0x17007C8F RID: 31887
		// (get) Token: 0x0601A628 RID: 108072 RVA: 0x003C4299 File Offset: 0x003C2499
		// (set) Token: 0x0601A629 RID: 108073 RVA: 0x003C42A1 File Offset: 0x003C24A1
		public List<IVector2T> BlockCoords { get; set; }

		// Token: 0x0601A62A RID: 108074 RVA: 0x003C42AA File Offset: 0x003C24AA
		public ILevelBuildingGridT()
		{
			this.Id = 0;
			this.Guid = null;
			this.Position = null;
			this.Rotation = null;
			this.Size = null;
			this.BlockCoords = null;
		}
	}
}
