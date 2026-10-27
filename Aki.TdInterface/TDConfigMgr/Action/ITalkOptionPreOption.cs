using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F78 RID: 8056
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionPreOption : ITalkOptionPreConditionBase
	{
		// Token: 0x0600B140 RID: 45376 RVA: 0x0019DC30 File Offset: 0x0019BE30
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

		// Token: 0x0600B141 RID: 45377 RVA: 0x0019DC68 File Offset: 0x0019BE68
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

		// Token: 0x0600B142 RID: 45378 RVA: 0x0019DC7B File Offset: 0x0019BE7B
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

		// Token: 0x0600B143 RID: 45379 RVA: 0x0019DC8E File Offset: 0x0019BE8E
		public new ITalkOptionPreOption_SetValue ToSetValue()
		{
			return new ITalkOptionPreOption_SetValue
			{
				Type = this.Type,
				PreOptions = this.PreOptions
			};
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600B144 RID: 45380 RVA: 0x0019DCAD File Offset: 0x0019BEAD
		// (set) Token: 0x0600B145 RID: 45381 RVA: 0x0019DCD8 File Offset: 0x0019BED8
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

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600B146 RID: 45382 RVA: 0x0019DCE6 File Offset: 0x0019BEE6
		// (set) Token: 0x0600B147 RID: 45383 RVA: 0x0019DD0D File Offset: 0x0019BF0D
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

		// Token: 0x04006B39 RID: 27449
		[Nullable(2)]
		protected new ITalkOptionPreOption FbInstance;

		// Token: 0x04006B3A RID: 27450
		[Nullable(2)]
		protected new ITalkOptionPreOption_SetValue PocoInterface;
	}
}
