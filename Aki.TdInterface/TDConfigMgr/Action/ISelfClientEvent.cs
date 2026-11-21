using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002023 RID: 8227
	public class ISelfClientEvent : IClientEventTarget
	{
		// Token: 0x0600AEAF RID: 44719 RVA: 0x00189C9C File Offset: 0x00187E9C
		private ISelfClientEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISelfClientEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISelfClientEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISelfClientEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x00189CD4 File Offset: 0x00187ED4
		public static ISelfClientEvent Create([Nullable(2)] ISelfClientEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfClientEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x00189CE7 File Offset: 0x00187EE7
		public static ISelfClientEvent CreateFromSetValue([Nullable(2)] ISelfClientEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISelfClientEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x00189CFA File Offset: 0x00187EFA
		public new ISelfClientEvent_SetValue ToSetValue()
		{
			return new ISelfClientEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x00189D0D File Offset: 0x00187F0D
		// (set) Token: 0x0600AEB4 RID: 44724 RVA: 0x00189D38 File Offset: 0x00187F38
		public override EClientEventTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventTarget.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400681A RID: 26650
		[Nullable(2)]
		protected new ISelfClientEvent FbInstance;

		// Token: 0x0400681B RID: 26651
		[Nullable(2)]
		protected new ISelfClientEvent_SetValue PocoInterface;
	}
}
