using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015C2 RID: 5570
	public class ITetrisPlayModeEndless : ITetrisPlayModeBase
	{
		// Token: 0x06007DB4 RID: 32180 RVA: 0x0012AFBD File Offset: 0x001291BD
		public static ITetrisPlayModeEndless Create(ITetrisPlayModeEndless? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeEndless
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x0012AFDC File Offset: 0x001291DC
		public override ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x0012AFEC File Offset: 0x001291EC
		public virtual int? SpeedLevel
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SpeedLevel);
			}
		}

		// Token: 0x040048BA RID: 18618
		private ITetrisPlayModeEndless Instance;
	}
}
