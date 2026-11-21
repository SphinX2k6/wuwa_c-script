using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5E RID: 3166
	public class IHitLogicActionByHitType : IHitLogicType
	{
		// Token: 0x06004863 RID: 18531 RVA: 0x000B71D6 File Offset: 0x000B53D6
		public static IHitLogicActionByHitType Create(IHitLogicActionByHitType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicActionByHitType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x000B71F5 File Offset: 0x000B53F5
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x000B7204 File Offset: 0x000B5404
		public virtual List<IActionByHitTypeConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				int configsLength = this.Instance.ConfigsLength;
				this._ConfigsCache = new List<IActionByHitTypeConfig>(configsLength);
				for (int i = 0; i < configsLength; i++)
				{
					this._ConfigsCache.Add(IActionByHitTypeConfig.Create(this.Instance.Configs(i)));
				}
				return this._ConfigsCache;
			}
		}

		// Token: 0x040028AF RID: 10415
		private IHitLogicActionByHitType Instance;

		// Token: 0x040028B0 RID: 10416
		private List<IActionByHitTypeConfig> _ConfigsCache;

		// Token: 0x040028B1 RID: 10417
		private bool _ConfigsInited;
	}
}
