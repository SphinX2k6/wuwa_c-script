using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D73 RID: 3443
	public class IActiveRenjuPiece : IJigsawCompleteCondition
	{
		// Token: 0x06004E41 RID: 20033 RVA: 0x000C2F7A File Offset: 0x000C117A
		public static IActiveRenjuPiece Create(IActiveRenjuPiece? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActiveRenjuPiece
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x000C2F99 File Offset: 0x000C1199
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06004E43 RID: 20035 RVA: 0x000C2FA8 File Offset: 0x000C11A8
		public virtual List<IRenjuConfig> RenjuConfig
		{
			get
			{
				if (this._RenjuConfigInited)
				{
					return this._RenjuConfigCache;
				}
				this._RenjuConfigInited = true;
				int renjuConfigLength = this.Instance.RenjuConfigLength;
				this._RenjuConfigCache = new List<IRenjuConfig>(renjuConfigLength);
				for (int i = 0; i < renjuConfigLength; i++)
				{
					this._RenjuConfigCache.Add(IRenjuConfig.Create(this.Instance.RenjuConfig(i)));
				}
				return this._RenjuConfigCache;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06004E44 RID: 20036 RVA: 0x000C3014 File Offset: 0x000C1214
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int exitMatchedConfigLength = this.Instance.ExitMatchedConfigLength;
				this._ExitMatchedConfigCache = new List<IJigsawItemMatchedConfig>(exitMatchedConfigLength);
				for (int i = 0; i < exitMatchedConfigLength; i++)
				{
					this._ExitMatchedConfigCache.Add(IJigsawItemMatchedConfig.Create(this.Instance.ExitMatchedConfig(i)));
				}
				return this._ExitMatchedConfigCache;
			}
		}

		// Token: 0x04002C70 RID: 11376
		private IActiveRenjuPiece Instance;

		// Token: 0x04002C71 RID: 11377
		private List<IRenjuConfig> _RenjuConfigCache;

		// Token: 0x04002C72 RID: 11378
		private bool _RenjuConfigInited;

		// Token: 0x04002C73 RID: 11379
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IJigsawItemMatchedConfig> _ExitMatchedConfigCache;

		// Token: 0x04002C74 RID: 11380
		private bool _ExitMatchedConfigInited;
	}
}
