using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002992 RID: 10642
	public class RemoveTrialFollowShooter : ActionParams
	{
		// Token: 0x0600EB9C RID: 60316 RVA: 0x0022748A File Offset: 0x0022568A
		[NullableContext(1)]
		public static RemoveTrialFollowShooter Create(IRemoveTrialFollowShooter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveTrialFollowShooter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x0600EB9D RID: 60317 RVA: 0x002274A9 File Offset: 0x002256A9
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040081C2 RID: 33218
		private IRemoveTrialFollowShooter Instance;
	}
}
