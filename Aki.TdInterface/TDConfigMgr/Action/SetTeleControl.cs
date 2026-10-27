using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E2 RID: 8674
	[NullableContext(1)]
	[Nullable(0)]
	public class SetTeleControl : ActionParams
	{
		// Token: 0x0600BE95 RID: 48789 RVA: 0x001B6B1C File Offset: 0x001B4D1C
		private SetTeleControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetTeleControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetTeleControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetTeleControl_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE96 RID: 48790 RVA: 0x001B6B54 File Offset: 0x001B4D54
		public static SetTeleControl Create([Nullable(2)] SetTeleControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetTeleControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE97 RID: 48791 RVA: 0x001B6B67 File Offset: 0x001B4D67
		public static SetTeleControl CreateFromSetValue([Nullable(2)] SetTeleControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetTeleControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE98 RID: 48792 RVA: 0x001B6B7A File Offset: 0x001B4D7A
		public SetTeleControl_SetValue ToSetValue()
		{
			return new SetTeleControl_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600BE99 RID: 48793 RVA: 0x001B6B8D File Offset: 0x001B4D8D
		// (set) Token: 0x0600BE9A RID: 48794 RVA: 0x001B6BB4 File Offset: 0x001B4DB4
		public virtual ISetTeleControlConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				SetTeleControl_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040071B7 RID: 29111
		[Nullable(2)]
		protected new SetTeleControl FbInstance;

		// Token: 0x040071B8 RID: 29112
		[Nullable(2)]
		protected SetTeleControl_SetValue PocoInterface;
	}
}
