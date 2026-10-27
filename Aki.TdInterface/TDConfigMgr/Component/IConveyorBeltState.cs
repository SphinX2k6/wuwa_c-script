using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200028B RID: 651
	[NullableContext(1)]
	[Nullable(0)]
	public class IConveyorBeltState
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
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

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002FA0C File Offset: 0x0002DC0C
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

		// Token: 0x06000C23 RID: 3107 RVA: 0x0002FA1F File Offset: 0x0002DC1F
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

		// Token: 0x06000C24 RID: 3108 RVA: 0x0002FA32 File Offset: 0x0002DC32
		public IConveyorBeltState_SetValue ToSetValue()
		{
			return new IConveyorBeltState_SetValue
			{
				EntityState = this.EntityState,
				FieldType = this.FieldType,
				MoveType = this.MoveType
			};
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0002FA5D File Offset: 0x0002DC5D
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0002FA88 File Offset: 0x0002DC88
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0002FA96 File Offset: 0x0002DC96
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0002FABD File Offset: 0x0002DCBD
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

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0002FACC File Offset: 0x0002DCCC
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0002FB2D File Offset: 0x0002DD2D
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

		// Token: 0x04000B86 RID: 2950
		[Nullable(2)]
		protected IConveyorBeltState FbInstance;

		// Token: 0x04000B87 RID: 2951
		[Nullable(2)]
		protected IConveyorBeltState_SetValue PocoInterface;

		// Token: 0x04000B88 RID: 2952
		private IFixSpeed _MoveTypeCache;

		// Token: 0x04000B89 RID: 2953
		private bool _MoveTypeInited;
	}
}
