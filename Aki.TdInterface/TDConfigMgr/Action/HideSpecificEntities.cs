using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001744 RID: 5956
	[NullableContext(1)]
	[Nullable(0)]
	public class HideSpecificEntities : ActionParams
	{
		// Token: 0x06007E0F RID: 32271 RVA: 0x0012E0B8 File Offset: 0x0012C2B8
		private HideSpecificEntities_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HideSpecificEntities 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HideSpecificEntities_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HideSpecificEntities_SetValue());
			}
			return result;
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x0012E0F0 File Offset: 0x0012C2F0
		public static HideSpecificEntities Create([Nullable(2)] HideSpecificEntities instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideSpecificEntities
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x0012E103 File Offset: 0x0012C303
		public static HideSpecificEntities CreateFromSetValue([Nullable(2)] HideSpecificEntities_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HideSpecificEntities
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x0012E116 File Offset: 0x0012C316
		public HideSpecificEntities_SetValue ToSetValue()
		{
			return new HideSpecificEntities_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x06007E13 RID: 32275 RVA: 0x0012E129 File Offset: 0x0012C329
		// (set) Token: 0x06007E14 RID: 32276 RVA: 0x0012E150 File Offset: 0x0012C350
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				HideSpecificEntities_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005058 RID: 20568
		[Nullable(2)]
		protected new HideSpecificEntities FbInstance;

		// Token: 0x04005059 RID: 20569
		[Nullable(2)]
		protected HideSpecificEntities_SetValue PocoInterface;
	}
}
