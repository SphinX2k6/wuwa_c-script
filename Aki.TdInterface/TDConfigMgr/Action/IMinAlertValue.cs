using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BDE RID: 7134
	[NullableContext(1)]
	[Nullable(0)]
	public class IMinAlertValue : ISetAlertValueType
	{
		// Token: 0x060098CB RID: 39115 RVA: 0x0015FF90 File Offset: 0x0015E190
		private IMinAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMinAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMinAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMinAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x0015FFC8 File Offset: 0x0015E1C8
		public static IMinAlertValue Create([Nullable(2)] IMinAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMinAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x0015FFDB File Offset: 0x0015E1DB
		public static IMinAlertValue CreateFromSetValue([Nullable(2)] IMinAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMinAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x0015FFEE File Offset: 0x0015E1EE
		public new IMinAlertValue_SetValue ToSetValue()
		{
			return new IMinAlertValue_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x060098CF RID: 39119 RVA: 0x00160001 File Offset: 0x0015E201
		// (set) Token: 0x060098D0 RID: 39120 RVA: 0x0016002C File Offset: 0x0015E22C
		public override EValueChangeType Type
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

		// Token: 0x04005D22 RID: 23842
		[Nullable(2)]
		protected new IMinAlertValue FbInstance;

		// Token: 0x04005D23 RID: 23843
		[Nullable(2)]
		protected new IMinAlertValue_SetValue PocoInterface;
	}
}
