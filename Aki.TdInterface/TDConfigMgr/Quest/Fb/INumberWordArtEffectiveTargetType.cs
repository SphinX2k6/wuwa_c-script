using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001332 RID: 4914
	public class INumberWordArtEffectiveTargetType : IWordArtEffectiveTargetType
	{
		// Token: 0x060070AA RID: 28842 RVA: 0x0010FDC8 File Offset: 0x0010DFC8
		[NullableContext(1)]
		public static INumberWordArtEffectiveTargetType Create(INumberWordArtEffectiveTargetType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberWordArtEffectiveTargetType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x060070AB RID: 28843 RVA: 0x0010FDE7 File Offset: 0x0010DFE7
		public override EWordArtEffectiveTargetType Type
		{
			get
			{
				return (EWordArtEffectiveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x060070AC RID: 28844 RVA: 0x0010FDF4 File Offset: 0x0010DFF4
		public virtual bool? ShowUiMotion
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowUiMotion);
			}
		}

		// Token: 0x040040FE RID: 16638
		private INumberWordArtEffectiveTargetType Instance;
	}
}
