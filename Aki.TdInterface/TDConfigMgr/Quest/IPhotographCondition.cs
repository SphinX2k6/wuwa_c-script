using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200103F RID: 4159
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographCondition
	{
		// Token: 0x06005D2C RID: 23852 RVA: 0x000E1BC4 File Offset: 0x000DFDC4
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

		// Token: 0x06005D2D RID: 23853 RVA: 0x000E1BFC File Offset: 0x000DFDFC
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

		// Token: 0x06005D2E RID: 23854 RVA: 0x000E1C0F File Offset: 0x000DFE0F
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

		// Token: 0x06005D2F RID: 23855 RVA: 0x000E1C22 File Offset: 0x000DFE22
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

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06005D30 RID: 23856 RVA: 0x000E1C59 File Offset: 0x000DFE59
		// (set) Token: 0x06005D31 RID: 23857 RVA: 0x000E1C84 File Offset: 0x000DFE84
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

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06005D32 RID: 23858 RVA: 0x000E1C92 File Offset: 0x000DFE92
		// (set) Token: 0x06005D33 RID: 23859 RVA: 0x000E1CB9 File Offset: 0x000DFEB9
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

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06005D34 RID: 23860 RVA: 0x000E1CC7 File Offset: 0x000DFEC7
		// (set) Token: 0x06005D35 RID: 23861 RVA: 0x000E1CEE File Offset: 0x000DFEEE
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IPhotographSubTarget> SubTargets
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().SubTargets = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06005D36 RID: 23862 RVA: 0x000E1CFC File Offset: 0x000DFEFC
		// (set) Token: 0x06005D37 RID: 23863 RVA: 0x000E1D13 File Offset: 0x000DFF13
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

		// Token: 0x04003822 RID: 14370
		[Nullable(2)]
		protected IPhotographCondition FbInstance;

		// Token: 0x04003823 RID: 14371
		[Nullable(2)]
		protected IPhotographCondition_SetValue PocoInterface;
	}
}
