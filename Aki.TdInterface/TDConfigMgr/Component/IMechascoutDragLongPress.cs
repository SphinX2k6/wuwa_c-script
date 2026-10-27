using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E2 RID: 1250
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechascoutDragLongPress : IMechascoutDragTypeBase
	{
		// Token: 0x0600196A RID: 6506 RVA: 0x0004B1A8 File Offset: 0x000493A8
		private IMechascoutDragLongPress_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechascoutDragLongPress 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechascoutDragLongPress_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechascoutDragLongPress_SetValue());
			}
			return result;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0004B1E0 File Offset: 0x000493E0
		public static IMechascoutDragLongPress Create([Nullable(2)] IMechascoutDragLongPress instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutDragLongPress
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0004B1F3 File Offset: 0x000493F3
		public static IMechascoutDragLongPress CreateFromSetValue([Nullable(2)] IMechascoutDragLongPress_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechascoutDragLongPress
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0004B206 File Offset: 0x00049406
		public new IMechascoutDragLongPress_SetValue ToSetValue()
		{
			return new IMechascoutDragLongPress_SetValue
			{
				Type = this.Type,
				LongPressDuration = this.LongPressDuration
			};
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0004B225 File Offset: 0x00049425
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0004B250 File Offset: 0x00049450
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

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x0004B25E File Offset: 0x0004945E
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x0004B28D File Offset: 0x0004948D
		public virtual float LongPressDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongPressDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.LongPressDuration;
			}
			set
			{
				this.GetOrCreatePoco().LongPressDuration = value;
			}
		}

		// Token: 0x040012A5 RID: 4773
		[Nullable(2)]
		protected new IMechascoutDragLongPress FbInstance;

		// Token: 0x040012A6 RID: 4774
		[Nullable(2)]
		protected new IMechascoutDragLongPress_SetValue PocoInterface;
	}
}
