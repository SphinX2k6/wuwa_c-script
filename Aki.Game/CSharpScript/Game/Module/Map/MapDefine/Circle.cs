using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200554F RID: 21839
	public class Circle
	{
		// Token: 0x170085CA RID: 34250
		// (get) Token: 0x06037B8E RID: 228238 RVA: 0x00D388E7 File Offset: 0x00D36AE7
		// (set) Token: 0x06037B8F RID: 228239 RVA: 0x00D388EF File Offset: 0x00D36AEF
		public float X { get; set; }

		// Token: 0x170085CB RID: 34251
		// (get) Token: 0x06037B90 RID: 228240 RVA: 0x00D388F8 File Offset: 0x00D36AF8
		// (set) Token: 0x06037B91 RID: 228241 RVA: 0x00D38900 File Offset: 0x00D36B00
		public float Y { get; set; }

		// Token: 0x170085CC RID: 34252
		// (get) Token: 0x06037B92 RID: 228242 RVA: 0x00D38909 File Offset: 0x00D36B09
		// (set) Token: 0x06037B93 RID: 228243 RVA: 0x00D38911 File Offset: 0x00D36B11
		public float R { get; set; }

		// Token: 0x06037B94 RID: 228244 RVA: 0x00D3891A File Offset: 0x00D36B1A
		public Circle(float x = 0f, float y = 0f, float r = 0f)
		{
			this.X = x;
			this.Y = y;
			this.R = r;
		}
	}
}
