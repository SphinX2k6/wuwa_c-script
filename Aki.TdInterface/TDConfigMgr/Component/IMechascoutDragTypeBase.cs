using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E4 RID: 1252
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechascoutDragTypeBase
	{
		// Token: 0x06001974 RID: 6516 RVA: 0x0004B2AC File Offset: 0x000494AC
		private IMechascoutDragTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechascoutDragTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechascoutDragTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechascoutDragTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0004B2E4 File Offset: 0x000494E4
		public static IMechascoutDragTypeBase Create([Nullable(2)] IMechascoutDragTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutDragTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0004B2F7 File Offset: 0x000494F7
		public static IMechascoutDragTypeBase CreateFromSetValue([Nullable(2)] IMechascoutDragTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechascoutDragTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0004B30A File Offset: 0x0004950A
		public IMechascoutDragTypeBase_SetValue ToSetValue()
		{
			return new IMechascoutDragTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0004B31D File Offset: 0x0004951D
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0004B348 File Offset: 0x00049548
		public virtual EMechascoutDragType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechascoutDragType.Instant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012A9 RID: 4777
		[Nullable(2)]
		protected IMechascoutDragTypeBase FbInstance;

		// Token: 0x040012AA RID: 4778
		[Nullable(2)]
		protected IMechascoutDragTypeBase_SetValue PocoInterface;
	}
}
