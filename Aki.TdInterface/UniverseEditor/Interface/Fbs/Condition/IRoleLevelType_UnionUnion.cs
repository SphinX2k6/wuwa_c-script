using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB9 RID: 19641
	public class IRoleLevelType_UnionUnion
	{
		// Token: 0x17008E9A RID: 36506
		// (get) Token: 0x0601F29D RID: 127645 RVA: 0x0045A1B1 File Offset: 0x004583B1
		// (set) Token: 0x0601F29E RID: 127646 RVA: 0x0045A1B9 File Offset: 0x004583B9
		public IRoleLevelType_Union Type { get; set; }

		// Token: 0x17008E9B RID: 36507
		// (get) Token: 0x0601F29F RID: 127647 RVA: 0x0045A1C2 File Offset: 0x004583C2
		// (set) Token: 0x0601F2A0 RID: 127648 RVA: 0x0045A1CA File Offset: 0x004583CA
		public object Value { get; set; }

		// Token: 0x0601F2A1 RID: 127649 RVA: 0x0045A1D3 File Offset: 0x004583D3
		public IRoleLevelType_UnionUnion()
		{
			this.Type = IRoleLevelType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F2A2 RID: 127650 RVA: 0x0045A1E9 File Offset: 0x004583E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F2A3 RID: 127651 RVA: 0x0045A1FB File Offset: 0x004583FB
		public IRoleLevelTypeT AsIRoleLevelType()
		{
			return this.As<IRoleLevelTypeT>();
		}

		// Token: 0x0601F2A4 RID: 127652 RVA: 0x0045A203 File Offset: 0x00458403
		public static IRoleLevelType_UnionUnion FromIRoleLevelType(IRoleLevelTypeT _iroleleveltype)
		{
			return new IRoleLevelType_UnionUnion
			{
				Type = IRoleLevelType_Union.IRoleLevelType,
				Value = _iroleleveltype
			};
		}

		// Token: 0x0601F2A5 RID: 127653 RVA: 0x0045A218 File Offset: 0x00458418
		public ISpecifyRoleLevelT AsISpecifyRoleLevel()
		{
			return this.As<ISpecifyRoleLevelT>();
		}

		// Token: 0x0601F2A6 RID: 127654 RVA: 0x0045A220 File Offset: 0x00458420
		public static IRoleLevelType_UnionUnion FromISpecifyRoleLevel(ISpecifyRoleLevelT _ispecifyrolelevel)
		{
			return new IRoleLevelType_UnionUnion
			{
				Type = IRoleLevelType_Union.ISpecifyRoleLevel,
				Value = _ispecifyrolelevel
			};
		}

		// Token: 0x0601F2A7 RID: 127655 RVA: 0x0045A238 File Offset: 0x00458438
		public static int Pack(FlatBufferBuilder builder, IRoleLevelType_UnionUnion _o)
		{
			IRoleLevelType_Union type = _o.Type;
			if (type == IRoleLevelType_Union.IRoleLevelType)
			{
				return IRoleLevelType.Pack(builder, _o.AsIRoleLevelType()).Value;
			}
			if (type != IRoleLevelType_Union.ISpecifyRoleLevel)
			{
				return 0;
			}
			return ISpecifyRoleLevel.Pack(builder, _o.AsISpecifyRoleLevel()).Value;
		}
	}
}
