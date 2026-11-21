using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002376 RID: 9078
	public class PlayFlow : ActionParams
	{
		// Token: 0x0600C5D4 RID: 50644 RVA: 0x001C57FC File Offset: 0x001C39FC
		private PlayFlow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayFlow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayFlow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayFlow_SetValue());
			}
			return result;
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x001C5834 File Offset: 0x001C3A34
		public static PlayFlow Create([Nullable(2)] PlayFlow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayFlow
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x001C5847 File Offset: 0x001C3A47
		public static PlayFlow CreateFromSetValue([Nullable(2)] PlayFlow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayFlow
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x001C585A File Offset: 0x001C3A5A
		public PlayFlow_SetValue ToSetValue()
		{
			return new PlayFlow_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId,
				StateId = this.StateId,
				FlowGuid = this.FlowGuid
			};
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0600C5D8 RID: 50648 RVA: 0x001C5891 File Offset: 0x001C3A91
		// (set) Token: 0x0600C5D9 RID: 50649 RVA: 0x001C58BC File Offset: 0x001C3ABC
		public virtual string FlowListName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowListName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FlowListName;
			}
			set
			{
				this.GetOrCreatePoco().FlowListName = value;
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0600C5DA RID: 50650 RVA: 0x001C58CA File Offset: 0x001C3ACA
		// (set) Token: 0x0600C5DB RID: 50651 RVA: 0x001C58F5 File Offset: 0x001C3AF5
		public virtual int FlowId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlowId;
			}
			set
			{
				this.GetOrCreatePoco().FlowId = value;
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0600C5DC RID: 50652 RVA: 0x001C5903 File Offset: 0x001C3B03
		// (set) Token: 0x0600C5DD RID: 50653 RVA: 0x001C592E File Offset: 0x001C3B2E
		public virtual int StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0600C5DE RID: 50654 RVA: 0x001C593C File Offset: 0x001C3B3C
		// (set) Token: 0x0600C5DF RID: 50655 RVA: 0x001C5963 File Offset: 0x001C3B63
		[Nullable(2)]
		public virtual string FlowGuid
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowGuid;
				}
				PlayFlow_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FlowGuid;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FlowGuid = value;
			}
		}

		// Token: 0x040075B3 RID: 30131
		[Nullable(2)]
		protected new PlayFlow FbInstance;

		// Token: 0x040075B4 RID: 30132
		[Nullable(2)]
		protected PlayFlow_SetValue PocoInterface;
	}
}
