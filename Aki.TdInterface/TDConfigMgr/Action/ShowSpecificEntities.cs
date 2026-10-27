using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002206 RID: 8710
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowSpecificEntities : ActionParams
	{
		// Token: 0x0600BF43 RID: 48963 RVA: 0x001B7D00 File Offset: 0x001B5F00
		private ShowSpecificEntities_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ShowSpecificEntities 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ShowSpecificEntities_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ShowSpecificEntities_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x001B7D38 File Offset: 0x001B5F38
		public static ShowSpecificEntities Create([Nullable(2)] ShowSpecificEntities instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowSpecificEntities
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x001B7D4B File Offset: 0x001B5F4B
		public static ShowSpecificEntities CreateFromSetValue([Nullable(2)] ShowSpecificEntities_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ShowSpecificEntities
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x001B7D5E File Offset: 0x001B5F5E
		public ShowSpecificEntities_SetValue ToSetValue()
		{
			return new ShowSpecificEntities_SetValue
			{
				EntityIds = this.EntityIds,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x001B7D7D File Offset: 0x001B5F7D
		// (set) Token: 0x0600BF48 RID: 48968 RVA: 0x001B7DA4 File Offset: 0x001B5FA4
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				ShowSpecificEntities_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0600BF49 RID: 48969 RVA: 0x001B7DB2 File Offset: 0x001B5FB2
		// (set) Token: 0x0600BF4A RID: 48970 RVA: 0x001B7DDD File Offset: 0x001B5FDD
		public virtual bool DelayShow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayShow;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayShow;
			}
			set
			{
				this.GetOrCreatePoco().DelayShow = value;
			}
		}

		// Token: 0x04007201 RID: 29185
		[Nullable(2)]
		protected new ShowSpecificEntities FbInstance;

		// Token: 0x04007202 RID: 29186
		[Nullable(2)]
		protected ShowSpecificEntities_SetValue PocoInterface;
	}
}
