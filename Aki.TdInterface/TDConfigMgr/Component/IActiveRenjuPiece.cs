using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001BA RID: 442
	public class IActiveRenjuPiece : IJigsawCompleteCondition
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x00023934 File Offset: 0x00021B34
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

		// Token: 0x06000679 RID: 1657 RVA: 0x0002396C File Offset: 0x00021B6C
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

		// Token: 0x0600067A RID: 1658 RVA: 0x0002397F File Offset: 0x00021B7F
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

		// Token: 0x0600067B RID: 1659 RVA: 0x00023992 File Offset: 0x00021B92
		public new IActiveRenjuPiece_SetValue ToSetValue()
		{
			return new IActiveRenjuPiece_SetValue
			{
				Type = this.Type,
				RenjuConfig = this.RenjuConfig,
				ExitMatchedConfig = this.ExitMatchedConfig
			};
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x000239BD File Offset: 0x00021BBD
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x000239E8 File Offset: 0x00021BE8
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000239F8 File Offset: 0x00021BF8
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00023A8B File Offset: 0x00021C8B
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00023AA0 File Offset: 0x00021CA0
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00023B33 File Offset: 0x00021D33
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IJigsawItemMatchedConfig> ExitMatchedConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().ExitMatchedConfig = value;
				this._ExitMatchedConfigInited = false;
			}
		}

		// Token: 0x04000865 RID: 2149
		[Nullable(2)]
		protected new IActiveRenjuPiece FbInstance;

		// Token: 0x04000866 RID: 2150
		[Nullable(2)]
		protected new IActiveRenjuPiece_SetValue PocoInterface;

		// Token: 0x04000867 RID: 2151
		private List<IRenjuConfig> _RenjuConfigCache;

		// Token: 0x04000868 RID: 2152
		private bool _RenjuConfigInited;

		// Token: 0x04000869 RID: 2153
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IJigsawItemMatchedConfig> _ExitMatchedConfigCache;

		// Token: 0x0400086A RID: 2154
		private bool _ExitMatchedConfigInited;
	}
}
