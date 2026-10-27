using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718B RID: 29067
	public class ISplineMovePatternT
	{
		// Token: 0x1700D7E8 RID: 55272
		// (get) Token: 0x06033890 RID: 211088 RVA: 0x006F1188 File Offset: 0x006EF388
		// (set) Token: 0x06033891 RID: 211089 RVA: 0x006F1190 File Offset: 0x006EF390
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700D7E9 RID: 55273
		// (get) Token: 0x06033892 RID: 211090 RVA: 0x006F1199 File Offset: 0x006EF399
		// (set) Token: 0x06033893 RID: 211091 RVA: 0x006F11A1 File Offset: 0x006EF3A1
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700D7EA RID: 55274
		// (get) Token: 0x06033894 RID: 211092 RVA: 0x006F11AA File Offset: 0x006EF3AA
		// (set) Token: 0x06033895 RID: 211093 RVA: 0x006F11B2 File Offset: 0x006EF3B2
		public bool IsOneWay { get; set; }

		// Token: 0x1700D7EB RID: 55275
		// (get) Token: 0x06033896 RID: 211094 RVA: 0x006F11BB File Offset: 0x006EF3BB
		// (set) Token: 0x06033897 RID: 211095 RVA: 0x006F11C3 File Offset: 0x006EF3C3
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700D7EC RID: 55276
		// (get) Token: 0x06033898 RID: 211096 RVA: 0x006F11CC File Offset: 0x006EF3CC
		// (set) Token: 0x06033899 RID: 211097 RVA: 0x006F11D4 File Offset: 0x006EF3D4
		public bool DynamicGravity { get; set; }

		// Token: 0x1700D7ED RID: 55277
		// (get) Token: 0x0603389A RID: 211098 RVA: 0x006F11DD File Offset: 0x006EF3DD
		// (set) Token: 0x0603389B RID: 211099 RVA: 0x006F11E5 File Offset: 0x006EF3E5
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700D7EE RID: 55278
		// (get) Token: 0x0603389C RID: 211100 RVA: 0x006F11EE File Offset: 0x006EF3EE
		// (set) Token: 0x0603389D RID: 211101 RVA: 0x006F11F6 File Offset: 0x006EF3F6
		public int AutoExitDistance { get; set; }

		// Token: 0x1700D7EF RID: 55279
		// (get) Token: 0x0603389E RID: 211102 RVA: 0x006F11FF File Offset: 0x006EF3FF
		// (set) Token: 0x0603389F RID: 211103 RVA: 0x006F1207 File Offset: 0x006EF407
		public byte NullMask { get; set; }

		// Token: 0x060338A0 RID: 211104 RVA: 0x006F1210 File Offset: 0x006EF410
		public ISplineMovePatternT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.NullMask = 0;
		}
	}
}
