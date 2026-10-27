using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F5 RID: 18933
	public class ICheckEnterTriggerDirType_UnionUnion
	{
		// Token: 0x170088EB RID: 35051
		// (get) Token: 0x0601D94A RID: 121162 RVA: 0x00429C6C File Offset: 0x00427E6C
		// (set) Token: 0x0601D94B RID: 121163 RVA: 0x00429C74 File Offset: 0x00427E74
		public ICheckEnterTriggerDirType_Union Type { get; set; }

		// Token: 0x170088EC RID: 35052
		// (get) Token: 0x0601D94C RID: 121164 RVA: 0x00429C7D File Offset: 0x00427E7D
		// (set) Token: 0x0601D94D RID: 121165 RVA: 0x00429C85 File Offset: 0x00427E85
		public object Value { get; set; }

		// Token: 0x0601D94E RID: 121166 RVA: 0x00429C8E File Offset: 0x00427E8E
		public ICheckEnterTriggerDirType_UnionUnion()
		{
			this.Type = ICheckEnterTriggerDirType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601D94F RID: 121167 RVA: 0x00429CA4 File Offset: 0x00427EA4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D950 RID: 121168 RVA: 0x00429CB6 File Offset: 0x00427EB6
		public ICheckEnterTriggerDirTypeT AsICheckEnterTriggerDirType()
		{
			return this.As<ICheckEnterTriggerDirTypeT>();
		}

		// Token: 0x0601D951 RID: 121169 RVA: 0x00429CBE File Offset: 0x00427EBE
		public static ICheckEnterTriggerDirType_UnionUnion FromICheckEnterTriggerDirType(ICheckEnterTriggerDirTypeT _icheckentertriggerdirtype)
		{
			return new ICheckEnterTriggerDirType_UnionUnion
			{
				Type = ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirType,
				Value = _icheckentertriggerdirtype
			};
		}

		// Token: 0x0601D952 RID: 121170 RVA: 0x00429CD3 File Offset: 0x00427ED3
		public ICheckEnterTriggerDirTypeForwardAngleT AsICheckEnterTriggerDirTypeForwardAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeForwardAngleT>();
		}

		// Token: 0x0601D953 RID: 121171 RVA: 0x00429CDB File Offset: 0x00427EDB
		public static ICheckEnterTriggerDirType_UnionUnion FromICheckEnterTriggerDirTypeForwardAngle(ICheckEnterTriggerDirTypeForwardAngleT _icheckentertriggerdirtypeforwardangle)
		{
			return new ICheckEnterTriggerDirType_UnionUnion
			{
				Type = ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirTypeForwardAngle,
				Value = _icheckentertriggerdirtypeforwardangle
			};
		}

		// Token: 0x0601D954 RID: 121172 RVA: 0x00429CF0 File Offset: 0x00427EF0
		public ICheckEnterTriggerDirTypeVelocityDirAngleT AsICheckEnterTriggerDirTypeVelocityDirAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeVelocityDirAngleT>();
		}

		// Token: 0x0601D955 RID: 121173 RVA: 0x00429CF8 File Offset: 0x00427EF8
		public static ICheckEnterTriggerDirType_UnionUnion FromICheckEnterTriggerDirTypeVelocityDirAngle(ICheckEnterTriggerDirTypeVelocityDirAngleT _icheckentertriggerdirtypevelocitydirangle)
		{
			return new ICheckEnterTriggerDirType_UnionUnion
			{
				Type = ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirTypeVelocityDirAngle,
				Value = _icheckentertriggerdirtypevelocitydirangle
			};
		}

		// Token: 0x0601D956 RID: 121174 RVA: 0x00429D10 File Offset: 0x00427F10
		public static int Pack(FlatBufferBuilder builder, ICheckEnterTriggerDirType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirType:
				return ICheckEnterTriggerDirType.Pack(builder, _o.AsICheckEnterTriggerDirType()).Value;
			case ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirTypeForwardAngle:
				return ICheckEnterTriggerDirTypeForwardAngle.Pack(builder, _o.AsICheckEnterTriggerDirTypeForwardAngle()).Value;
			case ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirTypeVelocityDirAngle:
				return ICheckEnterTriggerDirTypeVelocityDirAngle.Pack(builder, _o.AsICheckEnterTriggerDirTypeVelocityDirAngle()).Value;
			default:
				return 0;
			}
		}
	}
}
