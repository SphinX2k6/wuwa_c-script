using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C70 RID: 27760
	public class IPathLineMoveT
	{
		// Token: 0x1700CEC0 RID: 52928
		// (get) Token: 0x06030EA9 RID: 200361 RVA: 0x006A4A91 File Offset: 0x006A2C91
		// (set) Token: 0x06030EAA RID: 200362 RVA: 0x006A4A99 File Offset: 0x006A2C99
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700CEC1 RID: 52929
		// (get) Token: 0x06030EAB RID: 200363 RVA: 0x006A4AA2 File Offset: 0x006A2CA2
		// (set) Token: 0x06030EAC RID: 200364 RVA: 0x006A4AAA File Offset: 0x006A2CAA
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700CEC2 RID: 52930
		// (get) Token: 0x06030EAD RID: 200365 RVA: 0x006A4AB3 File Offset: 0x006A2CB3
		// (set) Token: 0x06030EAE RID: 200366 RVA: 0x006A4ABB File Offset: 0x006A2CBB
		public bool IsOneWay { get; set; }

		// Token: 0x1700CEC3 RID: 52931
		// (get) Token: 0x06030EAF RID: 200367 RVA: 0x006A4AC4 File Offset: 0x006A2CC4
		// (set) Token: 0x06030EB0 RID: 200368 RVA: 0x006A4ACC File Offset: 0x006A2CCC
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700CEC4 RID: 52932
		// (get) Token: 0x06030EB1 RID: 200369 RVA: 0x006A4AD5 File Offset: 0x006A2CD5
		// (set) Token: 0x06030EB2 RID: 200370 RVA: 0x006A4ADD File Offset: 0x006A2CDD
		public bool DynamicGravity { get; set; }

		// Token: 0x1700CEC5 RID: 52933
		// (get) Token: 0x06030EB3 RID: 200371 RVA: 0x006A4AE6 File Offset: 0x006A2CE6
		// (set) Token: 0x06030EB4 RID: 200372 RVA: 0x006A4AEE File Offset: 0x006A2CEE
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700CEC6 RID: 52934
		// (get) Token: 0x06030EB5 RID: 200373 RVA: 0x006A4AF7 File Offset: 0x006A2CF7
		// (set) Token: 0x06030EB6 RID: 200374 RVA: 0x006A4AFF File Offset: 0x006A2CFF
		public int AutoExitDistance { get; set; }

		// Token: 0x1700CEC7 RID: 52935
		// (get) Token: 0x06030EB7 RID: 200375 RVA: 0x006A4B08 File Offset: 0x006A2D08
		// (set) Token: 0x06030EB8 RID: 200376 RVA: 0x006A4B10 File Offset: 0x006A2D10
		public TPathLineFacingConfigUnion FacingConfig { get; set; }

		// Token: 0x1700CEC8 RID: 52936
		// (get) Token: 0x06030EB9 RID: 200377 RVA: 0x006A4B19 File Offset: 0x006A2D19
		// (set) Token: 0x06030EBA RID: 200378 RVA: 0x006A4B21 File Offset: 0x006A2D21
		public string SplineMoveConfigDaPath { get; set; }

		// Token: 0x1700CEC9 RID: 52937
		// (get) Token: 0x06030EBB RID: 200379 RVA: 0x006A4B2A File Offset: 0x006A2D2A
		// (set) Token: 0x06030EBC RID: 200380 RVA: 0x006A4B32 File Offset: 0x006A2D32
		public bool IsAdaptiveClimbInput { get; set; }

		// Token: 0x1700CECA RID: 52938
		// (get) Token: 0x06030EBD RID: 200381 RVA: 0x006A4B3B File Offset: 0x006A2D3B
		// (set) Token: 0x06030EBE RID: 200382 RVA: 0x006A4B43 File Offset: 0x006A2D43
		public bool IsDisableStopAnim { get; set; }

		// Token: 0x1700CECB RID: 52939
		// (get) Token: 0x06030EBF RID: 200383 RVA: 0x006A4B4C File Offset: 0x006A2D4C
		// (set) Token: 0x06030EC0 RID: 200384 RVA: 0x006A4B54 File Offset: 0x006A2D54
		public bool IsAllowEarlyExitClimb { get; set; }

		// Token: 0x1700CECC RID: 52940
		// (get) Token: 0x06030EC1 RID: 200385 RVA: 0x006A4B5D File Offset: 0x006A2D5D
		// (set) Token: 0x06030EC2 RID: 200386 RVA: 0x006A4B65 File Offset: 0x006A2D65
		public ushort NullMask { get; set; }

		// Token: 0x06030EC3 RID: 200387 RVA: 0x006A4B70 File Offset: 0x006A2D70
		public IPathLineMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.FacingConfig = null;
			this.SplineMoveConfigDaPath = null;
			this.IsAdaptiveClimbInput = false;
			this.IsDisableStopAnim = false;
			this.IsAllowEarlyExitClimb = false;
			this.NullMask = 0;
		}
	}
}
