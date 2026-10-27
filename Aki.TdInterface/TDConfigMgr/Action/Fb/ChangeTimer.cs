using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C4 RID: 10180
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeTimer : ActionParams
	{
		// Token: 0x0600E26B RID: 57963 RVA: 0x002170D9 File Offset: 0x002152D9
		public static ChangeTimer Create(IChangeTimer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeTimer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x0600E26C RID: 57964 RVA: 0x002170F8 File Offset: 0x002152F8
		public virtual ETimerType TimerType
		{
			get
			{
				return (ETimerType)this.Instance.TimerType;
			}
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x0600E26D RID: 57965 RVA: 0x00217105 File Offset: 0x00215305
		public virtual IChangeTimerType ChangeType
		{
			get
			{
				if (this._ChangeTypeInited)
				{
					return this._ChangeTypeCache;
				}
				this._ChangeTypeInited = true;
				this._ChangeTypeCache = ActionReadHelper.ReadChangeTimer_ChangeType(this.Instance);
				return this._ChangeTypeCache;
			}
		}

		// Token: 0x04007D90 RID: 32144
		private IChangeTimer Instance;

		// Token: 0x04007D91 RID: 32145
		private IChangeTimerType _ChangeTypeCache;

		// Token: 0x04007D92 RID: 32146
		private bool _ChangeTypeInited;
	}
}
