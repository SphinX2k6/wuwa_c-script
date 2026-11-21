using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D05 RID: 32005
	public class IVehicleEnteringTarget_UnionUnion
	{
		// Token: 0x1700EF90 RID: 61328
		// (get) Token: 0x06039C0B RID: 236555 RVA: 0x007CA4A0 File Offset: 0x007C86A0
		// (set) Token: 0x06039C0C RID: 236556 RVA: 0x007CA4A8 File Offset: 0x007C86A8
		public IVehicleEnteringTarget_Union Type { get; set; }

		// Token: 0x1700EF91 RID: 61329
		// (get) Token: 0x06039C0D RID: 236557 RVA: 0x007CA4B1 File Offset: 0x007C86B1
		// (set) Token: 0x06039C0E RID: 236558 RVA: 0x007CA4B9 File Offset: 0x007C86B9
		public object Value { get; set; }

		// Token: 0x06039C0F RID: 236559 RVA: 0x007CA4C2 File Offset: 0x007C86C2
		public IVehicleEnteringTarget_UnionUnion()
		{
			this.Type = IVehicleEnteringTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039C10 RID: 236560 RVA: 0x007CA4D8 File Offset: 0x007C86D8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039C11 RID: 236561 RVA: 0x007CA4EA File Offset: 0x007C86EA
		public IVehicleEnteringTargetT AsIVehicleEnteringTarget()
		{
			return this.As<IVehicleEnteringTargetT>();
		}

		// Token: 0x06039C12 RID: 236562 RVA: 0x007CA4F2 File Offset: 0x007C86F2
		public static IVehicleEnteringTarget_UnionUnion FromIVehicleEnteringTarget(IVehicleEnteringTargetT _ivehicleenteringtarget)
		{
			return new IVehicleEnteringTarget_UnionUnion
			{
				Type = IVehicleEnteringTarget_Union.IVehicleEnteringTarget,
				Value = _ivehicleenteringtarget
			};
		}

		// Token: 0x06039C13 RID: 236563 RVA: 0x007CA507 File Offset: 0x007C8707
		public IVehicleEnteringPlayerTargetT AsIVehicleEnteringPlayerTarget()
		{
			return this.As<IVehicleEnteringPlayerTargetT>();
		}

		// Token: 0x06039C14 RID: 236564 RVA: 0x007CA50F File Offset: 0x007C870F
		public static IVehicleEnteringTarget_UnionUnion FromIVehicleEnteringPlayerTarget(IVehicleEnteringPlayerTargetT _ivehicleenteringplayertarget)
		{
			return new IVehicleEnteringTarget_UnionUnion
			{
				Type = IVehicleEnteringTarget_Union.IVehicleEnteringPlayerTarget,
				Value = _ivehicleenteringplayertarget
			};
		}

		// Token: 0x06039C15 RID: 236565 RVA: 0x007CA524 File Offset: 0x007C8724
		public IVehicleEnteringNpcTargetT AsIVehicleEnteringNpcTarget()
		{
			return this.As<IVehicleEnteringNpcTargetT>();
		}

		// Token: 0x06039C16 RID: 236566 RVA: 0x007CA52C File Offset: 0x007C872C
		public static IVehicleEnteringTarget_UnionUnion FromIVehicleEnteringNpcTarget(IVehicleEnteringNpcTargetT _ivehicleenteringnpctarget)
		{
			return new IVehicleEnteringTarget_UnionUnion
			{
				Type = IVehicleEnteringTarget_Union.IVehicleEnteringNpcTarget,
				Value = _ivehicleenteringnpctarget
			};
		}

		// Token: 0x06039C17 RID: 236567 RVA: 0x007CA544 File Offset: 0x007C8744
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
