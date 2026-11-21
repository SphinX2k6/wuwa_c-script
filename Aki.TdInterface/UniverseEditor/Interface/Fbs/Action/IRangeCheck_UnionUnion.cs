using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007589 RID: 30089
	public class IRangeCheck_UnionUnion
	{
		// Token: 0x1700DD4D RID: 56653
		// (get) Token: 0x06034C76 RID: 216182 RVA: 0x00718DF9 File Offset: 0x00716FF9
		// (set) Token: 0x06034C77 RID: 216183 RVA: 0x00718E01 File Offset: 0x00717001
		public IRangeCheck_Union Type { get; set; }

		// Token: 0x1700DD4E RID: 56654
		// (get) Token: 0x06034C78 RID: 216184 RVA: 0x00718E0A File Offset: 0x0071700A
		// (set) Token: 0x06034C79 RID: 216185 RVA: 0x00718E12 File Offset: 0x00717012
		public object Value { get; set; }

		// Token: 0x06034C7A RID: 216186 RVA: 0x00718E1B File Offset: 0x0071701B
		public IRangeCheck_UnionUnion()
		{
			this.Type = IRangeCheck_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034C7B RID: 216187 RVA: 0x00718E31 File Offset: 0x00717031
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034C7C RID: 216188 RVA: 0x00718E43 File Offset: 0x00717043
		public IRangeCheckT AsIRangeCheck()
		{
			return this.As<IRangeCheckT>();
		}

		// Token: 0x06034C7D RID: 216189 RVA: 0x00718E4B File Offset: 0x0071704B
		public static IRangeCheck_UnionUnion FromIRangeCheck(IRangeCheckT _irangecheck)
		{
			return new IRangeCheck_UnionUnion
			{
				Type = IRangeCheck_Union.IRangeCheck,
				Value = _irangecheck
			};
		}

		// Token: 0x06034C7E RID: 216190 RVA: 0x00718E60 File Offset: 0x00717060
		public IConeRangeCheckT AsIConeRangeCheck()
		{
			return this.As<IConeRangeCheckT>();
		}

		// Token: 0x06034C7F RID: 216191 RVA: 0x00718E68 File Offset: 0x00717068
		public static IRangeCheck_UnionUnion FromIConeRangeCheck(IConeRangeCheckT _iconerangecheck)
		{
			return new IRangeCheck_UnionUnion
			{
				Type = IRangeCheck_Union.IConeRangeCheck,
				Value = _iconerangecheck
			};
		}

		// Token: 0x06034C80 RID: 216192 RVA: 0x00718E80 File Offset: 0x00717080
		public static int Pack(FlatBufferBuilder builder, IRangeCheck_UnionUnion _o)
		{
			IRangeCheck_Union type = _o.Type;
			if (type == IRangeCheck_Union.IRangeCheck)
			{
				return IRangeCheck.Pack(builder, _o.AsIRangeCheck()).Value;
			}
			if (type != IRangeCheck_Union.IConeRangeCheck)
			{
				return 0;
			}
			return IConeRangeCheck.Pack(builder, _o.AsIConeRangeCheck()).Value;
		}
	}
}
