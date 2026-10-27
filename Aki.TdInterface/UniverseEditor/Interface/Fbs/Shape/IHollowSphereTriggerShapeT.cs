using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C23 RID: 15395
	public class IHollowSphereTriggerShapeT
	{
		// Token: 0x170069FA RID: 27130
		// (get) Token: 0x060153E5 RID: 87013 RVA: 0x0031370F File Offset: 0x0031190F
		// (set) Token: 0x060153E6 RID: 87014 RVA: 0x00313717 File Offset: 0x00311917
		public ETriggerShape Type { get; set; }

		// Token: 0x170069FB RID: 27131
		// (get) Token: 0x060153E7 RID: 87015 RVA: 0x00313720 File Offset: 0x00311920
		// (set) Token: 0x060153E8 RID: 87016 RVA: 0x00313728 File Offset: 0x00311928
		public IVectorInfoT Center { get; set; }

		// Token: 0x170069FC RID: 27132
		// (get) Token: 0x060153E9 RID: 87017 RVA: 0x00313731 File Offset: 0x00311931
		// (set) Token: 0x060153EA RID: 87018 RVA: 0x00313739 File Offset: 0x00311939
		public int Radius { get; set; }

		// Token: 0x170069FD RID: 27133
		// (get) Token: 0x060153EB RID: 87019 RVA: 0x00313742 File Offset: 0x00311942
		// (set) Token: 0x060153EC RID: 87020 RVA: 0x0031374A File Offset: 0x0031194A
		public int InnerRadius { get; set; }

		// Token: 0x060153ED RID: 87021 RVA: 0x00313753 File Offset: 0x00311953
		public IHollowSphereTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.InnerRadius = 0;
		}
	}
}
