using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE8 RID: 3304
	[NullableContext(2)]
	[Nullable(0)]
	public class IMonsterPerformConfig
	{
		// Token: 0x06004B67 RID: 19303 RVA: 0x000BD145 File Offset: 0x000BB345
		[NullableContext(0)]
		public static IMonsterPerformConfig Create(IMonsterPerformConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterPerformConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06004B68 RID: 19304 RVA: 0x000BD164 File Offset: 0x000BB364
		public virtual IMonsterShowOnDeathEffect ShowOnDeath
		{
			get
			{
				if (this._ShowOnDeathInited)
				{
					return this._ShowOnDeathCache;
				}
				this._ShowOnDeathInited = true;
				this._ShowOnDeathCache = IMonsterShowOnDeathEffect.Create(this.Instance.ShowOnDeath);
				return this._ShowOnDeathCache;
			}
		}

		// Token: 0x04002A9D RID: 10909
		private IMonsterPerformConfig Instance;

		// Token: 0x04002A9E RID: 10910
		private IMonsterShowOnDeathEffect _ShowOnDeathCache;

		// Token: 0x04002A9F RID: 10911
		private bool _ShowOnDeathInited;
	}
}
