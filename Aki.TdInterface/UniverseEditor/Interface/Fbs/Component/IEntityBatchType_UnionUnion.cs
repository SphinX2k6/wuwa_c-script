using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CB RID: 22219
	public class IEntityBatchType_UnionUnion
	{
		// Token: 0x17009FEA RID: 40938
		// (get) Token: 0x060239A2 RID: 145826 RVA: 0x004E542D File Offset: 0x004E362D
		// (set) Token: 0x060239A3 RID: 145827 RVA: 0x004E5435 File Offset: 0x004E3635
		public IEntityBatchType_Union Type { get; set; }

		// Token: 0x17009FEB RID: 40939
		// (get) Token: 0x060239A4 RID: 145828 RVA: 0x004E543E File Offset: 0x004E363E
		// (set) Token: 0x060239A5 RID: 145829 RVA: 0x004E5446 File Offset: 0x004E3646
		public object Value { get; set; }

		// Token: 0x060239A6 RID: 145830 RVA: 0x004E544F File Offset: 0x004E364F
		public IEntityBatchType_UnionUnion()
		{
			this.Type = IEntityBatchType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060239A7 RID: 145831 RVA: 0x004E5465 File Offset: 0x004E3665
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060239A8 RID: 145832 RVA: 0x004E5477 File Offset: 0x004E3677
		public IEntityBatchTypeT AsIEntityBatchType()
		{
			return this.As<IEntityBatchTypeT>();
		}

		// Token: 0x060239A9 RID: 145833 RVA: 0x004E547F File Offset: 0x004E367F
		public static IEntityBatchType_UnionUnion FromIEntityBatchType(IEntityBatchTypeT _ientitybatchtype)
		{
			return new IEntityBatchType_UnionUnion
			{
				Type = IEntityBatchType_Union.IEntityBatchType,
				Value = _ientitybatchtype
			};
		}

		// Token: 0x060239AA RID: 145834 RVA: 0x004E5494 File Offset: 0x004E3694
		public IEntityListBatchT AsIEntityListBatch()
		{
			return this.As<IEntityListBatchT>();
		}

		// Token: 0x060239AB RID: 145835 RVA: 0x004E549C File Offset: 0x004E369C
		public static IEntityBatchType_UnionUnion FromIEntityListBatch(IEntityListBatchT _ientitylistbatch)
		{
			return new IEntityBatchType_UnionUnion
			{
				Type = IEntityBatchType_Union.IEntityListBatch,
				Value = _ientitylistbatch
			};
		}

		// Token: 0x060239AC RID: 145836 RVA: 0x004E54B4 File Offset: 0x004E36B4
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
