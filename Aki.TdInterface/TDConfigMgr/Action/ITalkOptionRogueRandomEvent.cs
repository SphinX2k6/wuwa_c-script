using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021BD RID: 8637
	public class ITalkOptionRogueRandomEvent : ITalkOptionParamType
	{
		// Token: 0x0600BC44 RID: 48196 RVA: 0x001B3F70 File Offset: 0x001B2170
		private ITalkOptionRogueRandomEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionRogueRandomEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionRogueRandomEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionRogueRandomEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC45 RID: 48197 RVA: 0x001B3FA8 File Offset: 0x001B21A8
		public static ITalkOptionRogueRandomEvent Create([Nullable(2)] ITalkOptionRogueRandomEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionRogueRandomEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x001B3FBB File Offset: 0x001B21BB
		public static ITalkOptionRogueRandomEvent CreateFromSetValue([Nullable(2)] ITalkOptionRogueRandomEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionRogueRandomEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC47 RID: 48199 RVA: 0x001B3FCE File Offset: 0x001B21CE
		public new ITalkOptionRogueRandomEvent_SetValue ToSetValue()
		{
			return new ITalkOptionRogueRandomEvent_SetValue
			{
				Type = this.Type,
				OptionId = this.OptionId
			};
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600BC48 RID: 48200 RVA: 0x001B3FED File Offset: 0x001B21ED
		// (set) Token: 0x0600BC49 RID: 48201 RVA: 0x001B4018 File Offset: 0x001B2218
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0600BC4A RID: 48202 RVA: 0x001B4028 File Offset: 0x001B2228
		// (set) Token: 0x0600BC4B RID: 48203 RVA: 0x001B4062 File Offset: 0x001B2262
		public virtual int? OptionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionId;
				}
				ITalkOptionRogueRandomEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionId;
			}
			set
			{
				this.GetOrCreatePoco().OptionId = value;
			}
		}

		// Token: 0x04007131 RID: 28977
		[Nullable(2)]
		protected new ITalkOptionRogueRandomEvent FbInstance;

		// Token: 0x04007132 RID: 28978
		[Nullable(2)]
		protected new ITalkOptionRogueRandomEvent_SetValue PocoInterface;
	}
}
