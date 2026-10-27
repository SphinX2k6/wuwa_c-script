using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D4 RID: 9428
	[NullableContext(1)]
	[Nullable(0)]
	public class Invoke : ActionParams
	{
		// Token: 0x0600D296 RID: 53910 RVA: 0x001F3E52 File Offset: 0x001F2052
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

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0600D297 RID: 53911 RVA: 0x001F3E71 File Offset: 0x001F2071
		public virtual int Who
		{
			get
			{
				return this.Instance.Who;
			}
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0600D298 RID: 53912 RVA: 0x001F3E7E File Offset: 0x001F207E
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

		// Token: 0x04007380 RID: 29568
		private IInvoke Instance;

		// Token: 0x04007381 RID: 29569
		[Nullable(2)]
		private ActionInfo _ActionInfoCache;

		// Token: 0x04007382 RID: 29570
		private bool _ActionInfoInited;
	}
}
