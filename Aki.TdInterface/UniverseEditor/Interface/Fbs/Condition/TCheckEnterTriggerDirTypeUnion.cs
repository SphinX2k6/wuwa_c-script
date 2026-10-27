using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D2E RID: 19758
	public class TCheckEnterTriggerDirTypeUnion
	{
		// Token: 0x17008F39 RID: 36665
		// (get) Token: 0x0601F5CC RID: 128460 RVA: 0x0045F3C4 File Offset: 0x0045D5C4
		// (set) Token: 0x0601F5CD RID: 128461 RVA: 0x0045F3CC File Offset: 0x0045D5CC
		public TCheckEnterTriggerDirType Type { get; set; }

		// Token: 0x17008F3A RID: 36666
		// (get) Token: 0x0601F5CE RID: 128462 RVA: 0x0045F3D5 File Offset: 0x0045D5D5
		// (set) Token: 0x0601F5CF RID: 128463 RVA: 0x0045F3DD File Offset: 0x0045D5DD
		public object Value { get; set; }

		// Token: 0x0601F5D0 RID: 128464 RVA: 0x0045F3E6 File Offset: 0x0045D5E6
		public TCheckEnterTriggerDirTypeUnion()
		{
			this.Type = TCheckEnterTriggerDirType.NONE;
			this.Value = null;
		}

		// Token: 0x0601F5D1 RID: 128465 RVA: 0x0045F3FC File Offset: 0x0045D5FC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F5D2 RID: 128466 RVA: 0x0045F40E File Offset: 0x0045D60E
		public ICheckEnterTriggerDirTypeForwardAngleT AsICheckEnterTriggerDirTypeForwardAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeForwardAngleT>();
		}

		// Token: 0x0601F5D3 RID: 128467 RVA: 0x0045F416 File Offset: 0x0045D616
		public static TCheckEnterTriggerDirTypeUnion FromICheckEnterTriggerDirTypeForwardAngle(ICheckEnterTriggerDirTypeForwardAngleT _icheckentertriggerdirtypeforwardangle)
		{
			return new TCheckEnterTriggerDirTypeUnion
			{
				Type = TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeForwardAngle,
				Value = _icheckentertriggerdirtypeforwardangle
			};
		}

		// Token: 0x0601F5D4 RID: 128468 RVA: 0x0045F42B File Offset: 0x0045D62B
		public ICheckEnterTriggerDirTypeVelocityDirAngleT AsICheckEnterTriggerDirTypeVelocityDirAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeVelocityDirAngleT>();
		}

		// Token: 0x0601F5D5 RID: 128469 RVA: 0x0045F433 File Offset: 0x0045D633
		public static TCheckEnterTriggerDirTypeUnion FromICheckEnterTriggerDirTypeVelocityDirAngle(ICheckEnterTriggerDirTypeVelocityDirAngleT _icheckentertriggerdirtypevelocitydirangle)
		{
			return new TCheckEnterTriggerDirTypeUnion
			{
				Type = TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeVelocityDirAngle,
				Value = _icheckentertriggerdirtypevelocitydirangle
			};
		}

		// Token: 0x0601F5D6 RID: 128470 RVA: 0x0045F448 File Offset: 0x0045D648
		public static int Pack(FlatBufferBuilder builder, TCheckEnterTriggerDirTypeUnion _o)
		{
			TCheckEnterTriggerDirType type = _o.Type;
			if (type == TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeForwardAngle)
			{
				return ICheckEnterTriggerDirTypeForwardAngle.Pack(builder, _o.AsICheckEnterTriggerDirTypeForwardAngle()).Value;
			}
			if (type != TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeVelocityDirAngle)
			{
				return 0;
			}
			return ICheckEnterTriggerDirTypeVelocityDirAngle.Pack(builder, _o.AsICheckEnterTriggerDirTypeVelocityDirAngle()).Value;
		}
	}
}
