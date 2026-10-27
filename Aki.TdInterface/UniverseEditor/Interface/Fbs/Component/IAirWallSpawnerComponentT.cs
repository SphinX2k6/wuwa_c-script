using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E8D RID: 20109
	public class IAirWallSpawnerComponentT
	{
		// Token: 0x17009036 RID: 36918
		// (get) Token: 0x0601FA46 RID: 129606 RVA: 0x00468464 File Offset: 0x00466664
		// (set) Token: 0x0601FA47 RID: 129607 RVA: 0x0046846C File Offset: 0x0046666C
		public bool Disabled { get; set; }

		// Token: 0x17009037 RID: 36919
		// (get) Token: 0x0601FA48 RID: 129608 RVA: 0x00468475 File Offset: 0x00466675
		// (set) Token: 0x0601FA49 RID: 129609 RVA: 0x0046847D File Offset: 0x0046667D
		public int SplineEntity { get; set; }

		// Token: 0x17009038 RID: 36920
		// (get) Token: 0x0601FA4A RID: 129610 RVA: 0x00468486 File Offset: 0x00466686
		// (set) Token: 0x0601FA4B RID: 129611 RVA: 0x0046848E File Offset: 0x0046668E
		public string WallName { get; set; }

		// Token: 0x17009039 RID: 36921
		// (get) Token: 0x0601FA4C RID: 129612 RVA: 0x00468497 File Offset: 0x00466697
		// (set) Token: 0x0601FA4D RID: 129613 RVA: 0x0046849F File Offset: 0x0046669F
		public float Thickness { get; set; }

		// Token: 0x1700903A RID: 36922
		// (get) Token: 0x0601FA4E RID: 129614 RVA: 0x004684A8 File Offset: 0x004666A8
		// (set) Token: 0x0601FA4F RID: 129615 RVA: 0x004684B0 File Offset: 0x004666B0
		public float Height { get; set; }

		// Token: 0x1700903B RID: 36923
		// (get) Token: 0x0601FA50 RID: 129616 RVA: 0x004684B9 File Offset: 0x004666B9
		// (set) Token: 0x0601FA51 RID: 129617 RVA: 0x004684C1 File Offset: 0x004666C1
		public EBiasDirection BiasDirection { get; set; }

		// Token: 0x1700903C RID: 36924
		// (get) Token: 0x0601FA52 RID: 129618 RVA: 0x004684CA File Offset: 0x004666CA
		// (set) Token: 0x0601FA53 RID: 129619 RVA: 0x004684D2 File Offset: 0x004666D2
		public bool IsExtend { get; set; }

		// Token: 0x1700903D RID: 36925
		// (get) Token: 0x0601FA54 RID: 129620 RVA: 0x004684DB File Offset: 0x004666DB
		// (set) Token: 0x0601FA55 RID: 129621 RVA: 0x004684E3 File Offset: 0x004666E3
		public bool HasCover { get; set; }

		// Token: 0x1700903E RID: 36926
		// (get) Token: 0x0601FA56 RID: 129622 RVA: 0x004684EC File Offset: 0x004666EC
		// (set) Token: 0x0601FA57 RID: 129623 RVA: 0x004684F4 File Offset: 0x004666F4
		public List<IActorRefT> WallActorsRef { get; set; }

		// Token: 0x1700903F RID: 36927
		// (get) Token: 0x0601FA58 RID: 129624 RVA: 0x004684FD File Offset: 0x004666FD
		// (set) Token: 0x0601FA59 RID: 129625 RVA: 0x00468505 File Offset: 0x00466705
		public byte NullMask { get; set; }

		// Token: 0x0601FA5A RID: 129626 RVA: 0x00468510 File Offset: 0x00466710
		public IAirWallSpawnerComponentT()
		{
			this.Disabled = false;
			this.SplineEntity = 0;
			this.WallName = null;
			this.Thickness = 0f;
			this.Height = 0f;
			this.BiasDirection = EBiasDirection.Inner;
			this.IsExtend = false;
			this.HasCover = false;
			this.WallActorsRef = null;
			this.NullMask = 0;
		}
	}
}
