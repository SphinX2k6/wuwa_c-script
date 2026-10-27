using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007029 RID: 28713
	public class ISetMotorSpeedType_UnionUnion
	{
		// Token: 0x1700D53A RID: 54586
		// (get) Token: 0x06032CAB RID: 208043 RVA: 0x006DA1AD File Offset: 0x006D83AD
		// (set) Token: 0x06032CAC RID: 208044 RVA: 0x006DA1B5 File Offset: 0x006D83B5
		public ISetMotorSpeedType_Union Type { get; set; }

		// Token: 0x1700D53B RID: 54587
		// (get) Token: 0x06032CAD RID: 208045 RVA: 0x006DA1BE File Offset: 0x006D83BE
		// (set) Token: 0x06032CAE RID: 208046 RVA: 0x006DA1C6 File Offset: 0x006D83C6
		public object Value { get; set; }

		// Token: 0x06032CAF RID: 208047 RVA: 0x006DA1CF File Offset: 0x006D83CF
		public ISetMotorSpeedType_UnionUnion()
		{
			this.Type = ISetMotorSpeedType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032CB0 RID: 208048 RVA: 0x006DA1E5 File Offset: 0x006D83E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032CB1 RID: 208049 RVA: 0x006DA1F7 File Offset: 0x006D83F7
		public ISetMotorSpeedTypeT AsISetMotorSpeedType()
		{
			return this.As<ISetMotorSpeedTypeT>();
		}

		// Token: 0x06032CB2 RID: 208050 RVA: 0x006DA1FF File Offset: 0x006D83FF
		public static ISetMotorSpeedType_UnionUnion FromISetMotorSpeedType(ISetMotorSpeedTypeT _isetmotorspeedtype)
		{
			return new ISetMotorSpeedType_UnionUnion
			{
				Type = ISetMotorSpeedType_Union.ISetMotorSpeedType,
				Value = _isetmotorspeedtype
			};
		}

		// Token: 0x06032CB3 RID: 208051 RVA: 0x006DA214 File Offset: 0x006D8414
		public ISetMotorSpeedTargetSpeedT AsISetMotorSpeedTargetSpeed()
		{
			return this.As<ISetMotorSpeedTargetSpeedT>();
		}

		// Token: 0x06032CB4 RID: 208052 RVA: 0x006DA21C File Offset: 0x006D841C
		public static ISetMotorSpeedType_UnionUnion FromISetMotorSpeedTargetSpeed(ISetMotorSpeedTargetSpeedT _isetmotorspeedtargetspeed)
		{
			return new ISetMotorSpeedType_UnionUnion
			{
				Type = ISetMotorSpeedType_Union.ISetMotorSpeedTargetSpeed,
				Value = _isetmotorspeedtargetspeed
			};
		}

		// Token: 0x06032CB5 RID: 208053 RVA: 0x006DA234 File Offset: 0x006D8434
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
