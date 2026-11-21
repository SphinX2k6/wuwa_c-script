using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCD RID: 27597
	public class IDefaultLookAtType_UnionUnion
	{
		// Token: 0x1700CA75 RID: 51829
		// (get) Token: 0x0602F80C RID: 194572 RVA: 0x0067A3E5 File Offset: 0x006785E5
		// (set) Token: 0x0602F80D RID: 194573 RVA: 0x0067A3ED File Offset: 0x006785ED
		public IDefaultLookAtType_Union Type { get; set; }

		// Token: 0x1700CA76 RID: 51830
		// (get) Token: 0x0602F80E RID: 194574 RVA: 0x0067A3F6 File Offset: 0x006785F6
		// (set) Token: 0x0602F80F RID: 194575 RVA: 0x0067A3FE File Offset: 0x006785FE
		public object Value { get; set; }

		// Token: 0x0602F810 RID: 194576 RVA: 0x0067A407 File Offset: 0x00678607
		public IDefaultLookAtType_UnionUnion()
		{
			this.Type = IDefaultLookAtType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F811 RID: 194577 RVA: 0x0067A41D File Offset: 0x0067861D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F812 RID: 194578 RVA: 0x0067A42F File Offset: 0x0067862F
		public IDefaultLookAtTypeT AsIDefaultLookAtType()
		{
			return this.As<IDefaultLookAtTypeT>();
		}

		// Token: 0x0602F813 RID: 194579 RVA: 0x0067A437 File Offset: 0x00678637
		public static IDefaultLookAtType_UnionUnion FromIDefaultLookAtType(IDefaultLookAtTypeT _idefaultlookattype)
		{
			return new IDefaultLookAtType_UnionUnion
			{
				Type = IDefaultLookAtType_Union.IDefaultLookAtType,
				Value = _idefaultlookattype
			};
		}

		// Token: 0x0602F814 RID: 194580 RVA: 0x0067A44C File Offset: 0x0067864C
		public ILookAtBubbleEntityT AsILookAtBubbleEntity()
		{
			return this.As<ILookAtBubbleEntityT>();
		}

		// Token: 0x0602F815 RID: 194581 RVA: 0x0067A454 File Offset: 0x00678654
		public static IDefaultLookAtType_UnionUnion FromILookAtBubbleEntity(ILookAtBubbleEntityT _ilookatbubbleentity)
		{
			return new IDefaultLookAtType_UnionUnion
			{
				Type = IDefaultLookAtType_Union.ILookAtBubbleEntity,
				Value = _ilookatbubbleentity
			};
		}

		// Token: 0x0602F816 RID: 194582 RVA: 0x0067A469 File Offset: 0x00678669
		public ILookAtTargetT AsILookAtTarget()
		{
			return this.As<ILookAtTargetT>();
		}

		// Token: 0x0602F817 RID: 194583 RVA: 0x0067A471 File Offset: 0x00678671
		public static IDefaultLookAtType_UnionUnion FromILookAtTarget(ILookAtTargetT _ilookattarget)
		{
			return new IDefaultLookAtType_UnionUnion
			{
				Type = IDefaultLookAtType_Union.ILookAtTarget,
				Value = _ilookattarget
			};
		}

		// Token: 0x0602F818 RID: 194584 RVA: 0x0067A488 File Offset: 0x00678688
		public static int Pack(FlatBufferBuilder builder, IDefaultLookAtType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDefaultLookAtType_Union.IDefaultLookAtType:
				return IDefaultLookAtType.Pack(builder, _o.AsIDefaultLookAtType()).Value;
			case IDefaultLookAtType_Union.ILookAtBubbleEntity:
				return ILookAtBubbleEntity.Pack(builder, _o.AsILookAtBubbleEntity()).Value;
			case IDefaultLookAtType_Union.ILookAtTarget:
				return ILookAtTarget.Pack(builder, _o.AsILookAtTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
