using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200019F RID: 415
	[NullableContext(1)]
	[Nullable(0)]
	public class IActivateSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x00022A24 File Offset: 0x00020C24
		private IActivateSpecifiedPiece_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActivateSpecifiedPiece 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActivateSpecifiedPiece_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActivateSpecifiedPiece_SetValue());
			}
			return result;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00022A5C File Offset: 0x00020C5C
		public static IActivateSpecifiedPiece Create([Nullable(2)] IActivateSpecifiedPiece instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActivateSpecifiedPiece
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00022A6F File Offset: 0x00020C6F
		public static IActivateSpecifiedPiece CreateFromSetValue([Nullable(2)] IActivateSpecifiedPiece_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActivateSpecifiedPiece
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00022A82 File Offset: 0x00020C82
		public new IActivateSpecifiedPiece_SetValue ToSetValue()
		{
			return new IActivateSpecifiedPiece_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00022AA1 File Offset: 0x00020CA1
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00022ACC File Offset: 0x00020CCC
		public override EJigsawCompleteCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00022ADC File Offset: 0x00020CDC
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00022B6F File Offset: 0x00020D6F
		public virtual List<IActivateSpecifiedPieceConfig> Config
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
					List<IActivateSpecifiedPieceConfig> config = this.FbInstance.Config;
					if (config != null)
					{
						this._ConfigCache = new List<IActivateSpecifiedPieceConfig>(config.Count);
						for (int i = 0; i < config.Count; i++)
						{
							this._ConfigCache.Add(IActivateSpecifiedPieceConfig.Create(config[i]));
						}
					}
				}
				else
				{
					IActivateSpecifiedPiece_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000800 RID: 2048
		[Nullable(2)]
		protected new IActivateSpecifiedPiece FbInstance;

		// Token: 0x04000801 RID: 2049
		[Nullable(2)]
		protected new IActivateSpecifiedPiece_SetValue PocoInterface;

		// Token: 0x04000802 RID: 2050
		private List<IActivateSpecifiedPieceConfig> _ConfigCache;

		// Token: 0x04000803 RID: 2051
		private bool _ConfigInited;
	}
}
