using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E34 RID: 28212
	public class IFireBulletEffectT
	{
		// Token: 0x1700CEC0 RID: 52928
		// (get) Token: 0x06030B7B RID: 199547 RVA: 0x0069CA30 File Offset: 0x0069AC30
		// (set) Token: 0x06030B7C RID: 199548 RVA: 0x0069CA38 File Offset: 0x0069AC38
		public int Id { get; set; }

		// Token: 0x1700CEC1 RID: 52929
		// (get) Token: 0x06030B7D RID: 199549 RVA: 0x0069CA41 File Offset: 0x0069AC41
		// (set) Token: 0x06030B7E RID: 199550 RVA: 0x0069CA49 File Offset: 0x0069AC49
		public int X { get; set; }

		// Token: 0x1700CEC2 RID: 52930
		// (get) Token: 0x06030B7F RID: 199551 RVA: 0x0069CA52 File Offset: 0x0069AC52
		// (set) Token: 0x06030B80 RID: 199552 RVA: 0x0069CA5A File Offset: 0x0069AC5A
		public int Y { get; set; }

		// Token: 0x1700CEC3 RID: 52931
		// (get) Token: 0x06030B81 RID: 199553 RVA: 0x0069CA63 File Offset: 0x0069AC63
		// (set) Token: 0x06030B82 RID: 199554 RVA: 0x0069CA6B File Offset: 0x0069AC6B
		public int Z { get; set; }

		// Token: 0x1700CEC4 RID: 52932
		// (get) Token: 0x06030B83 RID: 199555 RVA: 0x0069CA74 File Offset: 0x0069AC74
		// (set) Token: 0x06030B84 RID: 199556 RVA: 0x0069CA7C File Offset: 0x0069AC7C
		public EBulletLauncher Launcher { get; set; }

		// Token: 0x1700CEC5 RID: 52933
		// (get) Token: 0x06030B85 RID: 199557 RVA: 0x0069CA85 File Offset: 0x0069AC85
		// (set) Token: 0x06030B86 RID: 199558 RVA: 0x0069CA8D File Offset: 0x0069AC8D
		public byte NullMask { get; set; }

		// Token: 0x06030B87 RID: 199559 RVA: 0x0069CA96 File Offset: 0x0069AC96
		public IFireBulletEffectT()
		{
			this.Id = 0;
			this.X = 0;
			this.Y = 0;
			this.Z = 0;
			this.Launcher = EBulletLauncher.Player;
			this.NullMask = 0;
		}
	}
}
