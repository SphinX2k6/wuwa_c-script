using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002146 RID: 8518
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveBuffFromPlayer : ActionParams
	{
		// Token: 0x0600BB86 RID: 48006 RVA: 0x001B0ED8 File Offset: 0x001AF0D8
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

		// Token: 0x0600BB87 RID: 48007 RVA: 0x001B0F10 File Offset: 0x001AF110
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

		// Token: 0x0600BB88 RID: 48008 RVA: 0x001B0F23 File Offset: 0x001AF123
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

		// Token: 0x0600BB89 RID: 48009 RVA: 0x001B0F36 File Offset: 0x001AF136
		public RemoveBuffFromPlayer_SetValue ToSetValue()
		{
			return new RemoveBuffFromPlayer_SetValue
			{
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x001B0F49 File Offset: 0x001AF149
		// (set) Token: 0x0600BB8B RID: 48011 RVA: 0x001B0F70 File Offset: 0x001AF170
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

		// Token: 0x0400701F RID: 28703
		[Nullable(2)]
		protected new RemoveBuffFromPlayer FbInstance;

		// Token: 0x04007020 RID: 28704
		[Nullable(2)]
		protected RemoveBuffFromPlayer_SetValue PocoInterface;
	}
}
