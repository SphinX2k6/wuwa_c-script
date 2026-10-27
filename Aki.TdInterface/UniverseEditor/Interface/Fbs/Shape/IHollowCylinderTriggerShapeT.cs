using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C1D RID: 15389
	public class IHollowCylinderTriggerShapeT
	{
		// Token: 0x170069E5 RID: 27109
		// (get) Token: 0x060153A3 RID: 86947 RVA: 0x00312F7D File Offset: 0x0031117D
		// (set) Token: 0x060153A4 RID: 86948 RVA: 0x00312F85 File Offset: 0x00311185
		public ETriggerShape Type { get; set; }

		// Token: 0x170069E6 RID: 27110
		// (get) Token: 0x060153A5 RID: 86949 RVA: 0x00312F8E File Offset: 0x0031118E
		// (set) Token: 0x060153A6 RID: 86950 RVA: 0x00312F96 File Offset: 0x00311196
		public IVectorInfoT Center { get; set; }

		// Token: 0x170069E7 RID: 27111
		// (get) Token: 0x060153A7 RID: 86951 RVA: 0x00312F9F File Offset: 0x0031119F
		// (set) Token: 0x060153A8 RID: 86952 RVA: 0x00312FA7 File Offset: 0x003111A7
		public int Radius { get; set; }

		// Token: 0x170069E8 RID: 27112
		// (get) Token: 0x060153A9 RID: 86953 RVA: 0x00312FB0 File Offset: 0x003111B0
		// (set) Token: 0x060153AA RID: 86954 RVA: 0x00312FB8 File Offset: 0x003111B8
		public int Height { get; set; }

		// Token: 0x170069E9 RID: 27113
		// (get) Token: 0x060153AB RID: 86955 RVA: 0x00312FC1 File Offset: 0x003111C1
		// (set) Token: 0x060153AC RID: 86956 RVA: 0x00312FC9 File Offset: 0x003111C9
		public int InnerRadius { get; set; }

		// Token: 0x060153AD RID: 86957 RVA: 0x00312FD2 File Offset: 0x003111D2
		public IHollowCylinderTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.Height = 0;
			this.InnerRadius = 0;
		}
	}
}
