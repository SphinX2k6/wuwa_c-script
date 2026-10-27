using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D4 RID: 1748
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkyboxGlobalTrigger : ISkyboxTrigger
	{
		// Token: 0x0600259E RID: 9630 RVA: 0x00065300 File Offset: 0x00063500
		private ISkyboxGlobalTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkyboxGlobalTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkyboxGlobalTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkyboxGlobalTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00065338 File Offset: 0x00063538
		public static ISkyboxGlobalTrigger Create([Nullable(2)] ISkyboxGlobalTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxGlobalTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0006534B File Offset: 0x0006354B
		public static ISkyboxGlobalTrigger CreateFromSetValue([Nullable(2)] ISkyboxGlobalTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkyboxGlobalTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0006535E File Offset: 0x0006355E
		public new ISkyboxGlobalTrigger_SetValue ToSetValue()
		{
			return new ISkyboxGlobalTrigger_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x00065371 File Offset: 0x00063571
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x0006539C File Offset: 0x0006359C
		public override ETriggerMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETriggerMode.Distance;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040019A6 RID: 6566
		[Nullable(2)]
		protected new ISkyboxGlobalTrigger FbInstance;

		// Token: 0x040019A7 RID: 6567
		[Nullable(2)]
		protected new ISkyboxGlobalTrigger_SetValue PocoInterface;
	}
}
