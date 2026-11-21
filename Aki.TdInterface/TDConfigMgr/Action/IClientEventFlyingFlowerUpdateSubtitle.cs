using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A33 RID: 6707
	public class IClientEventFlyingFlowerUpdateSubtitle : IClientEventFlyingFlowerEvent
	{
		// Token: 0x06008EA9 RID: 36521 RVA: 0x00150B0C File Offset: 0x0014ED0C
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

		// Token: 0x06008EAA RID: 36522 RVA: 0x00150B44 File Offset: 0x0014ED44
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

		// Token: 0x06008EAB RID: 36523 RVA: 0x00150B57 File Offset: 0x0014ED57
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

		// Token: 0x06008EAC RID: 36524 RVA: 0x00150B6A File Offset: 0x0014ED6A
		public new IClientEventFlyingFlowerUpdateSubtitle_SetValue ToSetValue()
		{
			return new IClientEventFlyingFlowerUpdateSubtitle_SetValue
			{
				Type = this.Type,
				Flow = this.Flow
			};
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x06008EAD RID: 36525 RVA: 0x00150B89 File Offset: 0x0014ED89
		// (set) Token: 0x06008EAE RID: 36526 RVA: 0x00150BB4 File Offset: 0x0014EDB4
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

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x06008EAF RID: 36527 RVA: 0x00150BC4 File Offset: 0x0014EDC4
		// (set) Token: 0x06008EB0 RID: 36528 RVA: 0x00150C25 File Offset: 0x0014EE25
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

		// Token: 0x04005991 RID: 22929
		[Nullable(2)]
		protected new IClientEventFlyingFlowerUpdateSubtitle FbInstance;

		// Token: 0x04005992 RID: 22930
		[Nullable(2)]
		protected new IClientEventFlyingFlowerUpdateSubtitle_SetValue PocoInterface;

		// Token: 0x04005993 RID: 22931
		private PlayFlow _FlowCache;

		// Token: 0x04005994 RID: 22932
		private bool _FlowInited;
	}
}
