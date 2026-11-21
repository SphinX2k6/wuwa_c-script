using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC6 RID: 11206
	public class ISkiConfigType
	{
		// Token: 0x0600F706 RID: 63238 RVA: 0x0023F981 File Offset: 0x0023DB81
		public static ISkiConfigType Create(ISkiConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x0600F707 RID: 63239 RVA: 0x0023F9A0 File Offset: 0x0023DBA0
		public virtual ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x0600F708 RID: 63240 RVA: 0x0023F9AD File Offset: 0x0023DBAD
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadISkiConfigType_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04008744 RID: 34628
		private ISkiConfigType Instance;

		// Token: 0x04008745 RID: 34629
		private ITargetEntityType _TargetCache;

		// Token: 0x04008746 RID: 34630
		private bool _TargetInited;
	}
}
