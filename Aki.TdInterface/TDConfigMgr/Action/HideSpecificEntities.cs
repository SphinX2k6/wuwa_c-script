using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C5 RID: 6341
	public class HideSpecificEntities : ActionParams
	{
		// Token: 0x060084FF RID: 34047 RVA: 0x0013D318 File Offset: 0x0013B518
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

		// Token: 0x06008500 RID: 34048 RVA: 0x0013D350 File Offset: 0x0013B550
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

		// Token: 0x06008501 RID: 34049 RVA: 0x0013D363 File Offset: 0x0013B563
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

		// Token: 0x06008502 RID: 34050 RVA: 0x0013D376 File Offset: 0x0013B576
		public HideSpecificEntities_SetValue ToSetValue()
		{
			return new HideSpecificEntities_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x06008503 RID: 34051 RVA: 0x0013D389 File Offset: 0x0013B589
		// (set) Token: 0x06008504 RID: 34052 RVA: 0x0013D3B0 File Offset: 0x0013B5B0
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

		// Token: 0x0400548E RID: 21646
		[Nullable(2)]
		protected new HideSpecificEntities FbInstance;

		// Token: 0x0400548F RID: 21647
		[Nullable(2)]
		protected HideSpecificEntities_SetValue PocoInterface;
	}
}
