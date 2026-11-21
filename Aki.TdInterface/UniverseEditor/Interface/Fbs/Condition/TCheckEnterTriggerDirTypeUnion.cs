using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200522A RID: 21034
	public class TCheckEnterTriggerDirTypeUnion
	{
		// Token: 0x17009672 RID: 38514
		// (get) Token: 0x06021213 RID: 135699 RVA: 0x00493354 File Offset: 0x00491554
		// (set) Token: 0x06021214 RID: 135700 RVA: 0x0049335C File Offset: 0x0049155C
		public TCheckEnterTriggerDirType Type { get; set; }

		// Token: 0x17009673 RID: 38515
		// (get) Token: 0x06021215 RID: 135701 RVA: 0x00493365 File Offset: 0x00491565
		// (set) Token: 0x06021216 RID: 135702 RVA: 0x0049336D File Offset: 0x0049156D
		public object Value { get; set; }

		// Token: 0x06021217 RID: 135703 RVA: 0x00493376 File Offset: 0x00491576
		public TCheckEnterTriggerDirTypeUnion()
		{
			this.Type = TCheckEnterTriggerDirType.NONE;
			this.Value = null;
		}

		// Token: 0x06021218 RID: 135704 RVA: 0x0049338C File Offset: 0x0049158C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021219 RID: 135705 RVA: 0x0049339E File Offset: 0x0049159E
		public ICheckEnterTriggerDirTypeForwardAngleT AsICheckEnterTriggerDirTypeForwardAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeForwardAngleT>();
		}

		// Token: 0x0602121A RID: 135706 RVA: 0x004933A6 File Offset: 0x004915A6
		public static TCheckEnterTriggerDirTypeUnion FromICheckEnterTriggerDirTypeForwardAngle(ICheckEnterTriggerDirTypeForwardAngleT _icheckentertriggerdirtypeforwardangle)
		{
			return new TCheckEnterTriggerDirTypeUnion
			{
				Type = TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeForwardAngle,
				Value = _icheckentertriggerdirtypeforwardangle
			};
		}

		// Token: 0x0602121B RID: 135707 RVA: 0x004933BB File Offset: 0x004915BB
		public ICheckEnterTriggerDirTypeVelocityDirAngleT AsICheckEnterTriggerDirTypeVelocityDirAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeVelocityDirAngleT>();
		}

		// Token: 0x0602121C RID: 135708 RVA: 0x004933C3 File Offset: 0x004915C3
		public static TCheckEnterTriggerDirTypeUnion FromICheckEnterTriggerDirTypeVelocityDirAngle(ICheckEnterTriggerDirTypeVelocityDirAngleT _icheckentertriggerdirtypevelocitydirangle)
		{
			return new TCheckEnterTriggerDirTypeUnion
			{
				Type = TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeVelocityDirAngle,
				Value = _icheckentertriggerdirtypevelocitydirangle
			};
		}

		// Token: 0x0602121D RID: 135709 RVA: 0x004933D8 File Offset: 0x004915D8
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
