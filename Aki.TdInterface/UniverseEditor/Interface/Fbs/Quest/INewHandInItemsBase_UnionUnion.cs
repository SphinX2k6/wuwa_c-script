using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004392 RID: 17298
	public class INewHandInItemsBase_UnionUnion
	{
		// Token: 0x170076AB RID: 30379
		// (get) Token: 0x06018734 RID: 100148 RVA: 0x0037C159 File Offset: 0x0037A359
		// (set) Token: 0x06018735 RID: 100149 RVA: 0x0037C161 File Offset: 0x0037A361
		public INewHandInItemsBase_Union Type { get; set; }

		// Token: 0x170076AC RID: 30380
		// (get) Token: 0x06018736 RID: 100150 RVA: 0x0037C16A File Offset: 0x0037A36A
		// (set) Token: 0x06018737 RID: 100151 RVA: 0x0037C172 File Offset: 0x0037A372
		public object Value { get; set; }

		// Token: 0x06018738 RID: 100152 RVA: 0x0037C17B File Offset: 0x0037A37B
		public INewHandInItemsBase_UnionUnion()
		{
			this.Type = INewHandInItemsBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018739 RID: 100153 RVA: 0x0037C191 File Offset: 0x0037A391
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601873A RID: 100154 RVA: 0x0037C1A3 File Offset: 0x0037A3A3
		public INewHandInItemsBaseT AsINewHandInItemsBase()
		{
			return this.As<INewHandInItemsBaseT>();
		}

		// Token: 0x0601873B RID: 100155 RVA: 0x0037C1AB File Offset: 0x0037A3AB
		public static INewHandInItemsBase_UnionUnion FromINewHandInItemsBase(INewHandInItemsBaseT _inewhandinitemsbase)
		{
			return new INewHandInItemsBase_UnionUnion
			{
				Type = INewHandInItemsBase_Union.INewHandInItemsBase,
				Value = _inewhandinitemsbase
			};
		}

		// Token: 0x0601873C RID: 100156 RVA: 0x0037C1C0 File Offset: 0x0037A3C0
		public INewHandInItemsProjectionMachineT AsINewHandInItemsProjectionMachine()
		{
			return this.As<INewHandInItemsProjectionMachineT>();
		}

		// Token: 0x0601873D RID: 100157 RVA: 0x0037C1C8 File Offset: 0x0037A3C8
		public static INewHandInItemsBase_UnionUnion FromINewHandInItemsProjectionMachine(INewHandInItemsProjectionMachineT _inewhandinitemsprojectionmachine)
		{
			return new INewHandInItemsBase_UnionUnion
			{
				Type = INewHandInItemsBase_Union.INewHandInItemsProjectionMachine,
				Value = _inewhandinitemsprojectionmachine
			};
		}

		// Token: 0x0601873E RID: 100158 RVA: 0x0037C1E0 File Offset: 0x0037A3E0
		public static int Pack(FlatBufferBuilder builder, INewHandInItemsBase_UnionUnion _o)
		{
			INewHandInItemsBase_Union type = _o.Type;
			if (type == INewHandInItemsBase_Union.INewHandInItemsBase)
			{
				return INewHandInItemsBase.Pack(builder, _o.AsINewHandInItemsBase()).Value;
			}
			if (type != INewHandInItemsBase_Union.INewHandInItemsProjectionMachine)
			{
				return 0;
			}
			return INewHandInItemsProjectionMachine.Pack(builder, _o.AsINewHandInItemsProjectionMachine()).Value;
		}
	}
}
