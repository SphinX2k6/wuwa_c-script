using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002779 RID: 10105
	public class Invoke : ActionParams
	{
		// Token: 0x0600DFEB RID: 57323 RVA: 0x0020F6AE File Offset: 0x0020D8AE
		public static Invoke Create(IInvoke? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Invoke
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x0020F6CD File Offset: 0x0020D8CD
		public virtual int Who
		{
			get
			{
				return this.Instance.Who;
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x0600DFED RID: 57325 RVA: 0x0020F6DA File Offset: 0x0020D8DA
		public virtual ActionInfo ActionInfo
		{
			get
			{
				if (this._ActionInfoInited)
				{
					return this._ActionInfoCache;
				}
				this._ActionInfoInited = true;
				this._ActionInfoCache = ActionInfo.Create(this.Instance.ActionInfo);
				return this._ActionInfoCache;
			}
		}

		// Token: 0x040079CD RID: 31181
		private IInvoke Instance;

		// Token: 0x040079CE RID: 31182
		[Nullable(2)]
		private ActionInfo _ActionInfoCache;

		// Token: 0x040079CF RID: 31183
		private bool _ActionInfoInited;
	}
}
