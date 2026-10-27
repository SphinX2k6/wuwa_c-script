using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E6F RID: 7791
	[NullableContext(1)]
	[Nullable(0)]
	public class ISignalDevice2 : IUiGame
	{
		// Token: 0x0600A6C0 RID: 42688 RVA: 0x001793E8 File Offset: 0x001775E8
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

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x00179420 File Offset: 0x00177620
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

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x00179433 File Offset: 0x00177633
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

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x00179446 File Offset: 0x00177646
		public new ISignalDevice2_SetValue ToSetValue()
		{
			return new ISignalDevice2_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600A6C4 RID: 42692 RVA: 0x00179465 File Offset: 0x00177665
		// (set) Token: 0x0600A6C5 RID: 42693 RVA: 0x00179490 File Offset: 0x00177690
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

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600A6C6 RID: 42694 RVA: 0x001794A0 File Offset: 0x001776A0
		// (set) Token: 0x0600A6C7 RID: 42695 RVA: 0x00179533 File Offset: 0x00177733
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

		// Token: 0x04006394 RID: 25492
		[Nullable(2)]
		protected new ISignalDevice2 FbInstance;

		// Token: 0x04006395 RID: 25493
		[Nullable(2)]
		protected new ISignalDevice2_SetValue PocoInterface;

		// Token: 0x04006396 RID: 25494
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04006397 RID: 25495
		private bool _ConfigInited;
	}
}
