using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A35 RID: 10805
	public class SetupMoraleSystem : ActionParams
	{
		// Token: 0x0600EE03 RID: 60931 RVA: 0x0022ACC7 File Offset: 0x00228EC7
		[NullableContext(1)]
		public static SetupMoraleSystem Create(ISetupMoraleSystem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetupMoraleSystem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B5B RID: 19291
		// (get) Token: 0x0600EE04 RID: 60932 RVA: 0x0022ACE6 File Offset: 0x00228EE6
		public virtual int MoralePlayId
		{
			get
			{
				return this.Instance.MoralePlayId;
			}
		}

		// Token: 0x17004B5C RID: 19292
		// (get) Token: 0x0600EE05 RID: 60933 RVA: 0x0022ACF3 File Offset: 0x00228EF3
		public virtual bool IsOn
		{
			get
			{
				return this.Instance.IsOn;
			}
		}

		// Token: 0x040082FD RID: 33533
		private ISetupMoraleSystem Instance;
	}
}
