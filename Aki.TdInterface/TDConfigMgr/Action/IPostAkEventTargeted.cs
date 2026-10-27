using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3C RID: 7484
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventTargeted : IPostAkEventType
	{
		// Token: 0x0600A099 RID: 41113 RVA: 0x0016E534 File Offset: 0x0016C734
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

		// Token: 0x0600A09A RID: 41114 RVA: 0x0016E56C File Offset: 0x0016C76C
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

		// Token: 0x0600A09B RID: 41115 RVA: 0x0016E57F File Offset: 0x0016C77F
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

		// Token: 0x0600A09C RID: 41116 RVA: 0x0016E592 File Offset: 0x0016C792
		public new IPostAkEventTargeted_SetValue ToSetValue()
		{
			return new IPostAkEventTargeted_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x0016E5BD File Offset: 0x0016C7BD
		// (set) Token: 0x0600A09E RID: 41118 RVA: 0x0016E5E8 File Offset: 0x0016C7E8
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

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x0016E5F6 File Offset: 0x0016C7F6
		// (set) Token: 0x0600A0A0 RID: 41120 RVA: 0x0016E621 File Offset: 0x0016C821
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

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600A0A1 RID: 41121 RVA: 0x0016E62F File Offset: 0x0016C82F
		// (set) Token: 0x0600A0A2 RID: 41122 RVA: 0x0016E65A File Offset: 0x0016C85A
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

		// Token: 0x040060C6 RID: 24774
		[Nullable(2)]
		protected new IPostAkEventTargeted FbInstance;

		// Token: 0x040060C7 RID: 24775
		[Nullable(2)]
		protected new IPostAkEventTargeted_SetValue PocoInterface;
	}
}
