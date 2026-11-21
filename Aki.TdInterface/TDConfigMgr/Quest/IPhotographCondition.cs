using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116D RID: 4461
	public class IPhotographCondition
	{
		// Token: 0x0600631E RID: 25374 RVA: 0x000EEB98 File Offset: 0x000ECD98
		private IPhotographCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographCondition_SetValue());
			}
			return result;
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x000EEBD0 File Offset: 0x000ECDD0
		public static IPhotographCondition Create([Nullable(2)] IPhotographCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x000EEBE3 File Offset: 0x000ECDE3
		public static IPhotographCondition CreateFromSetValue([Nullable(2)] IPhotographCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x000EEBF6 File Offset: 0x000ECDF6
		public IPhotographCondition_SetValue ToSetValue()
		{
			return new IPhotographCondition_SetValue
			{
				TidTip = this.TidTip,
				Target = this.Target,
				SubTargets = this.SubTargets,
				EdTidTip = this.EdTidTip
			};
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06006322 RID: 25378 RVA: 0x000EEC2D File Offset: 0x000ECE2D
		// (set) Token: 0x06006323 RID: 25379 RVA: 0x000EEC58 File Offset: 0x000ECE58
		public virtual string TidTip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTip;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidTip;
			}
			set
			{
				this.GetOrCreatePoco().TidTip = value;
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06006324 RID: 25380 RVA: 0x000EEC66 File Offset: 0x000ECE66
		// (set) Token: 0x06006325 RID: 25381 RVA: 0x000EEC8D File Offset: 0x000ECE8D
		public virtual IPhotographTarget Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IPhotographCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06006326 RID: 25382 RVA: 0x000EEC9B File Offset: 0x000ECE9B
		// (set) Token: 0x06006327 RID: 25383 RVA: 0x000EECC2 File Offset: 0x000ECEC2
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPhotographSubTarget> SubTargets
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubTargets;
				}
				IPhotographCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SubTargets;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().SubTargets = value;
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06006328 RID: 25384 RVA: 0x000EECD0 File Offset: 0x000ECED0
		// (set) Token: 0x06006329 RID: 25385 RVA: 0x000EECE7 File Offset: 0x000ECEE7
		[Nullable(2)]
		public virtual string EdTidTip
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTip;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidTip = value;
			}
		}

		// Token: 0x04003B6A RID: 15210
		[Nullable(2)]
		protected IPhotographCondition FbInstance;

		// Token: 0x04003B6B RID: 15211
		[Nullable(2)]
		protected IPhotographCondition_SetValue PocoInterface;
	}
}
