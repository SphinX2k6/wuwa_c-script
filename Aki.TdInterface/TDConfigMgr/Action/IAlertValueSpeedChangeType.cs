using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017D4 RID: 6100
	[NullableContext(1)]
	[Nullable(0)]
	public class IAlertValueSpeedChangeType
	{
		// Token: 0x060082FB RID: 33531 RVA: 0x001390F4 File Offset: 0x001372F4
		private IAlertValueSpeedChangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAlertValueSpeedChangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAlertValueSpeedChangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAlertValueSpeedChangeType_SetValue());
			}
			return result;
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x0013912C File Offset: 0x0013732C
		public static IAlertValueSpeedChangeType Create([Nullable(2)] IAlertValueSpeedChangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAlertValueSpeedChangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x0013913F File Offset: 0x0013733F
		public static IAlertValueSpeedChangeType CreateFromSetValue([Nullable(2)] IAlertValueSpeedChangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAlertValueSpeedChangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x00139152 File Offset: 0x00137352
		public IAlertValueSpeedChangeType_SetValue ToSetValue()
		{
			return new IAlertValueSpeedChangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x060082FF RID: 33535 RVA: 0x00139165 File Offset: 0x00137365
		// (set) Token: 0x06008300 RID: 33536 RVA: 0x00139190 File Offset: 0x00137390
		public virtual EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005335 RID: 21301
		[Nullable(2)]
		protected IAlertValueSpeedChangeType FbInstance;

		// Token: 0x04005336 RID: 21302
		[Nullable(2)]
		protected IAlertValueSpeedChangeType_SetValue PocoInterface;
	}
}
