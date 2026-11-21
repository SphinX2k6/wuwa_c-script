using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000539 RID: 1337
	public class IMechascoutDragInstant : IMechascoutDragTypeBase
	{
		// Token: 0x06001AFC RID: 6908 RVA: 0x0004EE34 File Offset: 0x0004D034
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

		// Token: 0x06001AFD RID: 6909 RVA: 0x0004EE6C File Offset: 0x0004D06C
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

		// Token: 0x06001AFE RID: 6910 RVA: 0x0004EE7F File Offset: 0x0004D07F
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

		// Token: 0x06001AFF RID: 6911 RVA: 0x0004EE92 File Offset: 0x0004D092
		public new IMechascoutDragInstant_SetValue ToSetValue()
		{
			return new IMechascoutDragInstant_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0004EEA5 File Offset: 0x0004D0A5
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x0004EED0 File Offset: 0x0004D0D0
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

		// Token: 0x040013C4 RID: 5060
		[Nullable(2)]
		protected new IMechascoutDragInstant FbInstance;

		// Token: 0x040013C5 RID: 5061
		[Nullable(2)]
		protected new IMechascoutDragInstant_SetValue PocoInterface;
	}
}
