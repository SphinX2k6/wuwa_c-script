using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DB RID: 4315
	[NullableContext(2)]
	[Nullable(0)]
	public class IHandInItems
	{
		// Token: 0x06005F58 RID: 24408 RVA: 0x000E6AEC File Offset: 0x000E4CEC
		[NullableContext(0)]
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

		// Token: 0x06005F59 RID: 24409 RVA: 0x000E6B24 File Offset: 0x000E4D24
		[NullableContext(0)]
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

		// Token: 0x06005F5A RID: 24410 RVA: 0x000E6B37 File Offset: 0x000E4D37
		[NullableContext(0)]
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

		// Token: 0x06005F5B RID: 24411 RVA: 0x000E6B4C File Offset: 0x000E4D4C
		[NullableContext(0)]
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

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06005F5C RID: 24412 RVA: 0x000E6BB4 File Offset: 0x000E4DB4
		// (set) Token: 0x06005F5D RID: 24413 RVA: 0x000E6C47 File Offset: 0x000E4E47
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Items = value;
				this._ItemsInited = false;
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x000E6C5C File Offset: 0x000E4E5C
		// (set) Token: 0x06005F5F RID: 24415 RVA: 0x000E6CBD File Offset: 0x000E4EBD
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

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06005F60 RID: 24416 RVA: 0x000E6CD2 File Offset: 0x000E4ED2
		// (set) Token: 0x06005F61 RID: 24417 RVA: 0x000E6CF9 File Offset: 0x000E4EF9
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

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06005F62 RID: 24418 RVA: 0x000E6D07 File Offset: 0x000E4F07
		// (set) Token: 0x06005F63 RID: 24419 RVA: 0x000E6D32 File Offset: 0x000E4F32
		[Nullable(0)]
		public virtual string TidDescText
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().TidDescText = value;
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06005F64 RID: 24420 RVA: 0x000E6D40 File Offset: 0x000E4F40
		// (set) Token: 0x06005F65 RID: 24421 RVA: 0x000E6D6B File Offset: 0x000E4F6B
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

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x000E6D79 File Offset: 0x000E4F79
		// (set) Token: 0x06005F67 RID: 24423 RVA: 0x000E6D90 File Offset: 0x000E4F90
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

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06005F68 RID: 24424 RVA: 0x000E6D9E File Offset: 0x000E4F9E
		// (set) Token: 0x06005F69 RID: 24425 RVA: 0x000E6DB5 File Offset: 0x000E4FB5
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

		// Token: 0x04003934 RID: 14644
		protected IHandInItems FbInstance;

		// Token: 0x04003935 RID: 14645
		protected IHandInItems_SetValue PocoInterface;

		// Token: 0x04003936 RID: 14646
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IHandInItem> _ItemsCache;

		// Token: 0x04003937 RID: 14647
		private bool _ItemsInited;

		// Token: 0x04003938 RID: 14648
		[Nullable(0)]
		private IHandInGroup _GroupConfigCache;

		// Token: 0x04003939 RID: 14649
		private bool _GroupConfigInited;
	}
}
