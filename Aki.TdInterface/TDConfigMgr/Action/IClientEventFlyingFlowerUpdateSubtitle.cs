using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A8 RID: 6312
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventFlyingFlowerUpdateSubtitle : IClientEventFlyingFlowerEvent
	{
		// Token: 0x06008781 RID: 34689 RVA: 0x001412D8 File Offset: 0x0013F4D8
		private IClientEventFlyingFlowerUpdateSubtitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventFlyingFlowerUpdateSubtitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventFlyingFlowerUpdateSubtitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventFlyingFlowerUpdateSubtitle_SetValue());
			}
			return result;
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x00141310 File Offset: 0x0013F510
		public static IClientEventFlyingFlowerUpdateSubtitle Create([Nullable(2)] IClientEventFlyingFlowerUpdateSubtitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventFlyingFlowerUpdateSubtitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x00141323 File Offset: 0x0013F523
		public static IClientEventFlyingFlowerUpdateSubtitle CreateFromSetValue([Nullable(2)] IClientEventFlyingFlowerUpdateSubtitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventFlyingFlowerUpdateSubtitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x00141336 File Offset: 0x0013F536
		public new IClientEventFlyingFlowerUpdateSubtitle_SetValue ToSetValue()
		{
			return new IClientEventFlyingFlowerUpdateSubtitle_SetValue
			{
				Type = this.Type,
				Flow = this.Flow
			};
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x06008785 RID: 34693 RVA: 0x00141355 File Offset: 0x0013F555
		// (set) Token: 0x06008786 RID: 34694 RVA: 0x00141380 File Offset: 0x0013F580
		public override EClientEventFlyingFlowerEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventFlyingFlowerEventType.UpdateSubtitle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x06008787 RID: 34695 RVA: 0x00141390 File Offset: 0x0013F590
		// (set) Token: 0x06008788 RID: 34696 RVA: 0x001413F1 File Offset: 0x0013F5F1
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					IClientEventFlyingFlowerUpdateSubtitle_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x04005544 RID: 21828
		[Nullable(2)]
		protected new IClientEventFlyingFlowerUpdateSubtitle FbInstance;

		// Token: 0x04005545 RID: 21829
		[Nullable(2)]
		protected new IClientEventFlyingFlowerUpdateSubtitle_SetValue PocoInterface;

		// Token: 0x04005546 RID: 21830
		private PlayFlow _FlowCache;

		// Token: 0x04005547 RID: 21831
		private bool _FlowInited;
	}
}
