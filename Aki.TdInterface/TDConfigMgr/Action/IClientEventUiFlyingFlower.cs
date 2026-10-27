using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B4 RID: 6324
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventUiFlyingFlower : IClientEventUi
	{
		// Token: 0x060087B7 RID: 34743 RVA: 0x0014188C File Offset: 0x0013FA8C
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

		// Token: 0x060087B8 RID: 34744 RVA: 0x001418C4 File Offset: 0x0013FAC4
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

		// Token: 0x060087B9 RID: 34745 RVA: 0x001418D7 File Offset: 0x0013FAD7
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

		// Token: 0x060087BA RID: 34746 RVA: 0x001418EA File Offset: 0x0013FAEA
		public new IClientEventUiFlyingFlower_SetValue ToSetValue()
		{
			return new IClientEventUiFlyingFlower_SetValue
			{
				Type = this.Type,
				EventType = this.EventType
			};
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x060087BB RID: 34747 RVA: 0x00141909 File Offset: 0x0013FB09
		// (set) Token: 0x060087BC RID: 34748 RVA: 0x00141934 File Offset: 0x0013FB34
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

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x060087BD RID: 34749 RVA: 0x00141944 File Offset: 0x0013FB44
		// (set) Token: 0x060087BE RID: 34750 RVA: 0x001419A5 File Offset: 0x0013FBA5
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

		// Token: 0x0400555D RID: 21853
		[Nullable(2)]
		protected new IClientEventUiFlyingFlower FbInstance;

		// Token: 0x0400555E RID: 21854
		[Nullable(2)]
		protected new IClientEventUiFlyingFlower_SetValue PocoInterface;

		// Token: 0x0400555F RID: 21855
		private IClientEventFlyingFlowerUpdateSubtitle _EventTypeCache;

		// Token: 0x04005560 RID: 21856
		private bool _EventTypeInited;
	}
}
