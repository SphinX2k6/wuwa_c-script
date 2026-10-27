using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F5F RID: 3935
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityRefSearchProp
	{
		// Token: 0x06005774 RID: 22388 RVA: 0x000D5D34 File Offset: 0x000D3F34
		private IEntityRefSearchProp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityRefSearchProp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityRefSearchProp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityRefSearchProp_SetValue());
			}
			return result;
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x000D5D6C File Offset: 0x000D3F6C
		public static IEntityRefSearchProp Create([Nullable(2)] IEntityRefSearchProp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityRefSearchProp
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x000D5D7F File Offset: 0x000D3F7F
		public static IEntityRefSearchProp CreateFromSetValue([Nullable(2)] IEntityRefSearchProp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityRefSearchProp
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x000D5D92 File Offset: 0x000D3F92
		public IEntityRefSearchProp_SetValue ToSetValue()
		{
			return new IEntityRefSearchProp_SetValue
			{
				SearchText = this.SearchText,
				ResultCount = this.ResultCount,
				ResultIndex = this.ResultIndex
			};
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x000D5DBD File Offset: 0x000D3FBD
		// (set) Token: 0x06005779 RID: 22393 RVA: 0x000D5DE8 File Offset: 0x000D3FE8
		public virtual string SearchText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SearchText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SearchText;
			}
			set
			{
				this.GetOrCreatePoco().SearchText = value;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x000D5DF8 File Offset: 0x000D3FF8
		// (set) Token: 0x0600577B RID: 22395 RVA: 0x000D5E32 File Offset: 0x000D4032
		public virtual int? ResultCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResultCount;
				}
				IEntityRefSearchProp_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResultCount;
			}
			set
			{
				this.GetOrCreatePoco().ResultCount = value;
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x000D5E40 File Offset: 0x000D4040
		// (set) Token: 0x0600577D RID: 22397 RVA: 0x000D5E7A File Offset: 0x000D407A
		public virtual int? ResultIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResultIndex;
				}
				IEntityRefSearchProp_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResultIndex;
			}
			set
			{
				this.GetOrCreatePoco().ResultIndex = value;
			}
		}

		// Token: 0x040034E4 RID: 13540
		[Nullable(2)]
		protected IEntityRefSearchProp FbInstance;

		// Token: 0x040034E5 RID: 13541
		[Nullable(2)]
		protected IEntityRefSearchProp_SetValue PocoInterface;
	}
}
