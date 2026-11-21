using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002402 RID: 9218
	public class SetAreaTimeState : ActionParams
	{
		// Token: 0x0600C89C RID: 51356 RVA: 0x001CA998 File Offset: 0x001C8B98
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

		// Token: 0x0600C89D RID: 51357 RVA: 0x001CA9D0 File Offset: 0x001C8BD0
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

		// Token: 0x0600C89E RID: 51358 RVA: 0x001CA9E3 File Offset: 0x001C8BE3
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

		// Token: 0x0600C89F RID: 51359 RVA: 0x001CA9F6 File Offset: 0x001C8BF6
		public SetAreaTimeState_SetValue ToSetValue()
		{
			return new SetAreaTimeState_SetValue
			{
				SetAreaTimeConfig = this.SetAreaTimeConfig
			};
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600C8A0 RID: 51360 RVA: 0x001CAA09 File Offset: 0x001C8C09
		// (set) Token: 0x0600C8A1 RID: 51361 RVA: 0x001CAA30 File Offset: 0x001C8C30
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

		// Token: 0x04007706 RID: 30470
		[Nullable(2)]
		protected new SetAreaTimeState FbInstance;

		// Token: 0x04007707 RID: 30471
		[Nullable(2)]
		protected SetAreaTimeState_SetValue PocoInterface;
	}
}
