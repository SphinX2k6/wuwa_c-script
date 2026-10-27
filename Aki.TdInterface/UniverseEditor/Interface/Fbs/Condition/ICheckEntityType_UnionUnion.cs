using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A1F RID: 18975
	public class ICheckEntityType_UnionUnion
	{
		// Token: 0x1700895C RID: 35164
		// (get) Token: 0x0601DB07 RID: 121607 RVA: 0x0042D42D File Offset: 0x0042B62D
		// (set) Token: 0x0601DB08 RID: 121608 RVA: 0x0042D435 File Offset: 0x0042B635
		public ICheckEntityType_Union Type { get; set; }

		// Token: 0x1700895D RID: 35165
		// (get) Token: 0x0601DB09 RID: 121609 RVA: 0x0042D43E File Offset: 0x0042B63E
		// (set) Token: 0x0601DB0A RID: 121610 RVA: 0x0042D446 File Offset: 0x0042B646
		public object Value { get; set; }

		// Token: 0x0601DB0B RID: 121611 RVA: 0x0042D44F File Offset: 0x0042B64F
		public ICheckEntityType_UnionUnion()
		{
			this.Type = ICheckEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601DB0C RID: 121612 RVA: 0x0042D465 File Offset: 0x0042B665
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601DB0D RID: 121613 RVA: 0x0042D477 File Offset: 0x0042B677
		public ICheckEntityTypeT AsICheckEntityType()
		{
			return this.As<ICheckEntityTypeT>();
		}

		// Token: 0x0601DB0E RID: 121614 RVA: 0x0042D47F File Offset: 0x0042B67F
		public static ICheckEntityType_UnionUnion FromICheckEntityType(ICheckEntityTypeT _icheckentitytype)
		{
			return new ICheckEntityType_UnionUnion
			{
				Type = ICheckEntityType_Union.ICheckEntityType,
				Value = _icheckentitytype
			};
		}

		// Token: 0x0601DB0F RID: 121615 RVA: 0x0042D494 File Offset: 0x0042B694
		public ICheckOnlinePlayerT AsICheckOnlinePlayer()
		{
			return this.As<ICheckOnlinePlayerT>();
		}

		// Token: 0x0601DB10 RID: 121616 RVA: 0x0042D49C File Offset: 0x0042B69C
		public static ICheckEntityType_UnionUnion FromICheckOnlinePlayer(ICheckOnlinePlayerT _icheckonlineplayer)
		{
			return new ICheckEntityType_UnionUnion
			{
				Type = ICheckEntityType_Union.ICheckOnlinePlayer,
				Value = _icheckonlineplayer
			};
		}

		// Token: 0x0601DB11 RID: 121617 RVA: 0x0042D4B1 File Offset: 0x0042B6B1
		public ICheckTargetEntityT AsICheckTargetEntity()
		{
			return this.As<ICheckTargetEntityT>();
		}

		// Token: 0x0601DB12 RID: 121618 RVA: 0x0042D4B9 File Offset: 0x0042B6B9
		public static ICheckEntityType_UnionUnion FromICheckTargetEntity(ICheckTargetEntityT _ichecktargetentity)
		{
			return new ICheckEntityType_UnionUnion
			{
				Type = ICheckEntityType_Union.ICheckTargetEntity,
				Value = _ichecktargetentity
			};
		}

		// Token: 0x0601DB13 RID: 121619 RVA: 0x0042D4D0 File Offset: 0x0042B6D0
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
