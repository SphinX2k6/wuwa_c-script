using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750F RID: 29967
	public class IVehicleEnteringTarget_UnionUnion
	{
		// Token: 0x1700E366 RID: 58214
		// (get) Token: 0x060367F6 RID: 223222 RVA: 0x00767250 File Offset: 0x00765450
		// (set) Token: 0x060367F7 RID: 223223 RVA: 0x00767258 File Offset: 0x00765458
		public IVehicleEnteringTarget_Union Type { get; set; }

		// Token: 0x1700E367 RID: 58215
		// (get) Token: 0x060367F8 RID: 223224 RVA: 0x00767261 File Offset: 0x00765461
		// (set) Token: 0x060367F9 RID: 223225 RVA: 0x00767269 File Offset: 0x00765469
		public object Value { get; set; }

		// Token: 0x060367FA RID: 223226 RVA: 0x00767272 File Offset: 0x00765472
		public IVehicleEnteringTarget_UnionUnion()
		{
			this.Type = IVehicleEnteringTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060367FB RID: 223227 RVA: 0x00767288 File Offset: 0x00765488
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060367FC RID: 223228 RVA: 0x0076729A File Offset: 0x0076549A
		public IVehicleEnteringTargetT AsIVehicleEnteringTarget()
		{
			return this.As<IVehicleEnteringTargetT>();
		}

		// Token: 0x060367FD RID: 223229 RVA: 0x007672A2 File Offset: 0x007654A2
		public static IVehicleEnteringTarget_UnionUnion FromIVehicleEnteringTarget(IVehicleEnteringTargetT _ivehicleenteringtarget)
		{
			return new IVehicleEnteringTarget_UnionUnion
			{
				Type = IVehicleEnteringTarget_Union.IVehicleEnteringTarget,
				Value = _ivehicleenteringtarget
			};
		}

		// Token: 0x060367FE RID: 223230 RVA: 0x007672B7 File Offset: 0x007654B7
		public IVehicleEnteringPlayerTargetT AsIVehicleEnteringPlayerTarget()
		{
			return this.As<IVehicleEnteringPlayerTargetT>();
		}

		// Token: 0x060367FF RID: 223231 RVA: 0x007672BF File Offset: 0x007654BF
		public static IVehicleEnteringTarget_UnionUnion FromIVehicleEnteringPlayerTarget(IVehicleEnteringPlayerTargetT _ivehicleenteringplayertarget)
		{
			return new IVehicleEnteringTarget_UnionUnion
			{
				Type = IVehicleEnteringTarget_Union.IVehicleEnteringPlayerTarget,
				Value = _ivehicleenteringplayertarget
			};
		}

		// Token: 0x06036800 RID: 223232 RVA: 0x007672D4 File Offset: 0x007654D4
		public IVehicleEnteringNpcTargetT AsIVehicleEnteringNpcTarget()
		{
			return this.As<IVehicleEnteringNpcTargetT>();
		}

		// Token: 0x06036801 RID: 223233 RVA: 0x007672DC File Offset: 0x007654DC
		public static IVehicleEnteringTarget_UnionUnion FromIVehicleEnteringNpcTarget(IVehicleEnteringNpcTargetT _ivehicleenteringnpctarget)
		{
			return new IVehicleEnteringTarget_UnionUnion
			{
				Type = IVehicleEnteringTarget_Union.IVehicleEnteringNpcTarget,
				Value = _ivehicleenteringnpctarget
			};
		}

		// Token: 0x06036802 RID: 223234 RVA: 0x007672F4 File Offset: 0x007654F4
		public static int Pack(FlatBufferBuilder builder, IVehicleEnteringTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVehicleEnteringTarget_Union.IVehicleEnteringTarget:
				return IVehicleEnteringTarget.Pack(builder, _o.AsIVehicleEnteringTarget()).Value;
			case IVehicleEnteringTarget_Union.IVehicleEnteringPlayerTarget:
				return IVehicleEnteringPlayerTarget.Pack(builder, _o.AsIVehicleEnteringPlayerTarget()).Value;
			case IVehicleEnteringTarget_Union.IVehicleEnteringNpcTarget:
				return IVehicleEnteringNpcTarget.Pack(builder, _o.AsIVehicleEnteringNpcTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
