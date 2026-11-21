using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279D RID: 10141
	public class IFixedTime
	{
		// Token: 0x0600E0A3 RID: 57507 RVA: 0x00210DF0 File Offset: 0x0020EFF0
		public static IFixedTime Create(IFixedTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x00210E0F File Offset: 0x0020F00F
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x0600E0A5 RID: 57509 RVA: 0x00210E1C File Offset: 0x0020F01C
		public virtual int Minutes
		{
			get
			{
				return this.Instance.Minutes;
			}
		}

		// Token: 0x04007A27 RID: 31271
		private IFixedTime Instance;
	}
}
