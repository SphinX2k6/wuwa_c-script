using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A88 RID: 14984
	public class IColorT
	{
		// Token: 0x1700669F RID: 26271
		// (get) Token: 0x0601451B RID: 83227 RVA: 0x002F7146 File Offset: 0x002F5346
		// (set) Token: 0x0601451C RID: 83228 RVA: 0x002F714E File Offset: 0x002F534E
		public float R { get; set; }

		// Token: 0x170066A0 RID: 26272
		// (get) Token: 0x0601451D RID: 83229 RVA: 0x002F7157 File Offset: 0x002F5357
		// (set) Token: 0x0601451E RID: 83230 RVA: 0x002F715F File Offset: 0x002F535F
		public float G { get; set; }

		// Token: 0x170066A1 RID: 26273
		// (get) Token: 0x0601451F RID: 83231 RVA: 0x002F7168 File Offset: 0x002F5368
		// (set) Token: 0x06014520 RID: 83232 RVA: 0x002F7170 File Offset: 0x002F5370
		public float B { get; set; }

		// Token: 0x170066A2 RID: 26274
		// (get) Token: 0x06014521 RID: 83233 RVA: 0x002F7179 File Offset: 0x002F5379
		// (set) Token: 0x06014522 RID: 83234 RVA: 0x002F7181 File Offset: 0x002F5381
		public float A { get; set; }

		// Token: 0x170066A3 RID: 26275
		// (get) Token: 0x06014523 RID: 83235 RVA: 0x002F718A File Offset: 0x002F538A
		// (set) Token: 0x06014524 RID: 83236 RVA: 0x002F7192 File Offset: 0x002F5392
		public byte NullMask { get; set; }

		// Token: 0x06014525 RID: 83237 RVA: 0x002F719B File Offset: 0x002F539B
		public IColorT()
		{
			this.R = 0f;
			this.G = 0f;
			this.B = 0f;
			this.A = 0f;
			this.NullMask = 0;
		}
	}
}
