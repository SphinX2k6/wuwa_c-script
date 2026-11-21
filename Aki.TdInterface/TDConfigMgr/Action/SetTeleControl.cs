using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244D RID: 9293
	public class SetTeleControl : ActionParams
	{
		// Token: 0x0600CA51 RID: 51793 RVA: 0x001CE1A8 File Offset: 0x001CC3A8
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

		// Token: 0x0600CA52 RID: 51794 RVA: 0x001CE1E0 File Offset: 0x001CC3E0
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

		// Token: 0x0600CA53 RID: 51795 RVA: 0x001CE1F3 File Offset: 0x001CC3F3
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

		// Token: 0x0600CA54 RID: 51796 RVA: 0x001CE206 File Offset: 0x001CC406
		public SetTeleControl_SetValue ToSetValue()
		{
			return new SetTeleControl_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600CA55 RID: 51797 RVA: 0x001CE219 File Offset: 0x001CC419
		// (set) Token: 0x0600CA56 RID: 51798 RVA: 0x001CE240 File Offset: 0x001CC440
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

		// Token: 0x04007800 RID: 30720
		[Nullable(2)]
		protected new SetTeleControl FbInstance;

		// Token: 0x04007801 RID: 30721
		[Nullable(2)]
		protected SetTeleControl_SetValue PocoInterface;
	}
}
