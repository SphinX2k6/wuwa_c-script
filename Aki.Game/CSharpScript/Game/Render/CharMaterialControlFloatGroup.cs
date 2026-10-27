using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045B4 RID: 17844
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlFloatGroup
	{
		// Token: 0x0602E04F RID: 188495 RVA: 0x00A993B0 File Offset: 0x00A975B0
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

		// Token: 0x04018926 RID: 100646
		public FKuroCurveFloat End;

		// Token: 0x04018927 RID: 100647
		public FKuroCurveFloat Loop;

		// Token: 0x04018928 RID: 100648
		public FKuroCurveFloat Start;

		// Token: 0x04018929 RID: 100649
		public float? EndConstant;

		// Token: 0x0401892A RID: 100650
		public float? LoopConstant;

		// Token: 0x0401892B RID: 100651
		public float? StartConstant;
	}
}
