using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002471 RID: 9329
	public class ShowSpecificEntities : ActionParams
	{
		// Token: 0x0600CAFF RID: 51967 RVA: 0x001CF38C File Offset: 0x001CD58C
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

		// Token: 0x0600CB00 RID: 51968 RVA: 0x001CF3C4 File Offset: 0x001CD5C4
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

		// Token: 0x0600CB01 RID: 51969 RVA: 0x001CF3D7 File Offset: 0x001CD5D7
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

		// Token: 0x0600CB02 RID: 51970 RVA: 0x001CF3EA File Offset: 0x001CD5EA
		public ShowSpecificEntities_SetValue ToSetValue()
		{
			return new ShowSpecificEntities_SetValue
			{
				EntityIds = this.EntityIds,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600CB03 RID: 51971 RVA: 0x001CF409 File Offset: 0x001CD609
		// (set) Token: 0x0600CB04 RID: 51972 RVA: 0x001CF430 File Offset: 0x001CD630
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

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0600CB05 RID: 51973 RVA: 0x001CF43E File Offset: 0x001CD63E
		// (set) Token: 0x0600CB06 RID: 51974 RVA: 0x001CF469 File Offset: 0x001CD669
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

		// Token: 0x0400784A RID: 30794
		[Nullable(2)]
		protected new ShowSpecificEntities FbInstance;

		// Token: 0x0400784B RID: 30795
		[Nullable(2)]
		protected ShowSpecificEntities_SetValue PocoInterface;
	}
}
