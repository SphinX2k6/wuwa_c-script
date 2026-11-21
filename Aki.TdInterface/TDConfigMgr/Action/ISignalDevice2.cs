using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A4 RID: 8356
	public class ISignalDevice2 : IUiGame
	{
		// Token: 0x0600B178 RID: 45432 RVA: 0x0018F0E8 File Offset: 0x0018D2E8
		private ISignalDevice2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISignalDevice2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISignalDevice2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISignalDevice2_SetValue());
			}
			return result;
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x0018F120 File Offset: 0x0018D320
		public static ISignalDevice2 Create([Nullable(2)] ISignalDevice2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalDevice2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x0018F133 File Offset: 0x0018D333
		public static ISignalDevice2 CreateFromSetValue([Nullable(2)] ISignalDevice2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISignalDevice2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x0018F146 File Offset: 0x0018D346
		public new ISignalDevice2_SetValue ToSetValue()
		{
			return new ISignalDevice2_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600B17C RID: 45436 RVA: 0x0018F165 File Offset: 0x0018D365
		// (set) Token: 0x0600B17D RID: 45437 RVA: 0x0018F190 File Offset: 0x0018D390
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600B17E RID: 45438 RVA: 0x0018F1A0 File Offset: 0x0018D3A0
		// (set) Token: 0x0600B17F RID: 45439 RVA: 0x0018F233 File Offset: 0x0018D433
		public virtual List<IColorPiece> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IColorPiece> config = this.FbInstance.Config;
					if (config != null)
					{
						this._ConfigCache = new List<IColorPiece>(config.Count);
						for (int i = 0; i < config.Count; i++)
						{
							this._ConfigCache.Add(IColorPiece.Create(config[i]));
						}
					}
				}
				else
				{
					ISignalDevice2_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x04006978 RID: 27000
		[Nullable(2)]
		protected new ISignalDevice2 FbInstance;

		// Token: 0x04006979 RID: 27001
		[Nullable(2)]
		protected new ISignalDevice2_SetValue PocoInterface;

		// Token: 0x0400697A RID: 27002
		private List<IColorPiece> _ConfigCache;

		// Token: 0x0400697B RID: 27003
		private bool _ConfigInited;
	}
}
