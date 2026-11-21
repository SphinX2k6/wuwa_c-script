using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CED RID: 31981
	public class IVariableMotionT
	{
		// Token: 0x1700EF5D RID: 61277
		// (get) Token: 0x06039B44 RID: 236356 RVA: 0x007C8D3E File Offset: 0x007C6F3E
		// (set) Token: 0x06039B45 RID: 236357 RVA: 0x007C8D46 File Offset: 0x007C6F46
		public EMoveMotion Type { get; set; }

		// Token: 0x1700EF5E RID: 61278
		// (get) Token: 0x06039B46 RID: 236358 RVA: 0x007C8D4F File Offset: 0x007C6F4F
		// (set) Token: 0x06039B47 RID: 236359 RVA: 0x007C8D57 File Offset: 0x007C6F57
		public float Acceleration { get; set; }

		// Token: 0x1700EF5F RID: 61279
		// (get) Token: 0x06039B48 RID: 236360 RVA: 0x007C8D60 File Offset: 0x007C6F60
		// (set) Token: 0x06039B49 RID: 236361 RVA: 0x007C8D68 File Offset: 0x007C6F68
		public float MaxSpeed { get; set; }

		// Token: 0x06039B4A RID: 236362 RVA: 0x007C8D71 File Offset: 0x007C6F71
		public IVariableMotionT()
		{
			this.Type = EMoveMotion.UniformMotion;
			this.Acceleration = 0f;
			this.MaxSpeed = 0f;
		}
	}
}
