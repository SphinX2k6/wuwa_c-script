using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FB1 RID: 4017
	[NullableContext(2)]
	[Nullable(0)]
	public class IHandInItems
	{
		// Token: 0x06005982 RID: 22914 RVA: 0x000DA02C File Offset: 0x000D822C
		[NullableContext(1)]
		private IHandInItems_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInItems 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInItems_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInItems_SetValue());
			}
			return result;
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x000DA064 File Offset: 0x000D8264
		[NullableContext(1)]
		public static IHandInItems Create([Nullable(2)] IHandInItems instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItems
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x000DA077 File Offset: 0x000D8277
		[NullableContext(1)]
		public static IHandInItems CreateFromSetValue([Nullable(2)] IHandInItems_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInItems
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x000DA08C File Offset: 0x000D828C
		[NullableContext(1)]
		public IHandInItems_SetValue ToSetValue()
		{
			return new IHandInItems_SetValue
			{
				Items = this.Items,
				GroupConfig = this.GroupConfig,
				TidTitleText = this.TidTitleText,
				TidDescText = this.TidDescText,
				RepeatItems = this.RepeatItems,
				EdTidTitleText = this.EdTidTitleText,
				EdTidDescText = this.EdTidDescText
			};
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06005986 RID: 22918 RVA: 0x000DA0F4 File Offset: 0x000D82F4
		// (set) Token: 0x06005987 RID: 22919 RVA: 0x000DA187 File Offset: 0x000D8387
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
				if (this.FbInstance != null)
				{
					List<IHandInItem> items = this.FbInstance.Items;
					if (items != null)
					{
						this._ItemsCache = new List<IHandInItem>(items.Count);
						for (int i = 0; i < items.Count; i++)
						{
							this._ItemsCache.Add(IHandInItem.Create(items[i]));
						}
					}
				}
				else
				{
					IHandInItems_SetValue pocoInterface = this.PocoInterface;
					this._ItemsCache = ((pocoInterface != null) ? pocoInterface.Items : null);
				}
				return this._ItemsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Items = value;
				this._ItemsInited = false;
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x000DA19C File Offset: 0x000D839C
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x000DA1FD File Offset: 0x000D83FD
		public virtual IHandInGroup GroupConfig
		{
			get
			{
				if (this._GroupConfigInited)
				{
					return this._GroupConfigCache;
				}
				this._GroupConfigInited = true;
				if (this.FbInstance != null)
				{
					this._GroupConfigCache = IHandInGroup.Create(this.FbInstance.GroupConfig);
				}
				else
				{
					IHandInItems_SetValue pocoInterface = this.PocoInterface;
					this._GroupConfigCache = ((pocoInterface != null) ? pocoInterface.GroupConfig : null);
				}
				return this._GroupConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().GroupConfig = value;
				this._GroupConfigInited = false;
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x0600598A RID: 22922 RVA: 0x000DA212 File Offset: 0x000D8412
		// (set) Token: 0x0600598B RID: 22923 RVA: 0x000DA239 File Offset: 0x000D8439
		public virtual string TidTitleText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTitleText;
				}
				IHandInItems_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTitleText;
			}
			set
			{
				this.GetOrCreatePoco().TidTitleText = value;
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x0600598C RID: 22924 RVA: 0x000DA247 File Offset: 0x000D8447
		// (set) Token: 0x0600598D RID: 22925 RVA: 0x000DA272 File Offset: 0x000D8472
		[Nullable(1)]
		public virtual string TidDescText
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDescText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDescText;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().TidDescText = value;
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x0600598E RID: 22926 RVA: 0x000DA280 File Offset: 0x000D8480
		// (set) Token: 0x0600598F RID: 22927 RVA: 0x000DA2AB File Offset: 0x000D84AB
		public virtual bool RepeatItems
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatItems;
				}
				return this.PocoInterface != null && this.PocoInterface.RepeatItems;
			}
			set
			{
				this.GetOrCreatePoco().RepeatItems = value;
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06005990 RID: 22928 RVA: 0x000DA2B9 File Offset: 0x000D84B9
		// (set) Token: 0x06005991 RID: 22929 RVA: 0x000DA2D0 File Offset: 0x000D84D0
		public virtual string EdTidTitleText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTitleText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTitleText = value;
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06005992 RID: 22930 RVA: 0x000DA2DE File Offset: 0x000D84DE
		// (set) Token: 0x06005993 RID: 22931 RVA: 0x000DA2F5 File Offset: 0x000D84F5
		public virtual string EdTidDescText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDescText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidDescText = value;
			}
		}

		// Token: 0x04003602 RID: 13826
		protected IHandInItems FbInstance;

		// Token: 0x04003603 RID: 13827
		protected IHandInItems_SetValue PocoInterface;

		// Token: 0x04003604 RID: 13828
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHandInItem> _ItemsCache;

		// Token: 0x04003605 RID: 13829
		private bool _ItemsInited;

		// Token: 0x04003606 RID: 13830
		[Nullable(1)]
		private IHandInGroup _GroupConfigCache;

		// Token: 0x04003607 RID: 13831
		private bool _GroupConfigInited;
	}
}
