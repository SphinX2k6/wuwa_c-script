using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A3 RID: 419
	[NullableContext(1)]
	[Nullable(0)]
	public class IActiveRenjuPiece : IJigsawCompleteCondition
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x00022CD4 File Offset: 0x00020ED4
		private IActiveRenjuPiece_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActiveRenjuPiece 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActiveRenjuPiece_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActiveRenjuPiece_SetValue());
			}
			return result;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00022D0C File Offset: 0x00020F0C
		public static IActiveRenjuPiece Create([Nullable(2)] IActiveRenjuPiece instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActiveRenjuPiece
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00022D1F File Offset: 0x00020F1F
		public static IActiveRenjuPiece CreateFromSetValue([Nullable(2)] IActiveRenjuPiece_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActiveRenjuPiece
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00022D32 File Offset: 0x00020F32
		public new IActiveRenjuPiece_SetValue ToSetValue()
		{
			return new IActiveRenjuPiece_SetValue
			{
				Type = this.Type,
				RenjuConfig = this.RenjuConfig,
				ExitMatchedConfig = this.ExitMatchedConfig
			};
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00022D5D File Offset: 0x00020F5D
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00022D88 File Offset: 0x00020F88
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

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00022D98 File Offset: 0x00020F98
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00022E2B File Offset: 0x0002102B
		public virtual List<IRenjuConfig> RenjuConfig
		{
			get
			{
				if (this._RenjuConfigInited)
				{
					return this._RenjuConfigCache;
				}
				this._RenjuConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IRenjuConfig> renjuConfig = this.FbInstance.RenjuConfig;
					if (renjuConfig != null)
					{
						this._RenjuConfigCache = new List<IRenjuConfig>(renjuConfig.Count);
						for (int i = 0; i < renjuConfig.Count; i++)
						{
							this._RenjuConfigCache.Add(IRenjuConfig.Create(renjuConfig[i]));
						}
					}
				}
				else
				{
					IActiveRenjuPiece_SetValue pocoInterface = this.PocoInterface;
					this._RenjuConfigCache = ((pocoInterface != null) ? pocoInterface.RenjuConfig : null);
				}
				return this._RenjuConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RenjuConfig = value;
				this._RenjuConfigInited = false;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00022E40 File Offset: 0x00021040
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00022ED3 File Offset: 0x000210D3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IJigsawItemMatchedConfig> ExitMatchedConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ExitMatchedConfigInited)
				{
					return this._ExitMatchedConfigCache;
				}
				this._ExitMatchedConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IJigsawItemMatchedConfig> exitMatchedConfig = this.FbInstance.ExitMatchedConfig;
					if (exitMatchedConfig != null)
					{
						this._ExitMatchedConfigCache = new List<IJigsawItemMatchedConfig>(exitMatchedConfig.Count);
						for (int i = 0; i < exitMatchedConfig.Count; i++)
						{
							this._ExitMatchedConfigCache.Add(IJigsawItemMatchedConfig.Create(exitMatchedConfig[i]));
						}
					}
				}
				else
				{
					IActiveRenjuPiece_SetValue pocoInterface = this.PocoInterface;
					this._ExitMatchedConfigCache = ((pocoInterface != null) ? pocoInterface.ExitMatchedConfig : null);
				}
				return this._ExitMatchedConfigCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().ExitMatchedConfig = value;
				this._ExitMatchedConfigInited = false;
			}
		}

		// Token: 0x0400080C RID: 2060
		[Nullable(2)]
		protected new IActiveRenjuPiece FbInstance;

		// Token: 0x0400080D RID: 2061
		[Nullable(2)]
		protected new IActiveRenjuPiece_SetValue PocoInterface;

		// Token: 0x0400080E RID: 2062
		private List<IRenjuConfig> _RenjuConfigCache;

		// Token: 0x0400080F RID: 2063
		private bool _RenjuConfigInited;

		// Token: 0x04000810 RID: 2064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IJigsawItemMatchedConfig> _ExitMatchedConfigCache;

		// Token: 0x04000811 RID: 2065
		private bool _ExitMatchedConfigInited;
	}
}
