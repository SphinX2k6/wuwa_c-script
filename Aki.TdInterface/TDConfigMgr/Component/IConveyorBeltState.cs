using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002CE RID: 718
	public class IConveyorBeltState
	{
		// Token: 0x06000D3B RID: 3387 RVA: 0x000326C4 File Offset: 0x000308C4
		private IConveyorBeltState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConveyorBeltState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConveyorBeltState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConveyorBeltState_SetValue());
			}
			return result;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000326FC File Offset: 0x000308FC
		public static IConveyorBeltState Create([Nullable(2)] IConveyorBeltState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0003270F File Offset: 0x0003090F
		public static IConveyorBeltState CreateFromSetValue([Nullable(2)] IConveyorBeltState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConveyorBeltState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00032722 File Offset: 0x00030922
		public IConveyorBeltState_SetValue ToSetValue()
		{
			return new IConveyorBeltState_SetValue
			{
				EntityState = this.EntityState,
				FieldType = this.FieldType,
				MoveType = this.MoveType
			};
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0003274D File Offset: 0x0003094D
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00032778 File Offset: 0x00030978
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00032786 File Offset: 0x00030986
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x000327AD File Offset: 0x000309AD
		public virtual IConveyorBeltField FieldType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FieldType;
				}
				IConveyorBeltState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FieldType;
			}
			set
			{
				this.GetOrCreatePoco().FieldType = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x000327BC File Offset: 0x000309BC
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x0003281D File Offset: 0x00030A1D
		public virtual IFixSpeed MoveType
		{
			get
			{
				if (this._MoveTypeInited)
				{
					return this._MoveTypeCache;
				}
				this._MoveTypeInited = true;
				if (this.FbInstance != null)
				{
					this._MoveTypeCache = IFixSpeed.Create(this.FbInstance.MoveType);
				}
				else
				{
					IConveyorBeltState_SetValue pocoInterface = this.PocoInterface;
					this._MoveTypeCache = ((pocoInterface != null) ? pocoInterface.MoveType : null);
				}
				return this._MoveTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().MoveType = value;
				this._MoveTypeInited = false;
			}
		}

		// Token: 0x04000C67 RID: 3175
		[Nullable(2)]
		protected IConveyorBeltState FbInstance;

		// Token: 0x04000C68 RID: 3176
		[Nullable(2)]
		protected IConveyorBeltState_SetValue PocoInterface;

		// Token: 0x04000C69 RID: 3177
		private IFixSpeed _MoveTypeCache;

		// Token: 0x04000C6A RID: 3178
		private bool _MoveTypeInited;
	}
}
