using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC8 RID: 11208
	public class ICloseSkiConfig : ISkiConfigType
	{
		// Token: 0x0600F70F RID: 63247 RVA: 0x0023FA54 File Offset: 0x0023DC54
		public static ICloseSkiConfig Create(ICloseSkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x0600F710 RID: 63248 RVA: 0x0023FA73 File Offset: 0x0023DC73
		public override ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x17004C2E RID: 19502
		// (get) Token: 0x0600F711 RID: 63249 RVA: 0x0023FA80 File Offset: 0x0023DC80
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadICloseSkiConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x0400874A RID: 34634
		private ICloseSkiConfig Instance;

		// Token: 0x0400874B RID: 34635
		private ITargetEntityType _TargetCache;

		// Token: 0x0400874C RID: 34636
		private bool _TargetInited;
	}
}
