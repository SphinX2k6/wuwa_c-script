using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAA RID: 28330
	public class IResetPosType_UnionUnion
	{
		// Token: 0x1700D2E8 RID: 53992
		// (get) Token: 0x06032115 RID: 205077 RVA: 0x006C54D1 File Offset: 0x006C36D1
		// (set) Token: 0x06032116 RID: 205078 RVA: 0x006C54D9 File Offset: 0x006C36D9
		public IResetPosType_Union Type { get; set; }

		// Token: 0x1700D2E9 RID: 53993
		// (get) Token: 0x06032117 RID: 205079 RVA: 0x006C54E2 File Offset: 0x006C36E2
		// (set) Token: 0x06032118 RID: 205080 RVA: 0x006C54EA File Offset: 0x006C36EA
		public object Value { get; set; }

		// Token: 0x06032119 RID: 205081 RVA: 0x006C54F3 File Offset: 0x006C36F3
		public IResetPosType_UnionUnion()
		{
			this.Type = IResetPosType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603211A RID: 205082 RVA: 0x006C5509 File Offset: 0x006C3709
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603211B RID: 205083 RVA: 0x006C551B File Offset: 0x006C371B
		public IResetPosTypeT AsIResetPosType()
		{
			return this.As<IResetPosTypeT>();
		}

		// Token: 0x0603211C RID: 205084 RVA: 0x006C5523 File Offset: 0x006C3723
		public static IResetPosType_UnionUnion FromIResetPosType(IResetPosTypeT _iresetpostype)
		{
			return new IResetPosType_UnionUnion
			{
				Type = IResetPosType_Union.IResetPosType,
				Value = _iresetpostype
			};
		}

		// Token: 0x0603211D RID: 205085 RVA: 0x006C5538 File Offset: 0x006C3738
		public IResetPosByPosEntityT AsIResetPosByPosEntity()
		{
			return this.As<IResetPosByPosEntityT>();
		}

		// Token: 0x0603211E RID: 205086 RVA: 0x006C5540 File Offset: 0x006C3740
		public static IResetPosType_UnionUnion FromIResetPosByPosEntity(IResetPosByPosEntityT _iresetposbyposentity)
		{
			return new IResetPosType_UnionUnion
			{
				Type = IResetPosType_Union.IResetPosByPosEntity,
				Value = _iresetposbyposentity
			};
		}

		// Token: 0x0603211F RID: 205087 RVA: 0x006C5555 File Offset: 0x006C3755
		public IResetPosByResetPointT AsIResetPosByResetPoint()
		{
			return this.As<IResetPosByResetPointT>();
		}

		// Token: 0x06032120 RID: 205088 RVA: 0x006C555D File Offset: 0x006C375D
		public static IResetPosType_UnionUnion FromIResetPosByResetPoint(IResetPosByResetPointT _iresetposbyresetpoint)
		{
			return new IResetPosType_UnionUnion
			{
				Type = IResetPosType_Union.IResetPosByResetPoint,
				Value = _iresetposbyresetpoint
			};
		}

		// Token: 0x06032121 RID: 205089 RVA: 0x006C5574 File Offset: 0x006C3774
		public static int Pack(FlatBufferBuilder builder, IResetPosType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IResetPosType_Union.IResetPosType:
				return IResetPosType.Pack(builder, _o.AsIResetPosType()).Value;
			case IResetPosType_Union.IResetPosByPosEntity:
				return IResetPosByPosEntity.Pack(builder, _o.AsIResetPosByPosEntity()).Value;
			case IResetPosType_Union.IResetPosByResetPoint:
				return IResetPosByResetPoint.Pack(builder, _o.AsIResetPosByResetPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
