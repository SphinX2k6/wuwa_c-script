using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002199 RID: 8601
	[NullableContext(1)]
	[Nullable(0)]
	public class SetAreaTimeState : ActionParams
	{
		// Token: 0x0600BCEC RID: 48364 RVA: 0x001B34A0 File Offset: 0x001B16A0
		private SetAreaTimeState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetAreaTimeState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetAreaTimeState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetAreaTimeState_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCED RID: 48365 RVA: 0x001B34D8 File Offset: 0x001B16D8
		public static SetAreaTimeState Create([Nullable(2)] SetAreaTimeState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAreaTimeState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x001B34EB File Offset: 0x001B16EB
		public static SetAreaTimeState CreateFromSetValue([Nullable(2)] SetAreaTimeState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetAreaTimeState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x001B34FE File Offset: 0x001B16FE
		public SetAreaTimeState_SetValue ToSetValue()
		{
			return new SetAreaTimeState_SetValue
			{
				SetAreaTimeConfig = this.SetAreaTimeConfig
			};
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600BCF0 RID: 48368 RVA: 0x001B3511 File Offset: 0x001B1711
		// (set) Token: 0x0600BCF1 RID: 48369 RVA: 0x001B3538 File Offset: 0x001B1738
		public virtual ISetAreaTimeBase SetAreaTimeConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetAreaTimeConfig;
				}
				SetAreaTimeState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SetAreaTimeConfig;
			}
			set
			{
				this.GetOrCreatePoco().SetAreaTimeConfig = value;
			}
		}

		// Token: 0x040070C4 RID: 28868
		[Nullable(2)]
		protected new SetAreaTimeState FbInstance;

		// Token: 0x040070C5 RID: 28869
		[Nullable(2)]
		protected SetAreaTimeState_SetValue PocoInterface;
	}
}
