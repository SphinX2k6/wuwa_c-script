using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D29 RID: 7465
	public class ILifePointColorBoard
	{
		// Token: 0x06009E91 RID: 40593 RVA: 0x0016CB04 File Offset: 0x0016AD04
		private ILifePointColorBoard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILifePointColorBoard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILifePointColorBoard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILifePointColorBoard_SetValue());
			}
			return result;
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x0016CB3C File Offset: 0x0016AD3C
		public static ILifePointColorBoard Create([Nullable(2)] ILifePointColorBoard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifePointColorBoard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x0016CB4F File Offset: 0x0016AD4F
		public static ILifePointColorBoard CreateFromSetValue([Nullable(2)] ILifePointColorBoard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILifePointColorBoard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x0016CB62 File Offset: 0x0016AD62
		public ILifePointColorBoard_SetValue ToSetValue()
		{
			return new ILifePointColorBoard_SetValue
			{
				Config = this.Config,
				Colors = this.Colors,
				TargetColor = this.TargetColor
			};
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x06009E95 RID: 40597 RVA: 0x0016CB90 File Offset: 0x0016AD90
		// (set) Token: 0x06009E96 RID: 40598 RVA: 0x0016CC23 File Offset: 0x0016AE23
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
					ILifePointColorBoard_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x06009E97 RID: 40599 RVA: 0x0016CC38 File Offset: 0x0016AE38
		// (set) Token: 0x06009E98 RID: 40600 RVA: 0x0016CC5F File Offset: 0x0016AE5F
		public virtual List<EPieceColorType> Colors
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Colors;
				}
				ILifePointColorBoard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Colors;
			}
			set
			{
				this.GetOrCreatePoco().Colors = value;
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x06009E99 RID: 40601 RVA: 0x0016CC6D File Offset: 0x0016AE6D
		// (set) Token: 0x06009E9A RID: 40602 RVA: 0x0016CC98 File Offset: 0x0016AE98
		public virtual EPieceColorType TargetColor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetColor;
				}
				if (this.PocoInterface == null)
				{
					return EPieceColorType.White;
				}
				return this.PocoInterface.TargetColor;
			}
			set
			{
				this.GetOrCreatePoco().TargetColor = value;
			}
		}

		// Token: 0x040060B2 RID: 24754
		[Nullable(2)]
		protected ILifePointColorBoard FbInstance;

		// Token: 0x040060B3 RID: 24755
		[Nullable(2)]
		protected ILifePointColorBoard_SetValue PocoInterface;

		// Token: 0x040060B4 RID: 24756
		private List<IColorPiece> _ConfigCache;

		// Token: 0x040060B5 RID: 24757
		private bool _ConfigInited;
	}
}
