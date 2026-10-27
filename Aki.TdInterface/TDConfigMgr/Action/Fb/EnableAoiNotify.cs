using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292D RID: 10541
	public class EnableAoiNotify : ActionParams
	{
		// Token: 0x0600E9E8 RID: 59880 RVA: 0x00224583 File Offset: 0x00222783
		[NullableContext(1)]
		public static EnableAoiNotify Create(IEnableAoiNotify? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableAoiNotify
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x0600E9E9 RID: 59881 RVA: 0x002245A2 File Offset: 0x002227A2
		public virtual EAoiNotifyState State
		{
			get
			{
				return (EAoiNotifyState)this.Instance.State;
			}
		}

		// Token: 0x04008107 RID: 33031
		private IEnableAoiNotify Instance;
	}
}
