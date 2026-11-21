using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EB0 RID: 32432
	public class TDefaultLookAtTypeUnion
	{
		// Token: 0x1700F243 RID: 62019
		// (get) Token: 0x0603A8D1 RID: 239825 RVA: 0x007E1458 File Offset: 0x007DF658
		// (set) Token: 0x0603A8D2 RID: 239826 RVA: 0x007E1460 File Offset: 0x007DF660
		public TDefaultLookAtType Type { get; set; }

		// Token: 0x1700F244 RID: 62020
		// (get) Token: 0x0603A8D3 RID: 239827 RVA: 0x007E1469 File Offset: 0x007DF669
		// (set) Token: 0x0603A8D4 RID: 239828 RVA: 0x007E1471 File Offset: 0x007DF671
		public object Value { get; set; }

		// Token: 0x0603A8D5 RID: 239829 RVA: 0x007E147A File Offset: 0x007DF67A
		public TDefaultLookAtTypeUnion()
		{
			this.Type = TDefaultLookAtType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A8D6 RID: 239830 RVA: 0x007E1490 File Offset: 0x007DF690
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A8D7 RID: 239831 RVA: 0x007E14A2 File Offset: 0x007DF6A2
		public ILookAtBubbleEntityT AsILookAtBubbleEntity()
		{
			return this.As<ILookAtBubbleEntityT>();
		}

		// Token: 0x0603A8D8 RID: 239832 RVA: 0x007E14AA File Offset: 0x007DF6AA
		public static TDefaultLookAtTypeUnion FromILookAtBubbleEntity(ILookAtBubbleEntityT _ilookatbubbleentity)
		{
			return new TDefaultLookAtTypeUnion
			{
				Type = TDefaultLookAtType.ILookAtBubbleEntity,
				Value = _ilookatbubbleentity
			};
		}

		// Token: 0x0603A8D9 RID: 239833 RVA: 0x007E14BF File Offset: 0x007DF6BF
		public ILookAtTargetT AsILookAtTarget()
		{
			return this.As<ILookAtTargetT>();
		}

		// Token: 0x0603A8DA RID: 239834 RVA: 0x007E14C7 File Offset: 0x007DF6C7
		public static TDefaultLookAtTypeUnion FromILookAtTarget(ILookAtTargetT _ilookattarget)
		{
			return new TDefaultLookAtTypeUnion
			{
				Type = TDefaultLookAtType.ILookAtTarget,
				Value = _ilookattarget
			};
		}

		// Token: 0x0603A8DB RID: 239835 RVA: 0x007E14DC File Offset: 0x007DF6DC
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
