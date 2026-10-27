using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7C RID: 7036
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifePointColorBoard
	{
		// Token: 0x060096AF RID: 38575 RVA: 0x0015BF58 File Offset: 0x0015A158
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

		// Token: 0x060096B0 RID: 38576 RVA: 0x0015BF90 File Offset: 0x0015A190
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

		// Token: 0x060096B1 RID: 38577 RVA: 0x0015BFA3 File Offset: 0x0015A1A3
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

		// Token: 0x060096B2 RID: 38578 RVA: 0x0015BFB6 File Offset: 0x0015A1B6
		public ILifePointColorBoard_SetValue ToSetValue()
		{
			return new ILifePointColorBoard_SetValue
			{
				Config = this.Config,
				Colors = this.Colors,
				TargetColor = this.TargetColor
			};
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x060096B3 RID: 38579 RVA: 0x0015BFE4 File Offset: 0x0015A1E4
		// (set) Token: 0x060096B4 RID: 38580 RVA: 0x0015C077 File Offset: 0x0015A277
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

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x060096B5 RID: 38581 RVA: 0x0015C08C File Offset: 0x0015A28C
		// (set) Token: 0x060096B6 RID: 38582 RVA: 0x0015C0B3 File Offset: 0x0015A2B3
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

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x060096B7 RID: 38583 RVA: 0x0015C0C1 File Offset: 0x0015A2C1
		// (set) Token: 0x060096B8 RID: 38584 RVA: 0x0015C0EC File Offset: 0x0015A2EC
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

		// Token: 0x04005C19 RID: 23577
		[Nullable(2)]
		protected ILifePointColorBoard FbInstance;

		// Token: 0x04005C1A RID: 23578
		[Nullable(2)]
		protected ILifePointColorBoard_SetValue PocoInterface;

		// Token: 0x04005C1B RID: 23579
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04005C1C RID: 23580
		private bool _ConfigInited;
	}
}
