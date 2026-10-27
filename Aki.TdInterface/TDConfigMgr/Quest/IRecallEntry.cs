using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E8 RID: 4328
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntry
	{
		// Token: 0x060061E0 RID: 25056 RVA: 0x000EC14C File Offset: 0x000EA34C
		private IRecallEntry_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallEntry 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallEntry_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallEntry_SetValue());
			}
			return result;
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x000EC184 File Offset: 0x000EA384
		public static IRecallEntry Create([Nullable(2)] IRecallEntry instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntry
			{
				FbInstance = instance
			};
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x000EC197 File Offset: 0x000EA397
		public static IRecallEntry CreateFromSetValue([Nullable(2)] IRecallEntry_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallEntry
			{
				PocoInterface = value
			};
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x000EC1AA File Offset: 0x000EA3AA
		public IRecallEntry_SetValue ToSetValue()
		{
			return new IRecallEntry_SetValue
			{
				RecallId = this.RecallId,
				IncludeGroups = this.IncludeGroups,
				ExcludeGroups = this.ExcludeGroups
			};
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x060061E4 RID: 25060 RVA: 0x000EC1D5 File Offset: 0x000EA3D5
		// (set) Token: 0x060061E5 RID: 25061 RVA: 0x000EC200 File Offset: 0x000EA400
		public virtual int RecallId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RecallId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RecallId;
			}
			set
			{
				this.GetOrCreatePoco().RecallId = value;
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x060061E6 RID: 25062 RVA: 0x000EC20E File Offset: 0x000EA40E
		// (set) Token: 0x060061E7 RID: 25063 RVA: 0x000EC235 File Offset: 0x000EA435
		public virtual List<int> IncludeGroups
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IncludeGroups;
				}
				IRecallEntry_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IncludeGroups;
			}
			set
			{
				this.GetOrCreatePoco().IncludeGroups = value;
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x060061E8 RID: 25064 RVA: 0x000EC243 File Offset: 0x000EA443
		// (set) Token: 0x060061E9 RID: 25065 RVA: 0x000EC26A File Offset: 0x000EA46A
		public virtual List<int> ExcludeGroups
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExcludeGroups;
				}
				IRecallEntry_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExcludeGroups;
			}
			set
			{
				this.GetOrCreatePoco().ExcludeGroups = value;
			}
		}

		// Token: 0x04003ADB RID: 15067
		[Nullable(2)]
		protected IRecallEntry FbInstance;

		// Token: 0x04003ADC RID: 15068
		[Nullable(2)]
		protected IRecallEntry_SetValue PocoInterface;
	}
}
