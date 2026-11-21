using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE2 RID: 11746
	public class ISetAnimSequenceBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600FF88 RID: 65416 RVA: 0x0024D057 File Offset: 0x0024B257
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

		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x0600FF89 RID: 65417 RVA: 0x0024D076 File Offset: 0x0024B276
		public override EBlendAnimType Type
		{
			get
			{
				return (EBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x0600FF8A RID: 65418 RVA: 0x0024D083 File Offset: 0x0024B283
		public virtual string AnimSequence
		{
			get
			{
				return this.Instance.AnimSequence;
			}
		}

		// Token: 0x17005074 RID: 20596
		// (get) Token: 0x0600FF8B RID: 65419 RVA: 0x0024D090 File Offset: 0x0024B290
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

		// Token: 0x04008B7E RID: 35710
		private ISetAnimSequenceBlendAnimType Instance;
	}
}
