using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E6D RID: 7789
	[NullableContext(1)]
	[Nullable(0)]
	public class ISignalDevice : IUiGame
	{
		// Token: 0x0600A6B6 RID: 42678 RVA: 0x00179278 File Offset: 0x00177478
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

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x001792B0 File Offset: 0x001774B0
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

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x001792C3 File Offset: 0x001774C3
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

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x001792D6 File Offset: 0x001774D6
		public new ISignalDevice_SetValue ToSetValue()
		{
			return new ISignalDevice_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600A6BA RID: 42682 RVA: 0x001792F5 File Offset: 0x001774F5
		// (set) Token: 0x0600A6BB RID: 42683 RVA: 0x00179320 File Offset: 0x00177520
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

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600A6BC RID: 42684 RVA: 0x00179330 File Offset: 0x00177530
		// (set) Token: 0x0600A6BD RID: 42685 RVA: 0x001793C3 File Offset: 0x001775C3
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

		// Token: 0x0400638E RID: 25486
		[Nullable(2)]
		protected new ISignalDevice FbInstance;

		// Token: 0x0400638F RID: 25487
		[Nullable(2)]
		protected new ISignalDevice_SetValue PocoInterface;

		// Token: 0x04006390 RID: 25488
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04006391 RID: 25489
		private bool _ConfigInited;
	}
}
