using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034DD RID: 13533
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlColorGroup
	{
		// Token: 0x0602273A RID: 141114 RVA: 0x009C5648 File Offset: 0x009C3848
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

		// Token: 0x04012F67 RID: 77671
		public FKuroCurveLinearColor End;

		// Token: 0x04012F68 RID: 77672
		public FKuroCurveLinearColor Loop;

		// Token: 0x04012F69 RID: 77673
		public FKuroCurveLinearColor Start;

		// Token: 0x04012F6A RID: 77674
		public FLinearColor? EndConstant;

		// Token: 0x04012F6B RID: 77675
		public FLinearColor? LoopConstant;

		// Token: 0x04012F6C RID: 77676
		public FLinearColor? StartConstant;
	}
}
