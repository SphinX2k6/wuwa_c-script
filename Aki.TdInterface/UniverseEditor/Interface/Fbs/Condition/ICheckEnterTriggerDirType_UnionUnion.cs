using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB5 RID: 20149
	public class ICheckEnterTriggerDirType_UnionUnion
	{
		// Token: 0x17008FBB RID: 36795
		// (get) Token: 0x0601F3BD RID: 127933 RVA: 0x0045A8D8 File Offset: 0x00458AD8
		// (set) Token: 0x0601F3BE RID: 127934 RVA: 0x0045A8E0 File Offset: 0x00458AE0
		public ICheckEnterTriggerDirType_Union Type { get; set; }

		// Token: 0x17008FBC RID: 36796
		// (get) Token: 0x0601F3BF RID: 127935 RVA: 0x0045A8E9 File Offset: 0x00458AE9
		// (set) Token: 0x0601F3C0 RID: 127936 RVA: 0x0045A8F1 File Offset: 0x00458AF1
		public object Value { get; set; }

		// Token: 0x0601F3C1 RID: 127937 RVA: 0x0045A8FA File Offset: 0x00458AFA
		public ICheckEnterTriggerDirType_UnionUnion()
		{
			this.Type = ICheckEnterTriggerDirType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F3C2 RID: 127938 RVA: 0x0045A910 File Offset: 0x00458B10
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F3C3 RID: 127939 RVA: 0x0045A922 File Offset: 0x00458B22
		public ICheckEnterTriggerDirTypeT AsICheckEnterTriggerDirType()
		{
			return this.As<ICheckEnterTriggerDirTypeT>();
		}

		// Token: 0x0601F3C4 RID: 127940 RVA: 0x0045A92A File Offset: 0x00458B2A
		public static ICheckEnterTriggerDirType_UnionUnion FromICheckEnterTriggerDirType(ICheckEnterTriggerDirTypeT _icheckentertriggerdirtype)
		{
			return new ICheckEnterTriggerDirType_UnionUnion
			{
				Type = ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirType,
				Value = _icheckentertriggerdirtype
			};
		}

		// Token: 0x0601F3C5 RID: 127941 RVA: 0x0045A93F File Offset: 0x00458B3F
		public ICheckEnterTriggerDirTypeForwardAngleT AsICheckEnterTriggerDirTypeForwardAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeForwardAngleT>();
		}

		// Token: 0x0601F3C6 RID: 127942 RVA: 0x0045A947 File Offset: 0x00458B47
		public static ICheckEnterTriggerDirType_UnionUnion FromICheckEnterTriggerDirTypeForwardAngle(ICheckEnterTriggerDirTypeForwardAngleT _icheckentertriggerdirtypeforwardangle)
		{
			return new ICheckEnterTriggerDirType_UnionUnion
			{
				Type = ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirTypeForwardAngle,
				Value = _icheckentertriggerdirtypeforwardangle
			};
		}

		// Token: 0x0601F3C7 RID: 127943 RVA: 0x0045A95C File Offset: 0x00458B5C
		public ICheckEnterTriggerDirTypeVelocityDirAngleT AsICheckEnterTriggerDirTypeVelocityDirAngle()
		{
			return this.As<ICheckEnterTriggerDirTypeVelocityDirAngleT>();
		}

		// Token: 0x0601F3C8 RID: 127944 RVA: 0x0045A964 File Offset: 0x00458B64
		public static ICheckEnterTriggerDirType_UnionUnion FromICheckEnterTriggerDirTypeVelocityDirAngle(ICheckEnterTriggerDirTypeVelocityDirAngleT _icheckentertriggerdirtypevelocitydirangle)
		{
			return new ICheckEnterTriggerDirType_UnionUnion
			{
				Type = ICheckEnterTriggerDirType_Union.ICheckEnterTriggerDirTypeVelocityDirAngle,
				Value = _icheckentertriggerdirtypevelocitydirangle
			};
		}

		// Token: 0x0601F3C9 RID: 127945 RVA: 0x0045A97C File Offset: 0x00458B7C
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
