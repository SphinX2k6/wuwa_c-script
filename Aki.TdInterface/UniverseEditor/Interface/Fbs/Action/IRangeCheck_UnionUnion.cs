using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0E RID: 28174
	public class IRangeCheck_UnionUnion
	{
		// Token: 0x1700D205 RID: 53765
		// (get) Token: 0x06031C7A RID: 203898 RVA: 0x006BD711 File Offset: 0x006BB911
		// (set) Token: 0x06031C7B RID: 203899 RVA: 0x006BD719 File Offset: 0x006BB919
		public IRangeCheck_Union Type { get; set; }

		// Token: 0x1700D206 RID: 53766
		// (get) Token: 0x06031C7C RID: 203900 RVA: 0x006BD722 File Offset: 0x006BB922
		// (set) Token: 0x06031C7D RID: 203901 RVA: 0x006BD72A File Offset: 0x006BB92A
		public object Value { get; set; }

		// Token: 0x06031C7E RID: 203902 RVA: 0x006BD733 File Offset: 0x006BB933
		public IRangeCheck_UnionUnion()
		{
			this.Type = IRangeCheck_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031C7F RID: 203903 RVA: 0x006BD749 File Offset: 0x006BB949
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031C80 RID: 203904 RVA: 0x006BD75B File Offset: 0x006BB95B
		public IRangeCheckT AsIRangeCheck()
		{
			return this.As<IRangeCheckT>();
		}

		// Token: 0x06031C81 RID: 203905 RVA: 0x006BD763 File Offset: 0x006BB963
		public static IRangeCheck_UnionUnion FromIRangeCheck(IRangeCheckT _irangecheck)
		{
			return new IRangeCheck_UnionUnion
			{
				Type = IRangeCheck_Union.IRangeCheck,
				Value = _irangecheck
			};
		}

		// Token: 0x06031C82 RID: 203906 RVA: 0x006BD778 File Offset: 0x006BB978
		public IConeRangeCheckT AsIConeRangeCheck()
		{
			return this.As<IConeRangeCheckT>();
		}

		// Token: 0x06031C83 RID: 203907 RVA: 0x006BD780 File Offset: 0x006BB980
		public static IRangeCheck_UnionUnion FromIConeRangeCheck(IConeRangeCheckT _iconerangecheck)
		{
			return new IRangeCheck_UnionUnion
			{
				Type = IRangeCheck_Union.IConeRangeCheck,
				Value = _iconerangecheck
			};
		}

		// Token: 0x06031C84 RID: 203908 RVA: 0x006BD798 File Offset: 0x006BB998
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
