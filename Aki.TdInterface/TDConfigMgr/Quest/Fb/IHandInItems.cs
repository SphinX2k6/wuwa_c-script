using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014C8 RID: 5320
	[NullableContext(2)]
	[Nullable(0)]
	public class IHandInItems
	{
		// Token: 0x060078AF RID: 30895 RVA: 0x0012100A File Offset: 0x0011F20A
		[NullableContext(0)]
		public static IHandInItems Create(IHandInItems? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItems
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x060078B0 RID: 30896 RVA: 0x0012102C File Offset: 0x0011F22C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IHandInItem> Items
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<IHandInItem>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(IHandInItem.Create(this.Instance.Items(i)));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x001210A6 File Offset: 0x0011F2A6
		public virtual IHandInGroup GroupConfig
		{
			get
			{
				if (this._GroupConfigInited)
				{
					return this._GroupConfigCache;
				}
				this._GroupConfigInited = true;
				this._GroupConfigCache = IHandInGroup.Create(this.Instance.GroupConfig);
				return this._GroupConfigCache;
			}
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x060078B2 RID: 30898 RVA: 0x001210DA File Offset: 0x0011F2DA
		public virtual string TidTitleText
		{
			get
			{
				return this.Instance.TidTitleText;
			}
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x001210E7 File Offset: 0x0011F2E7
		[Nullable(0)]
		public virtual string TidDescText
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.TidDescText;
			}
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x001210F4 File Offset: 0x0011F2F4
		public virtual bool RepeatItems
		{
			get
			{
				return this.Instance.RepeatItems;
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x060078B5 RID: 30901 RVA: 0x00121101 File Offset: 0x0011F301
		public virtual string EdTidTitleText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x060078B6 RID: 30902 RVA: 0x00121104 File Offset: 0x0011F304
		public virtual string EdTidDescText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400456A RID: 17770
		private IHandInItems Instance;

		// Token: 0x0400456B RID: 17771
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHandInItem> _ItemsCache;

		// Token: 0x0400456C RID: 17772
		private bool _ItemsInited;

		// Token: 0x0400456D RID: 17773
		private IHandInGroup _GroupConfigCache;

		// Token: 0x0400456E RID: 17774
		private bool _GroupConfigInited;
	}
}
