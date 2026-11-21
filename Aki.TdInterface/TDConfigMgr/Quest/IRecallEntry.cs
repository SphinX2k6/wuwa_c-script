using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001216 RID: 4630
	public class IRecallEntry
	{
		// Token: 0x060067D9 RID: 26585 RVA: 0x000F926C File Offset: 0x000F746C
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

		// Token: 0x060067DA RID: 26586 RVA: 0x000F92A4 File Offset: 0x000F74A4
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

		// Token: 0x060067DB RID: 26587 RVA: 0x000F92B7 File Offset: 0x000F74B7
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

		// Token: 0x060067DC RID: 26588 RVA: 0x000F92CA File Offset: 0x000F74CA
		public IRecallEntry_SetValue ToSetValue()
		{
			return new IRecallEntry_SetValue
			{
				RecallId = this.RecallId,
				IncludeGroups = this.IncludeGroups,
				ExcludeGroups = this.ExcludeGroups
			};
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x000F92F5 File Offset: 0x000F74F5
		// (set) Token: 0x060067DE RID: 26590 RVA: 0x000F9320 File Offset: 0x000F7520
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

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x000F932E File Offset: 0x000F752E
		// (set) Token: 0x060067E0 RID: 26592 RVA: 0x000F9355 File Offset: 0x000F7555
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

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x000F9363 File Offset: 0x000F7563
		// (set) Token: 0x060067E2 RID: 26594 RVA: 0x000F938A File Offset: 0x000F758A
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

		// Token: 0x04003E28 RID: 15912
		[Nullable(2)]
		protected IRecallEntry FbInstance;

		// Token: 0x04003E29 RID: 15913
		[Nullable(2)]
		protected IRecallEntry_SetValue PocoInterface;
	}
}
