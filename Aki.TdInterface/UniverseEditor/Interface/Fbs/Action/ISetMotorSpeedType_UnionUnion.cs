using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F2 RID: 30706
	public class ISetMotorSpeedType_UnionUnion
	{
		// Token: 0x1700E10E RID: 57614
		// (get) Token: 0x06035F11 RID: 220945 RVA: 0x00739DF1 File Offset: 0x00737FF1
		// (set) Token: 0x06035F12 RID: 220946 RVA: 0x00739DF9 File Offset: 0x00737FF9
		public ISetMotorSpeedType_Union Type { get; set; }

		// Token: 0x1700E10F RID: 57615
		// (get) Token: 0x06035F13 RID: 220947 RVA: 0x00739E02 File Offset: 0x00738002
		// (set) Token: 0x06035F14 RID: 220948 RVA: 0x00739E0A File Offset: 0x0073800A
		public object Value { get; set; }

		// Token: 0x06035F15 RID: 220949 RVA: 0x00739E13 File Offset: 0x00738013
		public ISetMotorSpeedType_UnionUnion()
		{
			this.Type = ISetMotorSpeedType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035F16 RID: 220950 RVA: 0x00739E29 File Offset: 0x00738029
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035F17 RID: 220951 RVA: 0x00739E3B File Offset: 0x0073803B
		public ISetMotorSpeedTypeT AsISetMotorSpeedType()
		{
			return this.As<ISetMotorSpeedTypeT>();
		}

		// Token: 0x06035F18 RID: 220952 RVA: 0x00739E43 File Offset: 0x00738043
		public static ISetMotorSpeedType_UnionUnion FromISetMotorSpeedType(ISetMotorSpeedTypeT _isetmotorspeedtype)
		{
			return new ISetMotorSpeedType_UnionUnion
			{
				Type = ISetMotorSpeedType_Union.ISetMotorSpeedType,
				Value = _isetmotorspeedtype
			};
		}

		// Token: 0x06035F19 RID: 220953 RVA: 0x00739E58 File Offset: 0x00738058
		public ISetMotorSpeedTargetSpeedT AsISetMotorSpeedTargetSpeed()
		{
			return this.As<ISetMotorSpeedTargetSpeedT>();
		}

		// Token: 0x06035F1A RID: 220954 RVA: 0x00739E60 File Offset: 0x00738060
		public static ISetMotorSpeedType_UnionUnion FromISetMotorSpeedTargetSpeed(ISetMotorSpeedTargetSpeedT _isetmotorspeedtargetspeed)
		{
			return new ISetMotorSpeedType_UnionUnion
			{
				Type = ISetMotorSpeedType_Union.ISetMotorSpeedTargetSpeed,
				Value = _isetmotorspeedtargetspeed
			};
		}

		// Token: 0x06035F1B RID: 220955 RVA: 0x00739E78 File Offset: 0x00738078
		public static int Pack(FlatBufferBuilder builder, ISetMotorSpeedType_UnionUnion _o)
		{
			ISetMotorSpeedType_Union type = _o.Type;
			if (type == ISetMotorSpeedType_Union.ISetMotorSpeedType)
			{
				return ISetMotorSpeedType.Pack(builder, _o.AsISetMotorSpeedType()).Value;
			}
			if (type != ISetMotorSpeedType_Union.ISetMotorSpeedTargetSpeed)
			{
				return 0;
			}
			return ISetMotorSpeedTargetSpeed.Pack(builder, _o.AsISetMotorSpeedTargetSpeed()).Value;
		}
	}
}
