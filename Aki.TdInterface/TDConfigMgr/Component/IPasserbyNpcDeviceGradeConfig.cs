using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200062D RID: 1581
	public class IPasserbyNpcDeviceGradeConfig
	{
		// Token: 0x06002144 RID: 8516 RVA: 0x0005CCF8 File Offset: 0x0005AEF8
		private IPasserbyNpcDeviceGradeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcDeviceGradeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcDeviceGradeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcDeviceGradeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0005CD30 File Offset: 0x0005AF30
		public static IPasserbyNpcDeviceGradeConfig Create([Nullable(2)] IPasserbyNpcDeviceGradeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcDeviceGradeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0005CD43 File Offset: 0x0005AF43
		public static IPasserbyNpcDeviceGradeConfig CreateFromSetValue([Nullable(2)] IPasserbyNpcDeviceGradeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcDeviceGradeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0005CD56 File Offset: 0x0005AF56
		public IPasserbyNpcDeviceGradeConfig_SetValue ToSetValue()
		{
			return new IPasserbyNpcDeviceGradeConfig_SetValue
			{
				SpawnCountOverride = this.SpawnCountOverride
			};
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x0005CD6C File Offset: 0x0005AF6C
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x0005CDCD File Offset: 0x0005AFCD
		[Nullable(2)]
		public virtual IPasserbyNpcSpawnCountOverride SpawnCountOverride
		{
			[NullableContext(2)]
			get
			{
				if (this._SpawnCountOverrideInited)
				{
					return this._SpawnCountOverrideCache;
				}
				this._SpawnCountOverrideInited = true;
				if (this.FbInstance != null)
				{
					this._SpawnCountOverrideCache = IPasserbyNpcSpawnCountOverride.Create(this.FbInstance.SpawnCountOverride);
				}
				else
				{
					IPasserbyNpcDeviceGradeConfig_SetValue pocoInterface = this.PocoInterface;
					this._SpawnCountOverrideCache = ((pocoInterface != null) ? pocoInterface.SpawnCountOverride : null);
				}
				return this._SpawnCountOverrideCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SpawnCountOverride = value;
				this._SpawnCountOverrideInited = false;
			}
		}

		// Token: 0x04001792 RID: 6034
		[Nullable(2)]
		protected IPasserbyNpcDeviceGradeConfig FbInstance;

		// Token: 0x04001793 RID: 6035
		[Nullable(2)]
		protected IPasserbyNpcDeviceGradeConfig_SetValue PocoInterface;

		// Token: 0x04001794 RID: 6036
		private IPasserbyNpcSpawnCountOverride _SpawnCountOverrideCache;

		// Token: 0x04001795 RID: 6037
		private bool _SpawnCountOverrideInited;
	}
}
