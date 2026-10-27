using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200655C RID: 25948
	public class IDefaultLookAtType_UnionUnion
	{
		// Token: 0x1700C0DA RID: 49370
		// (get) Token: 0x0602D050 RID: 184400 RVA: 0x0062DC21 File Offset: 0x0062BE21
		// (set) Token: 0x0602D051 RID: 184401 RVA: 0x0062DC29 File Offset: 0x0062BE29
		public IDefaultLookAtType_Union Type { get; set; }

		// Token: 0x1700C0DB RID: 49371
		// (get) Token: 0x0602D052 RID: 184402 RVA: 0x0062DC32 File Offset: 0x0062BE32
		// (set) Token: 0x0602D053 RID: 184403 RVA: 0x0062DC3A File Offset: 0x0062BE3A
		public object Value { get; set; }

		// Token: 0x0602D054 RID: 184404 RVA: 0x0062DC43 File Offset: 0x0062BE43
		public IDefaultLookAtType_UnionUnion()
		{
			this.Type = IDefaultLookAtType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D055 RID: 184405 RVA: 0x0062DC59 File Offset: 0x0062BE59
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D056 RID: 184406 RVA: 0x0062DC6B File Offset: 0x0062BE6B
		public IDefaultLookAtTypeT AsIDefaultLookAtType()
		{
			return this.As<IDefaultLookAtTypeT>();
		}

		// Token: 0x0602D057 RID: 184407 RVA: 0x0062DC73 File Offset: 0x0062BE73
		public static IDefaultLookAtType_UnionUnion FromIDefaultLookAtType(IDefaultLookAtTypeT _idefaultlookattype)
		{
			return new IDefaultLookAtType_UnionUnion
			{
				Type = IDefaultLookAtType_Union.IDefaultLookAtType,
				Value = _idefaultlookattype
			};
		}

		// Token: 0x0602D058 RID: 184408 RVA: 0x0062DC88 File Offset: 0x0062BE88
		public ILookAtBubbleEntityT AsILookAtBubbleEntity()
		{
			return this.As<ILookAtBubbleEntityT>();
		}

		// Token: 0x0602D059 RID: 184409 RVA: 0x0062DC90 File Offset: 0x0062BE90
		public static IDefaultLookAtType_UnionUnion FromILookAtBubbleEntity(ILookAtBubbleEntityT _ilookatbubbleentity)
		{
			return new IDefaultLookAtType_UnionUnion
			{
				Type = IDefaultLookAtType_Union.ILookAtBubbleEntity,
				Value = _ilookatbubbleentity
			};
		}

		// Token: 0x0602D05A RID: 184410 RVA: 0x0062DCA5 File Offset: 0x0062BEA5
		public ILookAtTargetT AsILookAtTarget()
		{
			return this.As<ILookAtTargetT>();
		}

		// Token: 0x0602D05B RID: 184411 RVA: 0x0062DCAD File Offset: 0x0062BEAD
		public static IDefaultLookAtType_UnionUnion FromILookAtTarget(ILookAtTargetT _ilookattarget)
		{
			return new IDefaultLookAtType_UnionUnion
			{
				Type = IDefaultLookAtType_Union.ILookAtTarget,
				Value = _ilookattarget
			};
		}

		// Token: 0x0602D05C RID: 184412 RVA: 0x0062DCC4 File Offset: 0x0062BEC4
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
