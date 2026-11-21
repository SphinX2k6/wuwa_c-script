using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200503E RID: 20542
	public class ICheckTargetType_UnionUnion
	{
		// Token: 0x170092FA RID: 37626
		// (get) Token: 0x06020189 RID: 131465 RVA: 0x00473E51 File Offset: 0x00472051
		// (set) Token: 0x0602018A RID: 131466 RVA: 0x00473E59 File Offset: 0x00472059
		public ICheckTargetType_Union Type { get; set; }

		// Token: 0x170092FB RID: 37627
		// (get) Token: 0x0602018B RID: 131467 RVA: 0x00473E62 File Offset: 0x00472062
		// (set) Token: 0x0602018C RID: 131468 RVA: 0x00473E6A File Offset: 0x0047206A
		public object Value { get; set; }

		// Token: 0x0602018D RID: 131469 RVA: 0x00473E73 File Offset: 0x00472073
		public ICheckTargetType_UnionUnion()
		{
			this.Type = ICheckTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602018E RID: 131470 RVA: 0x00473E89 File Offset: 0x00472089
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602018F RID: 131471 RVA: 0x00473E9B File Offset: 0x0047209B
		public ICheckTargetTypeT AsICheckTargetType()
		{
			return this.As<ICheckTargetTypeT>();
		}

		// Token: 0x06020190 RID: 131472 RVA: 0x00473EA3 File Offset: 0x004720A3
		public static ICheckTargetType_UnionUnion FromICheckTargetType(ICheckTargetTypeT _ichecktargettype)
		{
			return new ICheckTargetType_UnionUnion
			{
				Type = ICheckTargetType_Union.ICheckTargetType,
				Value = _ichecktargettype
			};
		}

		// Token: 0x06020191 RID: 131473 RVA: 0x00473EB8 File Offset: 0x004720B8
		public IAllPlayerTypeT AsIAllPlayerType()
		{
			return this.As<IAllPlayerTypeT>();
		}

		// Token: 0x06020192 RID: 131474 RVA: 0x00473EC0 File Offset: 0x004720C0
		public static ICheckTargetType_UnionUnion FromIAllPlayerType(IAllPlayerTypeT _iallplayertype)
		{
			return new ICheckTargetType_UnionUnion
			{
				Type = ICheckTargetType_Union.IAllPlayerType,
				Value = _iallplayertype
			};
		}

		// Token: 0x06020193 RID: 131475 RVA: 0x00473ED8 File Offset: 0x004720D8
		public static int Pack(FlatBufferBuilder builder, ICheckTargetType_UnionUnion _o)
		{
			ICheckTargetType_Union type = _o.Type;
			if (type == ICheckTargetType_Union.ICheckTargetType)
			{
				return ICheckTargetType.Pack(builder, _o.AsICheckTargetType()).Value;
			}
			if (type != ICheckTargetType_Union.IAllPlayerType)
			{
				return 0;
			}
			return IAllPlayerType.Pack(builder, _o.AsIAllPlayerType()).Value;
		}
	}
}
