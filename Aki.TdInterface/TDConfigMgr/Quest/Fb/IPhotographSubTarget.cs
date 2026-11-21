using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001558 RID: 5464
	public class IPhotographSubTarget
	{
		// Token: 0x06007B39 RID: 31545 RVA: 0x0012532B File Offset: 0x0012352B
		public static IPhotographSubTarget Create(IPhotographSubTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographSubTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x06007B3A RID: 31546 RVA: 0x0012534A File Offset: 0x0012354A
		public virtual EPhotographSubTargetType Type
		{
			get
			{
				return (EPhotographSubTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040046F6 RID: 18166
		private IPhotographSubTarget Instance;
	}
}
