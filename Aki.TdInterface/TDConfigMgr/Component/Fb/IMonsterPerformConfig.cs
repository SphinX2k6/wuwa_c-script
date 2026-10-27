using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C18 RID: 3096
	[NullableContext(2)]
	[Nullable(0)]
	public class IMonsterPerformConfig
	{
		// Token: 0x06004704 RID: 18180 RVA: 0x000B2F79 File Offset: 0x000B1179
		[NullableContext(1)]
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

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06004705 RID: 18181 RVA: 0x000B2F98 File Offset: 0x000B1198
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

		// Token: 0x04002851 RID: 10321
		private IMonsterPerformConfig Instance;

		// Token: 0x04002852 RID: 10322
		private IMonsterShowOnDeathEffect _ShowOnDeathCache;

		// Token: 0x04002853 RID: 10323
		private bool _ShowOnDeathInited;
	}
}
