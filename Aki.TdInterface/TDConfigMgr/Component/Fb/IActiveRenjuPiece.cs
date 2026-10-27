using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C91 RID: 3217
	[NullableContext(1)]
	[Nullable(0)]
	public class IActiveRenjuPiece : IJigsawCompleteCondition
	{
		// Token: 0x06004993 RID: 18835 RVA: 0x000B856A File Offset: 0x000B676A
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

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x000B8589 File Offset: 0x000B6789
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x000B8598 File Offset: 0x000B6798
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

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06004996 RID: 18838 RVA: 0x000B8604 File Offset: 0x000B6804
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

		// Token: 0x040029F6 RID: 10742
		private IActiveRenjuPiece Instance;

		// Token: 0x040029F7 RID: 10743
		private List<IRenjuConfig> _RenjuConfigCache;

		// Token: 0x040029F8 RID: 10744
		private bool _RenjuConfigInited;

		// Token: 0x040029F9 RID: 10745
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IJigsawItemMatchedConfig> _ExitMatchedConfigCache;

		// Token: 0x040029FA RID: 10746
		private bool _ExitMatchedConfigInited;
	}
}
