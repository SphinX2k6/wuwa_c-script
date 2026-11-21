using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A3F RID: 6719
	public class IClientEventUiFlyingFlower : IClientEventUi
	{
		// Token: 0x06008EDF RID: 36575 RVA: 0x001510C0 File Offset: 0x0014F2C0
		private IClientEventUiFlyingFlower_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventUiFlyingFlower 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventUiFlyingFlower_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventUiFlyingFlower_SetValue());
			}
			return result;
		}

		// Token: 0x06008EE0 RID: 36576 RVA: 0x001510F8 File Offset: 0x0014F2F8
		public static IClientEventUiFlyingFlower Create([Nullable(2)] IClientEventUiFlyingFlower instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventUiFlyingFlower
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x0015110B File Offset: 0x0014F30B
		public static IClientEventUiFlyingFlower CreateFromSetValue([Nullable(2)] IClientEventUiFlyingFlower_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventUiFlyingFlower
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x0015111E File Offset: 0x0014F31E
		public new IClientEventUiFlyingFlower_SetValue ToSetValue()
		{
			return new IClientEventUiFlyingFlower_SetValue
			{
				Type = this.Type,
				EventType = this.EventType
			};
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x0015113D File Offset: 0x0014F33D
		// (set) Token: 0x06008EE4 RID: 36580 RVA: 0x00151168 File Offset: 0x0014F368
		public override EClientEventUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventUiType.PlayPiano;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x06008EE5 RID: 36581 RVA: 0x00151178 File Offset: 0x0014F378
		// (set) Token: 0x06008EE6 RID: 36582 RVA: 0x001511D9 File Offset: 0x0014F3D9
		public virtual IClientEventFlyingFlowerUpdateSubtitle EventType
		{
			get
			{
				if (this._EventTypeInited)
				{
					return this._EventTypeCache;
				}
				this._EventTypeInited = true;
				if (this.FbInstance != null)
				{
					this._EventTypeCache = IClientEventFlyingFlowerUpdateSubtitle.Create(this.FbInstance.EventType);
				}
				else
				{
					IClientEventUiFlyingFlower_SetValue pocoInterface = this.PocoInterface;
					this._EventTypeCache = ((pocoInterface != null) ? pocoInterface.EventType : null);
				}
				return this._EventTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().EventType = value;
				this._EventTypeInited = false;
			}
		}

		// Token: 0x040059AA RID: 22954
		[Nullable(2)]
		protected new IClientEventUiFlyingFlower FbInstance;

		// Token: 0x040059AB RID: 22955
		[Nullable(2)]
		protected new IClientEventUiFlyingFlower_SetValue PocoInterface;

		// Token: 0x040059AC RID: 22956
		private IClientEventFlyingFlowerUpdateSubtitle _EventTypeCache;

		// Token: 0x040059AD RID: 22957
		private bool _EventTypeInited;
	}
}
