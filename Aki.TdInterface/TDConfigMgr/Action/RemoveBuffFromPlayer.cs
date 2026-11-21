using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A7 RID: 9127
	public class RemoveBuffFromPlayer : ActionParams
	{
		// Token: 0x0600C714 RID: 50964 RVA: 0x001C808C File Offset: 0x001C628C
		private RemoveBuffFromPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveBuffFromPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveBuffFromPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveBuffFromPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x0600C715 RID: 50965 RVA: 0x001C80C4 File Offset: 0x001C62C4
		public static RemoveBuffFromPlayer Create([Nullable(2)] RemoveBuffFromPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffFromPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C716 RID: 50966 RVA: 0x001C80D7 File Offset: 0x001C62D7
		public static RemoveBuffFromPlayer CreateFromSetValue([Nullable(2)] RemoveBuffFromPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveBuffFromPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C717 RID: 50967 RVA: 0x001C80EA File Offset: 0x001C62EA
		public RemoveBuffFromPlayer_SetValue ToSetValue()
		{
			return new RemoveBuffFromPlayer_SetValue
			{
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0600C718 RID: 50968 RVA: 0x001C80FD File Offset: 0x001C62FD
		// (set) Token: 0x0600C719 RID: 50969 RVA: 0x001C8124 File Offset: 0x001C6324
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				RemoveBuffFromPlayer_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BuffIds;
			}
			set
			{
				this.GetOrCreatePoco().BuffIds = value;
			}
		}

		// Token: 0x04007654 RID: 30292
		[Nullable(2)]
		protected new RemoveBuffFromPlayer FbInstance;

		// Token: 0x04007655 RID: 30293
		[Nullable(2)]
		protected RemoveBuffFromPlayer_SetValue PocoInterface;
	}
}
