using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000514 RID: 1300
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterPerformConfig
	{
		// Token: 0x06001A5A RID: 6746 RVA: 0x0004CDC4 File Offset: 0x0004AFC4
		private IMonsterPerformConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterPerformConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterPerformConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterPerformConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0004CDFC File Offset: 0x0004AFFC
		public static IMonsterPerformConfig Create([Nullable(2)] IMonsterPerformConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterPerformConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0004CE0F File Offset: 0x0004B00F
		public static IMonsterPerformConfig CreateFromSetValue([Nullable(2)] IMonsterPerformConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterPerformConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0004CE22 File Offset: 0x0004B022
		public IMonsterPerformConfig_SetValue ToSetValue()
		{
			return new IMonsterPerformConfig_SetValue
			{
				ShowOnDeath = this.ShowOnDeath
			};
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0004CE38 File Offset: 0x0004B038
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0004CE99 File Offset: 0x0004B099
		[Nullable(2)]
		public virtual IMonsterShowOnDeathEffect ShowOnDeath
		{
			[NullableContext(2)]
			get
			{
				if (this._ShowOnDeathInited)
				{
					return this._ShowOnDeathCache;
				}
				this._ShowOnDeathInited = true;
				if (this.FbInstance != null)
				{
					this._ShowOnDeathCache = IMonsterShowOnDeathEffect.Create(this.FbInstance.ShowOnDeath);
				}
				else
				{
					IMonsterPerformConfig_SetValue pocoInterface = this.PocoInterface;
					this._ShowOnDeathCache = ((pocoInterface != null) ? pocoInterface.ShowOnDeath : null);
				}
				return this._ShowOnDeathCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ShowOnDeath = value;
				this._ShowOnDeathInited = false;
			}
		}

		// Token: 0x0400131A RID: 4890
		[Nullable(2)]
		protected IMonsterPerformConfig FbInstance;

		// Token: 0x0400131B RID: 4891
		[Nullable(2)]
		protected IMonsterPerformConfig_SetValue PocoInterface;

		// Token: 0x0400131C RID: 4892
		private IMonsterShowOnDeathEffect _ShowOnDeathCache;

		// Token: 0x0400131D RID: 4893
		private bool _ShowOnDeathInited;
	}
}
