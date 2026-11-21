using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002430 RID: 9264
	public class SetMoveSpeed : ActionParams
	{
		// Token: 0x0600C994 RID: 51604 RVA: 0x001CC978 File Offset: 0x001CAB78
		private SetMoveSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetMoveSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetMoveSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetMoveSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x0600C995 RID: 51605 RVA: 0x001CC9B0 File Offset: 0x001CABB0
		public static SetMoveSpeed Create([Nullable(2)] SetMoveSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetMoveSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C996 RID: 51606 RVA: 0x001CC9C3 File Offset: 0x001CABC3
		public static SetMoveSpeed CreateFromSetValue([Nullable(2)] SetMoveSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetMoveSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C997 RID: 51607 RVA: 0x001CC9D6 File Offset: 0x001CABD6
		public SetMoveSpeed_SetValue ToSetValue()
		{
			return new SetMoveSpeed_SetValue
			{
				Speed = this.Speed
			};
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0600C998 RID: 51608 RVA: 0x001CC9E9 File Offset: 0x001CABE9
		// (set) Token: 0x0600C999 RID: 51609 RVA: 0x001CCA18 File Offset: 0x001CAC18
		public virtual float Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x04007799 RID: 30617
		[Nullable(2)]
		protected new SetMoveSpeed FbInstance;

		// Token: 0x0400779A RID: 30618
		[Nullable(2)]
		protected SetMoveSpeed_SetValue PocoInterface;
	}
}
