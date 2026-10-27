using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005166 RID: 20838
	public class IEntityBatchType_UnionUnion
	{
		// Token: 0x170097FD RID: 38909
		// (get) Token: 0x06021A4E RID: 137806 RVA: 0x004AB4A1 File Offset: 0x004A96A1
		// (set) Token: 0x06021A4F RID: 137807 RVA: 0x004AB4A9 File Offset: 0x004A96A9
		public IEntityBatchType_Union Type { get; set; }

		// Token: 0x170097FE RID: 38910
		// (get) Token: 0x06021A50 RID: 137808 RVA: 0x004AB4B2 File Offset: 0x004A96B2
		// (set) Token: 0x06021A51 RID: 137809 RVA: 0x004AB4BA File Offset: 0x004A96BA
		public object Value { get; set; }

		// Token: 0x06021A52 RID: 137810 RVA: 0x004AB4C3 File Offset: 0x004A96C3
		public IEntityBatchType_UnionUnion()
		{
			this.Type = IEntityBatchType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021A53 RID: 137811 RVA: 0x004AB4D9 File Offset: 0x004A96D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021A54 RID: 137812 RVA: 0x004AB4EB File Offset: 0x004A96EB
		public IEntityBatchTypeT AsIEntityBatchType()
		{
			return this.As<IEntityBatchTypeT>();
		}

		// Token: 0x06021A55 RID: 137813 RVA: 0x004AB4F3 File Offset: 0x004A96F3
		public static IEntityBatchType_UnionUnion FromIEntityBatchType(IEntityBatchTypeT _ientitybatchtype)
		{
			return new IEntityBatchType_UnionUnion
			{
				Type = IEntityBatchType_Union.IEntityBatchType,
				Value = _ientitybatchtype
			};
		}

		// Token: 0x06021A56 RID: 137814 RVA: 0x004AB508 File Offset: 0x004A9708
		public IEntityListBatchT AsIEntityListBatch()
		{
			return this.As<IEntityListBatchT>();
		}

		// Token: 0x06021A57 RID: 137815 RVA: 0x004AB510 File Offset: 0x004A9710
		public static IEntityBatchType_UnionUnion FromIEntityListBatch(IEntityListBatchT _ientitylistbatch)
		{
			return new IEntityBatchType_UnionUnion
			{
				Type = IEntityBatchType_Union.IEntityListBatch,
				Value = _ientitylistbatch
			};
		}

		// Token: 0x06021A58 RID: 137816 RVA: 0x004AB528 File Offset: 0x004A9728
		public static int Pack(FlatBufferBuilder builder, IEntityBatchType_UnionUnion _o)
		{
			IEntityBatchType_Union type = _o.Type;
			if (type == IEntityBatchType_Union.IEntityBatchType)
			{
				return IEntityBatchType.Pack(builder, _o.AsIEntityBatchType()).Value;
			}
			if (type != IEntityBatchType_Union.IEntityListBatch)
			{
				return 0;
			}
			return IEntityListBatch.Pack(builder, _o.AsIEntityListBatch()).Value;
		}
	}
}
