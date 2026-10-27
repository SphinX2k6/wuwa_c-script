using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E0 RID: 1248
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechascoutDragInstant : IMechascoutDragTypeBase
	{
		// Token: 0x06001962 RID: 6498 RVA: 0x0004B0EC File Offset: 0x000492EC
		private IMechascoutDragInstant_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechascoutDragInstant 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechascoutDragInstant_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechascoutDragInstant_SetValue());
			}
			return result;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0004B124 File Offset: 0x00049324
		public static IMechascoutDragInstant Create([Nullable(2)] IMechascoutDragInstant instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutDragInstant
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x0004B137 File Offset: 0x00049337
		public static IMechascoutDragInstant CreateFromSetValue([Nullable(2)] IMechascoutDragInstant_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechascoutDragInstant
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0004B14A File Offset: 0x0004934A
		public new IMechascoutDragInstant_SetValue ToSetValue()
		{
			return new IMechascoutDragInstant_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0004B15D File Offset: 0x0004935D
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0004B188 File Offset: 0x00049388
		public override EMechascoutDragType Type
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

		// Token: 0x040012A2 RID: 4770
		[Nullable(2)]
		protected new IMechascoutDragInstant FbInstance;

		// Token: 0x040012A3 RID: 4771
		[Nullable(2)]
		protected new IMechascoutDragInstant_SetValue PocoInterface;
	}
}
