using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F4D RID: 8013
	public class IPostAkEventTargeted : IPostAkEventType
	{
		// Token: 0x0600AA85 RID: 43653 RVA: 0x00182958 File Offset: 0x00180B58
		private IPostAkEventTargeted_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPostAkEventTargeted 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPostAkEventTargeted_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPostAkEventTargeted_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x00182990 File Offset: 0x00180B90
		public static IPostAkEventTargeted Create([Nullable(2)] IPostAkEventTargeted instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventTargeted
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA87 RID: 43655 RVA: 0x001829A3 File Offset: 0x00180BA3
		public static IPostAkEventTargeted CreateFromSetValue([Nullable(2)] IPostAkEventTargeted_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPostAkEventTargeted
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x001829B6 File Offset: 0x00180BB6
		public new IPostAkEventTargeted_SetValue ToSetValue()
		{
			return new IPostAkEventTargeted_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x001829E1 File Offset: 0x00180BE1
		// (set) Token: 0x0600AA8A RID: 43658 RVA: 0x00182A0C File Offset: 0x00180C0C
		public override EPostAkEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPostAkEvent.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600AA8B RID: 43659 RVA: 0x00182A1A File Offset: 0x00180C1A
		// (set) Token: 0x0600AA8C RID: 43660 RVA: 0x00182A45 File Offset: 0x00180C45
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600AA8D RID: 43661 RVA: 0x00182A53 File Offset: 0x00180C53
		// (set) Token: 0x0600AA8E RID: 43662 RVA: 0x00182A7E File Offset: 0x00180C7E
		public virtual string AkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AkEvent;
			}
			set
			{
				this.GetOrCreatePoco().AkEvent = value;
			}
		}

		// Token: 0x04006642 RID: 26178
		[Nullable(2)]
		protected new IPostAkEventTargeted FbInstance;

		// Token: 0x04006643 RID: 26179
		[Nullable(2)]
		protected new IPostAkEventTargeted_SetValue PocoInterface;
	}
}
