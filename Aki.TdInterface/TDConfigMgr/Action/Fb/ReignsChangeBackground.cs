using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D3C RID: 11580
	public class ReignsChangeBackground : ActionParams
	{
		// Token: 0x0600FCF6 RID: 64758 RVA: 0x00248DD9 File Offset: 0x00246FD9
		public static ReignsChangeBackground Create(IReignsChangeBackground? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangeBackground
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x0600FCF7 RID: 64759 RVA: 0x00248DF8 File Offset: 0x00246FF8
		public virtual string Background
		{
			get
			{
				return this.Instance.Background;
			}
		}

		// Token: 0x17004F2D RID: 20269
		// (get) Token: 0x0600FCF8 RID: 64760 RVA: 0x00248E05 File Offset: 0x00247005
		public virtual EReignsBackgroundChangeMode ChangeMode
		{
			get
			{
				return (EReignsBackgroundChangeMode)this.Instance.ChangeMode;
			}
		}

		// Token: 0x04008A1E RID: 35358
		private IReignsChangeBackground Instance;
	}
}
