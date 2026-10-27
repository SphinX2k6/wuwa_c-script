using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005770 RID: 22384
	public class IPortalMode_UnionUnion
	{
		// Token: 0x1700A6F3 RID: 42739
		// (get) Token: 0x06025833 RID: 153651 RVA: 0x0052CC67 File Offset: 0x0052AE67
		// (set) Token: 0x06025834 RID: 153652 RVA: 0x0052CC6F File Offset: 0x0052AE6F
		public IPortalMode_Union Type { get; set; }

		// Token: 0x1700A6F4 RID: 42740
		// (get) Token: 0x06025835 RID: 153653 RVA: 0x0052CC78 File Offset: 0x0052AE78
		// (set) Token: 0x06025836 RID: 153654 RVA: 0x0052CC80 File Offset: 0x0052AE80
		public object Value { get; set; }

		// Token: 0x06025837 RID: 153655 RVA: 0x0052CC89 File Offset: 0x0052AE89
		public IPortalMode_UnionUnion()
		{
			this.Type = IPortalMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025838 RID: 153656 RVA: 0x0052CC9F File Offset: 0x0052AE9F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025839 RID: 153657 RVA: 0x0052CCB1 File Offset: 0x0052AEB1
		public IPortalModeT AsIPortalMode()
		{
			return this.As<IPortalModeT>();
		}

		// Token: 0x0602583A RID: 153658 RVA: 0x0052CCB9 File Offset: 0x0052AEB9
		public static IPortalMode_UnionUnion FromIPortalMode(IPortalModeT _iportalmode)
		{
			return new IPortalMode_UnionUnion
			{
				Type = IPortalMode_Union.IPortalMode,
				Value = _iportalmode
			};
		}

		// Token: 0x0602583B RID: 153659 RVA: 0x0052CCCE File Offset: 0x0052AECE
		public IStaticPortalT AsIStaticPortal()
		{
			return this.As<IStaticPortalT>();
		}

		// Token: 0x0602583C RID: 153660 RVA: 0x0052CCD6 File Offset: 0x0052AED6
		public static IPortalMode_UnionUnion FromIStaticPortal(IStaticPortalT _istaticportal)
		{
			return new IPortalMode_UnionUnion
			{
				Type = IPortalMode_Union.IStaticPortal,
				Value = _istaticportal
			};
		}

		// Token: 0x0602583D RID: 153661 RVA: 0x0052CCEB File Offset: 0x0052AEEB
		public IDynamicPortalT AsIDynamicPortal()
		{
			return this.As<IDynamicPortalT>();
		}

		// Token: 0x0602583E RID: 153662 RVA: 0x0052CCF3 File Offset: 0x0052AEF3
		public static IPortalMode_UnionUnion FromIDynamicPortal(IDynamicPortalT _idynamicportal)
		{
			return new IPortalMode_UnionUnion
			{
				Type = IPortalMode_Union.IDynamicPortal,
				Value = _idynamicportal
			};
		}

		// Token: 0x0602583F RID: 153663 RVA: 0x0052CD08 File Offset: 0x0052AF08
		public static int Pack(FlatBufferBuilder builder, IPortalMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPortalMode_Union.IPortalMode:
				return IPortalMode.Pack(builder, _o.AsIPortalMode()).Value;
			case IPortalMode_Union.IStaticPortal:
				return IStaticPortal.Pack(builder, _o.AsIStaticPortal()).Value;
			case IPortalMode_Union.IDynamicPortal:
				return IDynamicPortal.Pack(builder, _o.AsIDynamicPortal()).Value;
			default:
				return 0;
			}
		}
	}
}
