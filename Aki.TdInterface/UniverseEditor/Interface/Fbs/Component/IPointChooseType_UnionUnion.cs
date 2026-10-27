using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005755 RID: 22357
	public class IPointChooseType_UnionUnion
	{
		// Token: 0x1700A6CA RID: 42698
		// (get) Token: 0x0602576B RID: 153451 RVA: 0x0052B499 File Offset: 0x00529699
		// (set) Token: 0x0602576C RID: 153452 RVA: 0x0052B4A1 File Offset: 0x005296A1
		public IPointChooseType_Union Type { get; set; }

		// Token: 0x1700A6CB RID: 42699
		// (get) Token: 0x0602576D RID: 153453 RVA: 0x0052B4AA File Offset: 0x005296AA
		// (set) Token: 0x0602576E RID: 153454 RVA: 0x0052B4B2 File Offset: 0x005296B2
		public object Value { get; set; }

		// Token: 0x0602576F RID: 153455 RVA: 0x0052B4BB File Offset: 0x005296BB
		public IPointChooseType_UnionUnion()
		{
			this.Type = IPointChooseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025770 RID: 153456 RVA: 0x0052B4D1 File Offset: 0x005296D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025771 RID: 153457 RVA: 0x0052B4E3 File Offset: 0x005296E3
		public IPointChooseTypeT AsIPointChooseType()
		{
			return this.As<IPointChooseTypeT>();
		}

		// Token: 0x06025772 RID: 153458 RVA: 0x0052B4EB File Offset: 0x005296EB
		public static IPointChooseType_UnionUnion FromIPointChooseType(IPointChooseTypeT _ipointchoosetype)
		{
			return new IPointChooseType_UnionUnion
			{
				Type = IPointChooseType_Union.IPointChooseType,
				Value = _ipointchoosetype
			};
		}

		// Token: 0x06025773 RID: 153459 RVA: 0x0052B500 File Offset: 0x00529700
		public ISpawnMonsterPointT AsISpawnMonsterPoint()
		{
			return this.As<ISpawnMonsterPointT>();
		}

		// Token: 0x06025774 RID: 153460 RVA: 0x0052B508 File Offset: 0x00529708
		public static IPointChooseType_UnionUnion FromISpawnMonsterPoint(ISpawnMonsterPointT _ispawnmonsterpoint)
		{
			return new IPointChooseType_UnionUnion
			{
				Type = IPointChooseType_Union.ISpawnMonsterPoint,
				Value = _ispawnmonsterpoint
			};
		}

		// Token: 0x06025775 RID: 153461 RVA: 0x0052B520 File Offset: 0x00529720
		public static int Pack(FlatBufferBuilder builder, IPointChooseType_UnionUnion _o)
		{
			IPointChooseType_Union type = _o.Type;
			if (type == IPointChooseType_Union.IPointChooseType)
			{
				return IPointChooseType.Pack(builder, _o.AsIPointChooseType()).Value;
			}
			if (type != IPointChooseType_Union.ISpawnMonsterPoint)
			{
				return 0;
			}
			return ISpawnMonsterPoint.Pack(builder, _o.AsISpawnMonsterPoint()).Value;
		}
	}
}
