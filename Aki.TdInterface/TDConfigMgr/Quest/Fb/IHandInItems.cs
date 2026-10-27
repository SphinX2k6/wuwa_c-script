using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001377 RID: 4983
	[NullableContext(2)]
	[Nullable(0)]
	public class IHandInItems
	{
		// Token: 0x06007209 RID: 29193 RVA: 0x00112986 File Offset: 0x00110B86
		[NullableContext(1)]
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

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x0600720A RID: 29194 RVA: 0x001129A8 File Offset: 0x00110BA8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IHandInItem> Items
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x0600720B RID: 29195 RVA: 0x00112A22 File Offset: 0x00110C22
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

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x0600720C RID: 29196 RVA: 0x00112A56 File Offset: 0x00110C56
		public virtual string TidTitleText
		{
			get
			{
				return this.Instance.TidTitleText;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x0600720D RID: 29197 RVA: 0x00112A63 File Offset: 0x00110C63
		[Nullable(1)]
		public virtual string TidDescText
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.TidDescText;
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x0600720E RID: 29198 RVA: 0x00112A70 File Offset: 0x00110C70
		public virtual bool RepeatItems
		{
			get
			{
				return this.Instance.RepeatItems;
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x0600720F RID: 29199 RVA: 0x00112A7D File Offset: 0x00110C7D
		public virtual string EdTidTitleText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06007210 RID: 29200 RVA: 0x00112A80 File Offset: 0x00110C80
		public virtual string EdTidDescText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040041E9 RID: 16873
		private IHandInItems Instance;

		// Token: 0x040041EA RID: 16874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHandInItem> _ItemsCache;

		// Token: 0x040041EB RID: 16875
		private bool _ItemsInited;

		// Token: 0x040041EC RID: 16876
		private IHandInGroup _GroupConfigCache;

		// Token: 0x040041ED RID: 16877
		private bool _GroupConfigInited;
	}
}
