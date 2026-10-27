using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007802 RID: 30722
	public class TVehicleEnteringTargetUnion
	{
		// Token: 0x1700E6EF RID: 59119
		// (get) Token: 0x06037B70 RID: 228208 RVA: 0x007884E2 File Offset: 0x007866E2
		// (set) Token: 0x06037B71 RID: 228209 RVA: 0x007884EA File Offset: 0x007866EA
		public TVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700E6F0 RID: 59120
		// (get) Token: 0x06037B72 RID: 228210 RVA: 0x007884F3 File Offset: 0x007866F3
		// (set) Token: 0x06037B73 RID: 228211 RVA: 0x007884FB File Offset: 0x007866FB
		public object Value { get; set; }

		// Token: 0x06037B74 RID: 228212 RVA: 0x00788504 File Offset: 0x00786704
		public TVehicleEnteringTargetUnion()
		{
			this.Type = TVehicleEnteringTarget.NONE;
			this.Value = null;
		}

		// Token: 0x06037B75 RID: 228213 RVA: 0x0078851A File Offset: 0x0078671A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B76 RID: 228214 RVA: 0x0078852C File Offset: 0x0078672C
		public IVehicleEnteringNpcTargetT AsIVehicleEnteringNpcTarget()
		{
			return this.As<IVehicleEnteringNpcTargetT>();
		}

		// Token: 0x06037B77 RID: 228215 RVA: 0x00788534 File Offset: 0x00786734
		public static TVehicleEnteringTargetUnion FromIVehicleEnteringNpcTarget(IVehicleEnteringNpcTargetT _ivehicleenteringnpctarget)
		{
			return new TVehicleEnteringTargetUnion
			{
				Type = TVehicleEnteringTarget.IVehicleEnteringNpcTarget,
				Value = _ivehicleenteringnpctarget
			};
		}

		// Token: 0x06037B78 RID: 228216 RVA: 0x00788549 File Offset: 0x00786749
		public IVehicleEnteringPlayerTargetT AsIVehicleEnteringPlayerTarget()
		{
			return this.As<IVehicleEnteringPlayerTargetT>();
		}

		// Token: 0x06037B79 RID: 228217 RVA: 0x00788551 File Offset: 0x00786751
		public static TVehicleEnteringTargetUnion FromIVehicleEnteringPlayerTarget(IVehicleEnteringPlayerTargetT _ivehicleenteringplayertarget)
		{
			return new TVehicleEnteringTargetUnion
			{
				Type = TVehicleEnteringTarget.IVehicleEnteringPlayerTarget,
				Value = _ivehicleenteringplayertarget
			};
		}

		// Token: 0x06037B7A RID: 228218 RVA: 0x00788568 File Offset: 0x00786768
		public static int Pack(FlatBufferBuilder builder, TVehicleEnteringTargetUnion _o)
		{
			TVehicleEnteringTarget type = _o.Type;
			if (type == TVehicleEnteringTarget.IVehicleEnteringNpcTarget)
			{
				return IVehicleEnteringNpcTarget.Pack(builder, _o.AsIVehicleEnteringNpcTarget()).Value;
			}
			if (type != TVehicleEnteringTarget.IVehicleEnteringPlayerTarget)
			{
				return 0;
			}
			return IVehicleEnteringPlayerTarget.Pack(builder, _o.AsIVehicleEnteringPlayerTarget()).Value;
		}
	}
}
