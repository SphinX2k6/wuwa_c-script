using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200026A RID: 618
	public class ICircuitConnect : ITurntableConnectorGameplayBase
	{
		// Token: 0x06000AE2 RID: 2786 RVA: 0x0002CFEC File Offset: 0x0002B1EC
		private ICircuitConnect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnect_SetValue());
			}
			return result;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0002D024 File Offset: 0x0002B224
		public static ICircuitConnect Create([Nullable(2)] ICircuitConnect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0002D037 File Offset: 0x0002B237
		public static ICircuitConnect CreateFromSetValue([Nullable(2)] ICircuitConnect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002D04A File Offset: 0x0002B24A
		public new ICircuitConnect_SetValue ToSetValue()
		{
			return new ICircuitConnect_SetValue
			{
				Type = this.Type,
				AssetConfigId = this.AssetConfigId,
				LevelData = this.LevelData
			};
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0002D075 File Offset: 0x0002B275
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
		public override ETurntableConnectorGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETurntableConnectorGameplayType.CircuitConnect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0002D0AE File Offset: 0x0002B2AE
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0002D0D9 File Offset: 0x0002B2D9
		public virtual int AssetConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AssetConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AssetConfigId;
			}
			set
			{
				this.GetOrCreatePoco().AssetConfigId = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0002D0E8 File Offset: 0x0002B2E8
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x0002D149 File Offset: 0x0002B349
		public virtual ICircuitConnectLevelData LevelData
		{
			get
			{
				if (this._LevelDataInited)
				{
					return this._LevelDataCache;
				}
				this._LevelDataInited = true;
				if (this.FbInstance != null)
				{
					this._LevelDataCache = ICircuitConnectLevelData.Create(this.FbInstance.LevelData);
				}
				else
				{
					ICircuitConnect_SetValue pocoInterface = this.PocoInterface;
					this._LevelDataCache = ((pocoInterface != null) ? pocoInterface.LevelData : null);
				}
				return this._LevelDataCache;
			}
			set
			{
				this.GetOrCreatePoco().LevelData = value;
				this._LevelDataInited = false;
			}
		}

		// Token: 0x04000AF4 RID: 2804
		[Nullable(2)]
		protected new ICircuitConnect FbInstance;

		// Token: 0x04000AF5 RID: 2805
		[Nullable(2)]
		protected new ICircuitConnect_SetValue PocoInterface;

		// Token: 0x04000AF6 RID: 2806
		private ICircuitConnectLevelData _LevelDataCache;

		// Token: 0x04000AF7 RID: 2807
		private bool _LevelDataInited;
	}
}
