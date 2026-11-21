using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053B RID: 1339
	public class IMechascoutDragLongPress : IMechascoutDragTypeBase
	{
		// Token: 0x06001B04 RID: 6916 RVA: 0x0004EEF0 File Offset: 0x0004D0F0
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

		// Token: 0x06001B05 RID: 6917 RVA: 0x0004EF28 File Offset: 0x0004D128
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

		// Token: 0x06001B06 RID: 6918 RVA: 0x0004EF3B File Offset: 0x0004D13B
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

		// Token: 0x06001B07 RID: 6919 RVA: 0x0004EF4E File Offset: 0x0004D14E
		public new IMechascoutDragLongPress_SetValue ToSetValue()
		{
			return new IMechascoutDragLongPress_SetValue
			{
				Type = this.Type,
				LongPressDuration = this.LongPressDuration
			};
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0004EF6D File Offset: 0x0004D16D
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0004EF98 File Offset: 0x0004D198
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

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0004EFA6 File Offset: 0x0004D1A6
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0004EFD5 File Offset: 0x0004D1D5
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

		// Token: 0x040013C7 RID: 5063
		[Nullable(2)]
		protected new IMechascoutDragLongPress FbInstance;

		// Token: 0x040013C8 RID: 5064
		[Nullable(2)]
		protected new IMechascoutDragLongPress_SetValue PocoInterface;
	}
}
