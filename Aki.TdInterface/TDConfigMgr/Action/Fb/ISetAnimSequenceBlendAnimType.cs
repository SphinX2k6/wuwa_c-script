using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEE RID: 10990
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAnimSequenceBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600F0D2 RID: 61650 RVA: 0x0022F34B File Offset: 0x0022D54B
		public static ISetAnimSequenceBlendAnimType Create(ISetAnimSequenceBlendAnimType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAnimSequenceBlendAnimType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x0600F0D3 RID: 61651 RVA: 0x0022F36A File Offset: 0x0022D56A
		public override EBlendAnimType Type
		{
			get
			{
				return (EBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x0600F0D4 RID: 61652 RVA: 0x0022F377 File Offset: 0x0022D577
		public virtual string AnimSequence
		{
			get
			{
				return this.Instance.AnimSequence;
			}
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x0600F0D5 RID: 61653 RVA: 0x0022F384 File Offset: 0x0022D584
		public virtual float? ProtectTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ProtectTime);
			}
		}

		// Token: 0x0400847A RID: 33914
		private ISetAnimSequenceBlendAnimType Instance;
	}
}
