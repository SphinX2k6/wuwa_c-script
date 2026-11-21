using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B3 RID: 8627
	public class ITalkOptionPreOption : ITalkOptionPreConditionBase
	{
		// Token: 0x0600BC1A RID: 48154 RVA: 0x001B3B84 File Offset: 0x001B1D84
		private ITalkOptionPreOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionPreOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionPreOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionPreOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC1B RID: 48155 RVA: 0x001B3BBC File Offset: 0x001B1DBC
		public static ITalkOptionPreOption Create([Nullable(2)] ITalkOptionPreOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionPreOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC1C RID: 48156 RVA: 0x001B3BCF File Offset: 0x001B1DCF
		public static ITalkOptionPreOption CreateFromSetValue([Nullable(2)] ITalkOptionPreOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionPreOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x001B3BE2 File Offset: 0x001B1DE2
		public new ITalkOptionPreOption_SetValue ToSetValue()
		{
			return new ITalkOptionPreOption_SetValue
			{
				Type = this.Type,
				PreOptions = this.PreOptions
			};
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600BC1E RID: 48158 RVA: 0x001B3C01 File Offset: 0x001B1E01
		// (set) Token: 0x0600BC1F RID: 48159 RVA: 0x001B3C2C File Offset: 0x001B1E2C
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0600BC20 RID: 48160 RVA: 0x001B3C3A File Offset: 0x001B1E3A
		// (set) Token: 0x0600BC21 RID: 48161 RVA: 0x001B3C61 File Offset: 0x001B1E61
		public virtual List<int> PreOptions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PreOptions;
				}
				ITalkOptionPreOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PreOptions;
			}
			set
			{
				this.GetOrCreatePoco().PreOptions = value;
			}
		}

		// Token: 0x04007121 RID: 28961
		[Nullable(2)]
		protected new ITalkOptionPreOption FbInstance;

		// Token: 0x04007122 RID: 28962
		[Nullable(2)]
		protected new ITalkOptionPreOption_SetValue PocoInterface;
	}
}
