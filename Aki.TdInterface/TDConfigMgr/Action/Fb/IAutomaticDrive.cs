using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB8 RID: 11192
	public class IAutomaticDrive
	{
		// Token: 0x0600F6BA RID: 63162 RVA: 0x0023F057 File Offset: 0x0023D257
		public static IAutomaticDrive Create(IAutomaticDrive? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutomaticDrive
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x0600F6BB RID: 63163 RVA: 0x0023F076 File Offset: 0x0023D276
		public virtual float StandbyTime
		{
			get
			{
				return this.Instance.StandbyTime;
			}
		}

		// Token: 0x04008726 RID: 34598
		private IAutomaticDrive Instance;
	}
}
