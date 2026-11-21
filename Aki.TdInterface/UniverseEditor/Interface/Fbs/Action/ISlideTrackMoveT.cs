using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007924 RID: 31012
	public class ISlideTrackMoveT
	{
		// Token: 0x1700E37E RID: 58238
		// (get) Token: 0x060369C8 RID: 223688 RVA: 0x0074F104 File Offset: 0x0074D304
		// (set) Token: 0x060369C9 RID: 223689 RVA: 0x0074F10C File Offset: 0x0074D30C
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700E37F RID: 58239
		// (get) Token: 0x060369CA RID: 223690 RVA: 0x0074F115 File Offset: 0x0074D315
		// (set) Token: 0x060369CB RID: 223691 RVA: 0x0074F11D File Offset: 0x0074D31D
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700E380 RID: 58240
		// (get) Token: 0x060369CC RID: 223692 RVA: 0x0074F126 File Offset: 0x0074D326
		// (set) Token: 0x060369CD RID: 223693 RVA: 0x0074F12E File Offset: 0x0074D32E
		public bool IsOneWay { get; set; }

		// Token: 0x1700E381 RID: 58241
		// (get) Token: 0x060369CE RID: 223694 RVA: 0x0074F137 File Offset: 0x0074D337
		// (set) Token: 0x060369CF RID: 223695 RVA: 0x0074F13F File Offset: 0x0074D33F
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700E382 RID: 58242
		// (get) Token: 0x060369D0 RID: 223696 RVA: 0x0074F148 File Offset: 0x0074D348
		// (set) Token: 0x060369D1 RID: 223697 RVA: 0x0074F150 File Offset: 0x0074D350
		public bool DynamicGravity { get; set; }

		// Token: 0x1700E383 RID: 58243
		// (get) Token: 0x060369D2 RID: 223698 RVA: 0x0074F159 File Offset: 0x0074D359
		// (set) Token: 0x060369D3 RID: 223699 RVA: 0x0074F161 File Offset: 0x0074D361
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700E384 RID: 58244
		// (get) Token: 0x060369D4 RID: 223700 RVA: 0x0074F16A File Offset: 0x0074D36A
		// (set) Token: 0x060369D5 RID: 223701 RVA: 0x0074F172 File Offset: 0x0074D372
		public int AutoExitDistance { get; set; }

		// Token: 0x1700E385 RID: 58245
		// (get) Token: 0x060369D6 RID: 223702 RVA: 0x0074F17B File Offset: 0x0074D37B
		// (set) Token: 0x060369D7 RID: 223703 RVA: 0x0074F183 File Offset: 0x0074D383
		public float DirectionAngleLimit { get; set; }

		// Token: 0x1700E386 RID: 58246
		// (get) Token: 0x060369D8 RID: 223704 RVA: 0x0074F18C File Offset: 0x0074D38C
		// (set) Token: 0x060369D9 RID: 223705 RVA: 0x0074F194 File Offset: 0x0074D394
		public float EdgeLimitCurveFactor { get; set; }

		// Token: 0x1700E387 RID: 58247
		// (get) Token: 0x060369DA RID: 223706 RVA: 0x0074F19D File Offset: 0x0074D39D
		// (set) Token: 0x060369DB RID: 223707 RVA: 0x0074F1A5 File Offset: 0x0074D3A5
		public byte NullMask { get; set; }

		// Token: 0x060369DC RID: 223708 RVA: 0x0074F1B0 File Offset: 0x0074D3B0
		public ISlideTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.DirectionAngleLimit = 0f;
			this.EdgeLimitCurveFactor = 0f;
			this.NullMask = 0;
		}
	}
}
