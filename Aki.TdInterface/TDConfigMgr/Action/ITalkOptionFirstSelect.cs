using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021AB RID: 8619
	public class ITalkOptionFirstSelect : ITalkOptionPreConditionBase
	{
		// Token: 0x0600BBF8 RID: 48120 RVA: 0x001B3840 File Offset: 0x001B1A40
		private ITalkOptionFirstSelect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionFirstSelect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionFirstSelect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionFirstSelect_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBF9 RID: 48121 RVA: 0x001B3878 File Offset: 0x001B1A78
		public static ITalkOptionFirstSelect Create([Nullable(2)] ITalkOptionFirstSelect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionFirstSelect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x001B388B File Offset: 0x001B1A8B
		public static ITalkOptionFirstSelect CreateFromSetValue([Nullable(2)] ITalkOptionFirstSelect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionFirstSelect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x001B389E File Offset: 0x001B1A9E
		public new ITalkOptionFirstSelect_SetValue ToSetValue()
		{
			return new ITalkOptionFirstSelect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x001B38B1 File Offset: 0x001B1AB1
		// (set) Token: 0x0600BBFD RID: 48125 RVA: 0x001B38DC File Offset: 0x001B1ADC
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

		// Token: 0x04007114 RID: 28948
		[Nullable(2)]
		protected new ITalkOptionFirstSelect FbInstance;

		// Token: 0x04007115 RID: 28949
		[Nullable(2)]
		protected new ITalkOptionFirstSelect_SetValue PocoInterface;
	}
}
