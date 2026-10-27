using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A5 RID: 30373
	public class TDefaultLookAtTypeUnion
	{
		// Token: 0x1700E607 RID: 58887
		// (get) Token: 0x0603742E RID: 226350 RVA: 0x0077D304 File Offset: 0x0077B504
		// (set) Token: 0x0603742F RID: 226351 RVA: 0x0077D30C File Offset: 0x0077B50C
		public TDefaultLookAtType Type { get; set; }

		// Token: 0x1700E608 RID: 58888
		// (get) Token: 0x06037430 RID: 226352 RVA: 0x0077D315 File Offset: 0x0077B515
		// (set) Token: 0x06037431 RID: 226353 RVA: 0x0077D31D File Offset: 0x0077B51D
		public object Value { get; set; }

		// Token: 0x06037432 RID: 226354 RVA: 0x0077D326 File Offset: 0x0077B526
		public TDefaultLookAtTypeUnion()
		{
			this.Type = TDefaultLookAtType.NONE;
			this.Value = null;
		}

		// Token: 0x06037433 RID: 226355 RVA: 0x0077D33C File Offset: 0x0077B53C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037434 RID: 226356 RVA: 0x0077D34E File Offset: 0x0077B54E
		public ILookAtBubbleEntityT AsILookAtBubbleEntity()
		{
			return this.As<ILookAtBubbleEntityT>();
		}

		// Token: 0x06037435 RID: 226357 RVA: 0x0077D356 File Offset: 0x0077B556
		public static TDefaultLookAtTypeUnion FromILookAtBubbleEntity(ILookAtBubbleEntityT _ilookatbubbleentity)
		{
			return new TDefaultLookAtTypeUnion
			{
				Type = TDefaultLookAtType.ILookAtBubbleEntity,
				Value = _ilookatbubbleentity
			};
		}

		// Token: 0x06037436 RID: 226358 RVA: 0x0077D36B File Offset: 0x0077B56B
		public ILookAtTargetT AsILookAtTarget()
		{
			return this.As<ILookAtTargetT>();
		}

		// Token: 0x06037437 RID: 226359 RVA: 0x0077D373 File Offset: 0x0077B573
		public static TDefaultLookAtTypeUnion FromILookAtTarget(ILookAtTargetT _ilookattarget)
		{
			return new TDefaultLookAtTypeUnion
			{
				Type = TDefaultLookAtType.ILookAtTarget,
				Value = _ilookattarget
			};
		}

		// Token: 0x06037438 RID: 226360 RVA: 0x0077D388 File Offset: 0x0077B588
		public static int Pack(FlatBufferBuilder builder, TDefaultLookAtTypeUnion _o)
		{
			TDefaultLookAtType type = _o.Type;
			if (type == TDefaultLookAtType.ILookAtBubbleEntity)
			{
				return ILookAtBubbleEntity.Pack(builder, _o.AsILookAtBubbleEntity()).Value;
			}
			if (type != TDefaultLookAtType.ILookAtTarget)
			{
				return 0;
			}
			return ILookAtTarget.Pack(builder, _o.AsILookAtTarget()).Value;
		}
	}
}
