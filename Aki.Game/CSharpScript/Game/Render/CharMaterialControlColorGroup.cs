using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045B5 RID: 17845
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlColorGroup
	{
		// Token: 0x0602E050 RID: 188496 RVA: 0x00A99428 File Offset: 0x00A97628
		[NullableContext(1)]
		public CharMaterialControlColorGroup(FKuroCurveLinearColor end, FKuroCurveLinearColor loop, FKuroCurveLinearColor start)
		{
			if (end.bUseCurve)
			{
				this.End = end;
			}
			else
			{
				this.EndConstant = new FLinearColor?(end.Constant);
			}
			if (loop.bUseCurve)
			{
				this.Loop = loop;
			}
			else
			{
				this.LoopConstant = new FLinearColor?(loop.Constant);
			}
			if (start.bUseCurve)
			{
				this.Start = start;
				return;
			}
			this.StartConstant = new FLinearColor?(start.Constant);
		}

		// Token: 0x0401892C RID: 100652
		public FKuroCurveLinearColor End;

		// Token: 0x0401892D RID: 100653
		public FKuroCurveLinearColor Loop;

		// Token: 0x0401892E RID: 100654
		public FKuroCurveLinearColor Start;

		// Token: 0x0401892F RID: 100655
		public FLinearColor? EndConstant;

		// Token: 0x04018930 RID: 100656
		public FLinearColor? LoopConstant;

		// Token: 0x04018931 RID: 100657
		public FLinearColor? StartConstant;
	}
}
