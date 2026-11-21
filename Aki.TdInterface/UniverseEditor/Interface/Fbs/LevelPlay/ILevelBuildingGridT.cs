using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200494B RID: 18763
	public class ILevelBuildingGridT
	{
		// Token: 0x170082C9 RID: 33481
		// (get) Token: 0x0601BDEF RID: 114159 RVA: 0x003F0450 File Offset: 0x003EE650
		// (set) Token: 0x0601BDF0 RID: 114160 RVA: 0x003F0458 File Offset: 0x003EE658
		public int Id { get; set; }

		// Token: 0x170082CA RID: 33482
		// (get) Token: 0x0601BDF1 RID: 114161 RVA: 0x003F0461 File Offset: 0x003EE661
		// (set) Token: 0x0601BDF2 RID: 114162 RVA: 0x003F0469 File Offset: 0x003EE669
		public string Guid { get; set; }

		// Token: 0x170082CB RID: 33483
		// (get) Token: 0x0601BDF3 RID: 114163 RVA: 0x003F0472 File Offset: 0x003EE672
		// (set) Token: 0x0601BDF4 RID: 114164 RVA: 0x003F047A File Offset: 0x003EE67A
		public IVectorInfoT Position { get; set; }

		// Token: 0x170082CC RID: 33484
		// (get) Token: 0x0601BDF5 RID: 114165 RVA: 0x003F0483 File Offset: 0x003EE683
		// (set) Token: 0x0601BDF6 RID: 114166 RVA: 0x003F048B File Offset: 0x003EE68B
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x170082CD RID: 33485
		// (get) Token: 0x0601BDF7 RID: 114167 RVA: 0x003F0494 File Offset: 0x003EE694
		// (set) Token: 0x0601BDF8 RID: 114168 RVA: 0x003F049C File Offset: 0x003EE69C
		public IVector2T Size { get; set; }

		// Token: 0x170082CE RID: 33486
		// (get) Token: 0x0601BDF9 RID: 114169 RVA: 0x003F04A5 File Offset: 0x003EE6A5
		// (set) Token: 0x0601BDFA RID: 114170 RVA: 0x003F04AD File Offset: 0x003EE6AD
		public List<IVector2T> BlockCoords { get; set; }

		// Token: 0x0601BDFB RID: 114171 RVA: 0x003F04B6 File Offset: 0x003EE6B6
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
