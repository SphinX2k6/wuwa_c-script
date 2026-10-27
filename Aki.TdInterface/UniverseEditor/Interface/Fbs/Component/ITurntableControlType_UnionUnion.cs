using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFA RID: 23290
	public class ITurntableControlType_UnionUnion
	{
		// Token: 0x1700AFB1 RID: 44977
		// (get) Token: 0x06027C20 RID: 162848 RVA: 0x00577F9A File Offset: 0x0057619A
		// (set) Token: 0x06027C21 RID: 162849 RVA: 0x00577FA2 File Offset: 0x005761A2
		public ITurntableControlType_Union Type { get; set; }

		// Token: 0x1700AFB2 RID: 44978
		// (get) Token: 0x06027C22 RID: 162850 RVA: 0x00577FAB File Offset: 0x005761AB
		// (set) Token: 0x06027C23 RID: 162851 RVA: 0x00577FB3 File Offset: 0x005761B3
		public object Value { get; set; }

		// Token: 0x06027C24 RID: 162852 RVA: 0x00577FBC File Offset: 0x005761BC
		public ITurntableControlType_UnionUnion()
		{
			this.Type = ITurntableControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027C25 RID: 162853 RVA: 0x00577FD2 File Offset: 0x005761D2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027C26 RID: 162854 RVA: 0x00577FE4 File Offset: 0x005761E4
		public ITurntableControlTypeT AsITurntableControlType()
		{
			return this.As<ITurntableControlTypeT>();
		}

		// Token: 0x06027C27 RID: 162855 RVA: 0x00577FEC File Offset: 0x005761EC
		public static ITurntableControlType_UnionUnion FromITurntableControlType(ITurntableControlTypeT _iturntablecontroltype)
		{
			return new ITurntableControlType_UnionUnion
			{
				Type = ITurntableControlType_Union.ITurntableControlType,
				Value = _iturntablecontroltype
			};
		}

		// Token: 0x06027C28 RID: 162856 RVA: 0x00578001 File Offset: 0x00576201
		public IFreeAngleTurntableT AsIFreeAngleTurntable()
		{
			return this.As<IFreeAngleTurntableT>();
		}

		// Token: 0x06027C29 RID: 162857 RVA: 0x00578009 File Offset: 0x00576209
		public static ITurntableControlType_UnionUnion FromIFreeAngleTurntable(IFreeAngleTurntableT _ifreeangleturntable)
		{
			return new ITurntableControlType_UnionUnion
			{
				Type = ITurntableControlType_Union.IFreeAngleTurntable,
				Value = _ifreeangleturntable
			};
		}

		// Token: 0x06027C2A RID: 162858 RVA: 0x0057801E File Offset: 0x0057621E
		public IFixedAngleTurntableT AsIFixedAngleTurntable()
		{
			return this.As<IFixedAngleTurntableT>();
		}

		// Token: 0x06027C2B RID: 162859 RVA: 0x00578026 File Offset: 0x00576226
		public static ITurntableControlType_UnionUnion FromIFixedAngleTurntable(IFixedAngleTurntableT _ifixedangleturntable)
		{
			return new ITurntableControlType_UnionUnion
			{
				Type = ITurntableControlType_Union.IFixedAngleTurntable,
				Value = _ifixedangleturntable
			};
		}

		// Token: 0x06027C2C RID: 162860 RVA: 0x0057803C File Offset: 0x0057623C
		public static int Pack(FlatBufferBuilder builder, ITurntableControlType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITurntableControlType_Union.ITurntableControlType:
				return ITurntableControlType.Pack(builder, _o.AsITurntableControlType()).Value;
			case ITurntableControlType_Union.IFreeAngleTurntable:
				return IFreeAngleTurntable.Pack(builder, _o.AsIFreeAngleTurntable()).Value;
			case ITurntableControlType_Union.IFixedAngleTurntable:
				return IFixedAngleTurntable.Pack(builder, _o.AsIFixedAngleTurntable()).Value;
			default:
				return 0;
			}
		}
	}
}
