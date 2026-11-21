using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A97 RID: 10903
	public class ChangeTimer : ActionParams
	{
		// Token: 0x0600F08D RID: 61581 RVA: 0x00233EAD File Offset: 0x002320AD
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

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x0600F08E RID: 61582 RVA: 0x00233ECC File Offset: 0x002320CC
		public virtual ETimerType TimerType
		{
			get
			{
				return (ETimerType)this.Instance.TimerType;
			}
		}

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x0600F08F RID: 61583 RVA: 0x00233ED9 File Offset: 0x002320D9
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

		// Token: 0x04008447 RID: 33863
		private IChangeTimer Instance;

		// Token: 0x04008448 RID: 33864
		private IChangeTimerType _ChangeTypeCache;

		// Token: 0x04008449 RID: 33865
		private bool _ChangeTypeInited;
	}
}
