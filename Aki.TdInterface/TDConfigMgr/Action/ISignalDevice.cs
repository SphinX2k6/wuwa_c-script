using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A2 RID: 8354
	public class ISignalDevice : IUiGame
	{
		// Token: 0x0600B16E RID: 45422 RVA: 0x0018EF78 File Offset: 0x0018D178
		private ISignalDevice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISignalDevice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISignalDevice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISignalDevice_SetValue());
			}
			return result;
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x0018EFB0 File Offset: 0x0018D1B0
		public static ISignalDevice Create([Nullable(2)] ISignalDevice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalDevice
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x0018EFC3 File Offset: 0x0018D1C3
		public static ISignalDevice CreateFromSetValue([Nullable(2)] ISignalDevice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISignalDevice
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x0018EFD6 File Offset: 0x0018D1D6
		public new ISignalDevice_SetValue ToSetValue()
		{
			return new ISignalDevice_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600B172 RID: 45426 RVA: 0x0018EFF5 File Offset: 0x0018D1F5
		// (set) Token: 0x0600B173 RID: 45427 RVA: 0x0018F020 File Offset: 0x0018D220
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

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600B174 RID: 45428 RVA: 0x0018F030 File Offset: 0x0018D230
		// (set) Token: 0x0600B175 RID: 45429 RVA: 0x0018F0C3 File Offset: 0x0018D2C3
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
					ISignalDevice_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006972 RID: 26994
		[Nullable(2)]
		protected new ISignalDevice FbInstance;

		// Token: 0x04006973 RID: 26995
		[Nullable(2)]
		protected new ISignalDevice_SetValue PocoInterface;

		// Token: 0x04006974 RID: 26996
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04006975 RID: 26997
		private bool _ConfigInited;
	}
}
