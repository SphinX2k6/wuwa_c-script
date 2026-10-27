using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F54 RID: 16212
	public class INewHandInItemsBase_UnionUnion
	{
		// Token: 0x170070BA RID: 28858
		// (get) Token: 0x060170D2 RID: 94418 RVA: 0x00352CE5 File Offset: 0x00350EE5
		// (set) Token: 0x060170D3 RID: 94419 RVA: 0x00352CED File Offset: 0x00350EED
		public INewHandInItemsBase_Union Type { get; set; }

		// Token: 0x170070BB RID: 28859
		// (get) Token: 0x060170D4 RID: 94420 RVA: 0x00352CF6 File Offset: 0x00350EF6
		// (set) Token: 0x060170D5 RID: 94421 RVA: 0x00352CFE File Offset: 0x00350EFE
		public object Value { get; set; }

		// Token: 0x060170D6 RID: 94422 RVA: 0x00352D07 File Offset: 0x00350F07
		public INewHandInItemsBase_UnionUnion()
		{
			this.Type = INewHandInItemsBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060170D7 RID: 94423 RVA: 0x00352D1D File Offset: 0x00350F1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060170D8 RID: 94424 RVA: 0x00352D2F File Offset: 0x00350F2F
		public INewHandInItemsBaseT AsINewHandInItemsBase()
		{
			return this.As<INewHandInItemsBaseT>();
		}

		// Token: 0x060170D9 RID: 94425 RVA: 0x00352D37 File Offset: 0x00350F37
		public static INewHandInItemsBase_UnionUnion FromINewHandInItemsBase(INewHandInItemsBaseT _inewhandinitemsbase)
		{
			return new INewHandInItemsBase_UnionUnion
			{
				Type = INewHandInItemsBase_Union.INewHandInItemsBase,
				Value = _inewhandinitemsbase
			};
		}

		// Token: 0x060170DA RID: 94426 RVA: 0x00352D4C File Offset: 0x00350F4C
		public INewHandInItemsProjectionMachineT AsINewHandInItemsProjectionMachine()
		{
			return this.As<INewHandInItemsProjectionMachineT>();
		}

		// Token: 0x060170DB RID: 94427 RVA: 0x00352D54 File Offset: 0x00350F54
		public static INewHandInItemsBase_UnionUnion FromINewHandInItemsProjectionMachine(INewHandInItemsProjectionMachineT _inewhandinitemsprojectionmachine)
		{
			return new INewHandInItemsBase_UnionUnion
			{
				Type = INewHandInItemsBase_Union.INewHandInItemsProjectionMachine,
				Value = _inewhandinitemsprojectionmachine
			};
		}

		// Token: 0x060170DC RID: 94428 RVA: 0x00352D6C File Offset: 0x00350F6C
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
