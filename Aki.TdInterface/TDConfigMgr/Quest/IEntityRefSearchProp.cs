using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001089 RID: 4233
	public class IEntityRefSearchProp
	{
		// Token: 0x06005D48 RID: 23880 RVA: 0x000E27A0 File Offset: 0x000E09A0
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

		// Token: 0x06005D49 RID: 23881 RVA: 0x000E27D8 File Offset: 0x000E09D8
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

		// Token: 0x06005D4A RID: 23882 RVA: 0x000E27EB File Offset: 0x000E09EB
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

		// Token: 0x06005D4B RID: 23883 RVA: 0x000E27FE File Offset: 0x000E09FE
		public IEntityRefSearchProp_SetValue ToSetValue()
		{
			return new IEntityRefSearchProp_SetValue
			{
				SearchText = this.SearchText,
				ResultCount = this.ResultCount,
				ResultIndex = this.ResultIndex
			};
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06005D4C RID: 23884 RVA: 0x000E2829 File Offset: 0x000E0A29
		// (set) Token: 0x06005D4D RID: 23885 RVA: 0x000E2854 File Offset: 0x000E0A54
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

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06005D4E RID: 23886 RVA: 0x000E2864 File Offset: 0x000E0A64
		// (set) Token: 0x06005D4F RID: 23887 RVA: 0x000E289E File Offset: 0x000E0A9E
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

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06005D50 RID: 23888 RVA: 0x000E28AC File Offset: 0x000E0AAC
		// (set) Token: 0x06005D51 RID: 23889 RVA: 0x000E28E6 File Offset: 0x000E0AE6
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

		// Token: 0x04003815 RID: 14357
		[Nullable(2)]
		protected IEntityRefSearchProp FbInstance;

		// Token: 0x04003816 RID: 14358
		[Nullable(2)]
		protected IEntityRefSearchProp_SetValue PocoInterface;
	}
}
