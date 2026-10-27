using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007663 RID: 30307
	public class TChangeEntityStateUnion
	{
		// Token: 0x1700E5D5 RID: 58837
		// (get) Token: 0x060372B0 RID: 225968 RVA: 0x0077AA5A File Offset: 0x00778C5A
		// (set) Token: 0x060372B1 RID: 225969 RVA: 0x0077AA62 File Offset: 0x00778C62
		public TChangeEntityState Type { get; set; }

		// Token: 0x1700E5D6 RID: 58838
		// (get) Token: 0x060372B2 RID: 225970 RVA: 0x0077AA6B File Offset: 0x00778C6B
		// (set) Token: 0x060372B3 RID: 225971 RVA: 0x0077AA73 File Offset: 0x00778C73
		public object Value { get; set; }

		// Token: 0x060372B4 RID: 225972 RVA: 0x0077AA7C File Offset: 0x00778C7C
		public TChangeEntityStateUnion()
		{
			this.Type = TChangeEntityState.NONE;
			this.Value = null;
		}

		// Token: 0x060372B5 RID: 225973 RVA: 0x0077AA92 File Offset: 0x00778C92
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372B6 RID: 225974 RVA: 0x0077AAA4 File Offset: 0x00778CA4
		public IChangeEntityStateBatchDirectlyT AsIChangeEntityStateBatchDirectly()
		{
			return this.As<IChangeEntityStateBatchDirectlyT>();
		}

		// Token: 0x060372B7 RID: 225975 RVA: 0x0077AAAC File Offset: 0x00778CAC
		public static TChangeEntityStateUnion FromIChangeEntityStateBatchDirectly(IChangeEntityStateBatchDirectlyT _ichangeentitystatebatchdirectly)
		{
			return new TChangeEntityStateUnion
			{
				Type = TChangeEntityState.IChangeEntityStateBatchDirectly,
				Value = _ichangeentitystatebatchdirectly
			};
		}

		// Token: 0x060372B8 RID: 225976 RVA: 0x0077AAC1 File Offset: 0x00778CC1
		public IChangeEntityStateDirectlyT AsIChangeEntityStateDirectly()
		{
			return this.As<IChangeEntityStateDirectlyT>();
		}

		// Token: 0x060372B9 RID: 225977 RVA: 0x0077AAC9 File Offset: 0x00778CC9
		public static TChangeEntityStateUnion FromIChangeEntityStateDirectly(IChangeEntityStateDirectlyT _ichangeentitystatedirectly)
		{
			return new TChangeEntityStateUnion
			{
				Type = TChangeEntityState.IChangeEntityStateDirectly,
				Value = _ichangeentitystatedirectly
			};
		}

		// Token: 0x060372BA RID: 225978 RVA: 0x0077AADE File Offset: 0x00778CDE
		public IChangeEntityStateLoopT AsIChangeEntityStateLoop()
		{
			return this.As<IChangeEntityStateLoopT>();
		}

		// Token: 0x060372BB RID: 225979 RVA: 0x0077AAE6 File Offset: 0x00778CE6
		public static TChangeEntityStateUnion FromIChangeEntityStateLoop(IChangeEntityStateLoopT _ichangeentitystateloop)
		{
			return new TChangeEntityStateUnion
			{
				Type = TChangeEntityState.IChangeEntityStateLoop,
				Value = _ichangeentitystateloop
			};
		}

		// Token: 0x060372BC RID: 225980 RVA: 0x0077AAFC File Offset: 0x00778CFC
		public static int Pack(FlatBufferBuilder builder, TChangeEntityStateUnion _o)
		{
			switch (_o.Type)
			{
			case TChangeEntityState.IChangeEntityStateBatchDirectly:
				return IChangeEntityStateBatchDirectly.Pack(builder, _o.AsIChangeEntityStateBatchDirectly()).Value;
			case TChangeEntityState.IChangeEntityStateDirectly:
				return IChangeEntityStateDirectly.Pack(builder, _o.AsIChangeEntityStateDirectly()).Value;
			case TChangeEntityState.IChangeEntityStateLoop:
				return IChangeEntityStateLoop.Pack(builder, _o.AsIChangeEntityStateLoop()).Value;
			default:
				return 0;
			}
		}
	}
}
