using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001B6 RID: 438
	public class IActivateSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x00023684 File Offset: 0x00021884
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

		// Token: 0x06000665 RID: 1637 RVA: 0x000236BC File Offset: 0x000218BC
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

		// Token: 0x06000666 RID: 1638 RVA: 0x000236CF File Offset: 0x000218CF
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

		// Token: 0x06000667 RID: 1639 RVA: 0x000236E2 File Offset: 0x000218E2
		public new IActivateSpecifiedPiece_SetValue ToSetValue()
		{
			return new IActivateSpecifiedPiece_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00023701 File Offset: 0x00021901
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x0002372C File Offset: 0x0002192C
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002373C File Offset: 0x0002193C
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x000237CF File Offset: 0x000219CF
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

		// Token: 0x04000859 RID: 2137
		[Nullable(2)]
		protected new IActivateSpecifiedPiece FbInstance;

		// Token: 0x0400085A RID: 2138
		[Nullable(2)]
		protected new IActivateSpecifiedPiece_SetValue PocoInterface;

		// Token: 0x0400085B RID: 2139
		private List<IActivateSpecifiedPieceConfig> _ConfigCache;

		// Token: 0x0400085C RID: 2140
		private bool _ConfigInited;
	}
}
