using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EDF RID: 20191
	public class ICheckEntityType_UnionUnion
	{
		// Token: 0x1700902C RID: 36908
		// (get) Token: 0x0601F57A RID: 128378 RVA: 0x0045E099 File Offset: 0x0045C299
		// (set) Token: 0x0601F57B RID: 128379 RVA: 0x0045E0A1 File Offset: 0x0045C2A1
		public ICheckEntityType_Union Type { get; set; }

		// Token: 0x1700902D RID: 36909
		// (get) Token: 0x0601F57C RID: 128380 RVA: 0x0045E0AA File Offset: 0x0045C2AA
		// (set) Token: 0x0601F57D RID: 128381 RVA: 0x0045E0B2 File Offset: 0x0045C2B2
		public object Value { get; set; }

		// Token: 0x0601F57E RID: 128382 RVA: 0x0045E0BB File Offset: 0x0045C2BB
		public ICheckEntityType_UnionUnion()
		{
			this.Type = ICheckEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F57F RID: 128383 RVA: 0x0045E0D1 File Offset: 0x0045C2D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F580 RID: 128384 RVA: 0x0045E0E3 File Offset: 0x0045C2E3
		public ICheckEntityTypeT AsICheckEntityType()
		{
			return this.As<ICheckEntityTypeT>();
		}

		// Token: 0x0601F581 RID: 128385 RVA: 0x0045E0EB File Offset: 0x0045C2EB
		public static ICheckEntityType_UnionUnion FromICheckEntityType(ICheckEntityTypeT _icheckentitytype)
		{
			return new ICheckEntityType_UnionUnion
			{
				Type = ICheckEntityType_Union.ICheckEntityType,
				Value = _icheckentitytype
			};
		}

		// Token: 0x0601F582 RID: 128386 RVA: 0x0045E100 File Offset: 0x0045C300
		public ICheckOnlinePlayerT AsICheckOnlinePlayer()
		{
			return this.As<ICheckOnlinePlayerT>();
		}

		// Token: 0x0601F583 RID: 128387 RVA: 0x0045E108 File Offset: 0x0045C308
		public static ICheckEntityType_UnionUnion FromICheckOnlinePlayer(ICheckOnlinePlayerT _icheckonlineplayer)
		{
			return new ICheckEntityType_UnionUnion
			{
				Type = ICheckEntityType_Union.ICheckOnlinePlayer,
				Value = _icheckonlineplayer
			};
		}

		// Token: 0x0601F584 RID: 128388 RVA: 0x0045E11D File Offset: 0x0045C31D
		public ICheckTargetEntityT AsICheckTargetEntity()
		{
			return this.As<ICheckTargetEntityT>();
		}

		// Token: 0x0601F585 RID: 128389 RVA: 0x0045E125 File Offset: 0x0045C325
		public static ICheckEntityType_UnionUnion FromICheckTargetEntity(ICheckTargetEntityT _ichecktargetentity)
		{
			return new ICheckEntityType_UnionUnion
			{
				Type = ICheckEntityType_Union.ICheckTargetEntity,
				Value = _ichecktargetentity
			};
		}

		// Token: 0x0601F586 RID: 128390 RVA: 0x0045E13C File Offset: 0x0045C33C
		public static int Pack(FlatBufferBuilder builder, ICheckEntityType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckEntityType_Union.ICheckEntityType:
				return ICheckEntityType.Pack(builder, _o.AsICheckEntityType()).Value;
			case ICheckEntityType_Union.ICheckOnlinePlayer:
				return ICheckOnlinePlayer.Pack(builder, _o.AsICheckOnlinePlayer()).Value;
			case ICheckEntityType_Union.ICheckTargetEntity:
				return ICheckTargetEntity.Pack(builder, _o.AsICheckTargetEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
