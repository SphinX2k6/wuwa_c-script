using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006265 RID: 25189
	public class TInhaledPerResultTypeUnion
	{
		// Token: 0x1700BB5A RID: 47962
		// (get) Token: 0x0602ADEF RID: 175599 RVA: 0x005DA3FE File Offset: 0x005D85FE
		// (set) Token: 0x0602ADF0 RID: 175600 RVA: 0x005DA406 File Offset: 0x005D8606
		public TInhaledPerResultType Type { get; set; }

		// Token: 0x1700BB5B RID: 47963
		// (get) Token: 0x0602ADF1 RID: 175601 RVA: 0x005DA40F File Offset: 0x005D860F
		// (set) Token: 0x0602ADF2 RID: 175602 RVA: 0x005DA417 File Offset: 0x005D8617
		public object Value { get; set; }

		// Token: 0x0602ADF3 RID: 175603 RVA: 0x005DA420 File Offset: 0x005D8620
		public TInhaledPerResultTypeUnion()
		{
			this.Type = TInhaledPerResultType.NONE;
			this.Value = null;
		}

		// Token: 0x0602ADF4 RID: 175604 RVA: 0x005DA436 File Offset: 0x005D8636
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ADF5 RID: 175605 RVA: 0x005DA448 File Offset: 0x005D8648
		public IInhaledChangeSelfStateT AsIInhaledChangeSelfState()
		{
			return this.As<IInhaledChangeSelfStateT>();
		}

		// Token: 0x0602ADF6 RID: 175606 RVA: 0x005DA450 File Offset: 0x005D8650
		public static TInhaledPerResultTypeUnion FromIInhaledChangeSelfState(IInhaledChangeSelfStateT _iinhaledchangeselfstate)
		{
			return new TInhaledPerResultTypeUnion
			{
				Type = TInhaledPerResultType.IInhaledChangeSelfState,
				Value = _iinhaledchangeselfstate
			};
		}

		// Token: 0x0602ADF7 RID: 175607 RVA: 0x005DA465 File Offset: 0x005D8665
		public IInhaledDestroySelfT AsIInhaledDestroySelf()
		{
			return this.As<IInhaledDestroySelfT>();
		}

		// Token: 0x0602ADF8 RID: 175608 RVA: 0x005DA46D File Offset: 0x005D866D
		public static TInhaledPerResultTypeUnion FromIInhaledDestroySelf(IInhaledDestroySelfT _iinhaleddestroyself)
		{
			return new TInhaledPerResultTypeUnion
			{
				Type = TInhaledPerResultType.IInhaledDestroySelf,
				Value = _iinhaleddestroyself
			};
		}

		// Token: 0x0602ADF9 RID: 175609 RVA: 0x005DA484 File Offset: 0x005D8684
		public static int Pack(FlatBufferBuilder builder, TInhaledPerResultTypeUnion _o)
		{
			TInhaledPerResultType type = _o.Type;
			if (type == TInhaledPerResultType.IInhaledChangeSelfState)
			{
				return IInhaledChangeSelfState.Pack(builder, _o.AsIInhaledChangeSelfState()).Value;
			}
			if (type != TInhaledPerResultType.IInhaledDestroySelf)
			{
				return 0;
			}
			return IInhaledDestroySelf.Pack(builder, _o.AsIInhaledDestroySelf()).Value;
		}
	}
}
