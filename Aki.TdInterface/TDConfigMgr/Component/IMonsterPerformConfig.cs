using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057B RID: 1403
	public class IMonsterPerformConfig
	{
		// Token: 0x06001C56 RID: 7254 RVA: 0x00051B80 File Offset: 0x0004FD80
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

		// Token: 0x06001C57 RID: 7255 RVA: 0x00051BB8 File Offset: 0x0004FDB8
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

		// Token: 0x06001C58 RID: 7256 RVA: 0x00051BCB File Offset: 0x0004FDCB
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

		// Token: 0x06001C59 RID: 7257 RVA: 0x00051BDE File Offset: 0x0004FDDE
		public IMonsterPerformConfig_SetValue ToSetValue()
		{
			return new IMonsterPerformConfig_SetValue
			{
				ShowOnDeath = this.ShowOnDeath
			};
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00051BF4 File Offset: 0x0004FDF4
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x00051C55 File Offset: 0x0004FE55
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

		// Token: 0x04001484 RID: 5252
		[Nullable(2)]
		protected IMonsterPerformConfig FbInstance;

		// Token: 0x04001485 RID: 5253
		[Nullable(2)]
		protected IMonsterPerformConfig_SetValue PocoInterface;

		// Token: 0x04001486 RID: 5254
		private IMonsterShowOnDeathEffect _ShowOnDeathCache;

		// Token: 0x04001487 RID: 5255
		private bool _ShowOnDeathInited;
	}
}
