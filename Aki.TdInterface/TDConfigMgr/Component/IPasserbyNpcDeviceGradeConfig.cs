using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C2 RID: 1474
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcDeviceGradeConfig
	{
		// Token: 0x06001F34 RID: 7988 RVA: 0x00057CCC File Offset: 0x00055ECC
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

		// Token: 0x06001F35 RID: 7989 RVA: 0x00057D04 File Offset: 0x00055F04
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

		// Token: 0x06001F36 RID: 7990 RVA: 0x00057D17 File Offset: 0x00055F17
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

		// Token: 0x06001F37 RID: 7991 RVA: 0x00057D2A File Offset: 0x00055F2A
		public IPasserbyNpcDeviceGradeConfig_SetValue ToSetValue()
		{
			return new IPasserbyNpcDeviceGradeConfig_SetValue
			{
				SpawnCountOverride = this.SpawnCountOverride
			};
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00057D40 File Offset: 0x00055F40
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00057DA1 File Offset: 0x00055FA1
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

		// Token: 0x0400161E RID: 5662
		[Nullable(2)]
		protected IPasserbyNpcDeviceGradeConfig FbInstance;

		// Token: 0x0400161F RID: 5663
		[Nullable(2)]
		protected IPasserbyNpcDeviceGradeConfig_SetValue PocoInterface;

		// Token: 0x04001620 RID: 5664
		private IPasserbyNpcSpawnCountOverride _SpawnCountOverrideCache;

		// Token: 0x04001621 RID: 5665
		private bool _SpawnCountOverrideInited;
	}
}
