using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034DC RID: 13532
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlFloatGroup
	{
		// Token: 0x06022739 RID: 141113 RVA: 0x009C55D0 File Offset: 0x009C37D0
		[NullableContext(1)]
		public CharMaterialControlFloatGroup(FKuroCurveFloat end, FKuroCurveFloat loop, FKuroCurveFloat start)
		{
			if (end.bUseCurve)
			{
				this.End = end;
			}
			else
			{
				this.EndConstant = new float?(end.Constant);
			}
			if (loop.bUseCurve)
			{
				this.Loop = loop;
			}
			else
			{
				this.LoopConstant = new float?(loop.Constant);
			}
			if (start.bUseCurve)
			{
				this.Start = start;
				return;
			}
			this.StartConstant = new float?(start.Constant);
		}

		// Token: 0x04012F61 RID: 77665
		public FKuroCurveFloat End;

		// Token: 0x04012F62 RID: 77666
		public FKuroCurveFloat Loop;

		// Token: 0x04012F63 RID: 77667
		public FKuroCurveFloat Start;

		// Token: 0x04012F64 RID: 77668
		public float? EndConstant;

		// Token: 0x04012F65 RID: 77669
		public float? LoopConstant;

		// Token: 0x04012F66 RID: 77670
		public float? StartConstant;
	}
}
