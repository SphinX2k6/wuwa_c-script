using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053D RID: 1341
	public class IMechascoutDragTypeBase
	{
		// Token: 0x06001B0E RID: 6926 RVA: 0x0004EFF4 File Offset: 0x0004D1F4
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

		// Token: 0x06001B0F RID: 6927 RVA: 0x0004F02C File Offset: 0x0004D22C
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

		// Token: 0x06001B10 RID: 6928 RVA: 0x0004F03F File Offset: 0x0004D23F
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

		// Token: 0x06001B11 RID: 6929 RVA: 0x0004F052 File Offset: 0x0004D252
		public IMechascoutDragTypeBase_SetValue ToSetValue()
		{
			return new IMechascoutDragTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0004F065 File Offset: 0x0004D265
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0004F090 File Offset: 0x0004D290
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

		// Token: 0x040013CB RID: 5067
		[Nullable(2)]
		protected IMechascoutDragTypeBase FbInstance;

		// Token: 0x040013CC RID: 5068
		[Nullable(2)]
		protected IMechascoutDragTypeBase_SetValue PocoInterface;
	}
}
