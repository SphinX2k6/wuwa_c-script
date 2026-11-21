using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051B2 RID: 20914
	public class IRoleLevelType_UnionUnion
	{
		// Token: 0x170095C8 RID: 38344
		// (get) Token: 0x06020EBF RID: 134847 RVA: 0x0048DD01 File Offset: 0x0048BF01
		// (set) Token: 0x06020EC0 RID: 134848 RVA: 0x0048DD09 File Offset: 0x0048BF09
		public IRoleLevelType_Union Type { get; set; }

		// Token: 0x170095C9 RID: 38345
		// (get) Token: 0x06020EC1 RID: 134849 RVA: 0x0048DD12 File Offset: 0x0048BF12
		// (set) Token: 0x06020EC2 RID: 134850 RVA: 0x0048DD1A File Offset: 0x0048BF1A
		public object Value { get; set; }

		// Token: 0x06020EC3 RID: 134851 RVA: 0x0048DD23 File Offset: 0x0048BF23
		public IRoleLevelType_UnionUnion()
		{
			this.Type = IRoleLevelType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020EC4 RID: 134852 RVA: 0x0048DD39 File Offset: 0x0048BF39
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020EC5 RID: 134853 RVA: 0x0048DD4B File Offset: 0x0048BF4B
		public IRoleLevelTypeT AsIRoleLevelType()
		{
			return this.As<IRoleLevelTypeT>();
		}

		// Token: 0x06020EC6 RID: 134854 RVA: 0x0048DD53 File Offset: 0x0048BF53
		public static IRoleLevelType_UnionUnion FromIRoleLevelType(IRoleLevelTypeT _iroleleveltype)
		{
			return new IRoleLevelType_UnionUnion
			{
				Type = IRoleLevelType_Union.IRoleLevelType,
				Value = _iroleleveltype
			};
		}

		// Token: 0x06020EC7 RID: 134855 RVA: 0x0048DD68 File Offset: 0x0048BF68
		public ISpecifyRoleLevelT AsISpecifyRoleLevel()
		{
			return this.As<ISpecifyRoleLevelT>();
		}

		// Token: 0x06020EC8 RID: 134856 RVA: 0x0048DD70 File Offset: 0x0048BF70
		public static IRoleLevelType_UnionUnion FromISpecifyRoleLevel(ISpecifyRoleLevelT _ispecifyrolelevel)
		{
			return new IRoleLevelType_UnionUnion
			{
				Type = IRoleLevelType_Union.ISpecifyRoleLevel,
				Value = _ispecifyrolelevel
			};
		}

		// Token: 0x06020EC9 RID: 134857 RVA: 0x0048DD88 File Offset: 0x0048BF88
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
