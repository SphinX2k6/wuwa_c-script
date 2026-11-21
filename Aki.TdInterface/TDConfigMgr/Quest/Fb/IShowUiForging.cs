using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F8 RID: 5368
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiForging : IShowUiCrafting
	{
		// Token: 0x06007998 RID: 31128 RVA: 0x00122905 File Offset: 0x00120B05
		[NullableContext(0)]
		public static IShowUiForging Create(IShowUiForging? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiForging
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x00122924 File Offset: 0x00120B24
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x00122934 File Offset: 0x00120B34
		public override List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x0600799B RID: 31131 RVA: 0x001229AC File Offset: 0x00120BAC
		public override List<int> ProductIds
		{
			get
			{
				if (this._ProductIdsInited)
				{
					return this._ProductIdsCache;
				}
				this._ProductIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int productIdsLength = this.Instance.ProductIdsLength;
				this._ProductIdsCache = new List<int>(productIdsLength);
				for (int i = 0; i < productIdsLength; i++)
				{
					this._ProductIdsCache.Add(this.Instance.ProductIds(i));
				}
				return this._ProductIdsCache;
			}
		}

		// Token: 0x040045F4 RID: 17908
		private IShowUiForging Instance;

		// Token: 0x040045F5 RID: 17909
		private List<int> _EntityIdsCache;

		// Token: 0x040045F6 RID: 17910
		private bool _EntityIdsInited;

		// Token: 0x040045F7 RID: 17911
		private List<int> _ProductIdsCache;

		// Token: 0x040045F8 RID: 17912
		private bool _ProductIdsInited;
	}
}
