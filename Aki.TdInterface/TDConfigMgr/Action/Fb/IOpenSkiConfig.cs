using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC7 RID: 11207
	public class IOpenSkiConfig : ISkiConfigType
	{
		// Token: 0x0600F70A RID: 63242 RVA: 0x0023F9E4 File Offset: 0x0023DBE4
		public static IOpenSkiConfig Create(IOpenSkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x0600F70B RID: 63243 RVA: 0x0023FA03 File Offset: 0x0023DC03
		public override ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x0600F70C RID: 63244 RVA: 0x0023FA10 File Offset: 0x0023DC10
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIOpenSkiConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x0600F70D RID: 63245 RVA: 0x0023FA3F File Offset: 0x0023DC3F
		public virtual string SkiConfig
		{
			get
			{
				return this.Instance.SkiConfig;
			}
		}

		// Token: 0x04008747 RID: 34631
		private IOpenSkiConfig Instance;

		// Token: 0x04008748 RID: 34632
		private ITargetEntityType _TargetCache;

		// Token: 0x04008749 RID: 34633
		private bool _TargetInited;
	}
}
