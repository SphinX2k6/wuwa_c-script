using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B90 RID: 2960
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicActionByHitType : IHitLogicType
	{
		// Token: 0x0600440A RID: 17418 RVA: 0x000AD112 File Offset: 0x000AB312
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

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x000AD131 File Offset: 0x000AB331
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x000AD140 File Offset: 0x000AB340
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

		// Token: 0x04002667 RID: 9831
		private IHitLogicActionByHitType Instance;

		// Token: 0x04002668 RID: 9832
		private List<IActionByHitTypeConfig> _ConfigsCache;

		// Token: 0x04002669 RID: 9833
		private bool _ConfigsInited;
	}
}
