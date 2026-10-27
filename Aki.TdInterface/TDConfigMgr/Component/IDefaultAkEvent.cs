using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002AD RID: 685
	[NullableContext(1)]
	[Nullable(0)]
	public class IDefaultAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06000CD1 RID: 3281 RVA: 0x00030D78 File Offset: 0x0002EF78
		private IDefaultAkEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDefaultAkEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDefaultAkEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDefaultAkEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00030DB0 File Offset: 0x0002EFB0
		public static IDefaultAkEvent Create([Nullable(2)] IDefaultAkEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultAkEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00030DC3 File Offset: 0x0002EFC3
		public static IDefaultAkEvent CreateFromSetValue([Nullable(2)] IDefaultAkEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDefaultAkEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00030DD6 File Offset: 0x0002EFD6
		public new IDefaultAkEvent_SetValue ToSetValue()
		{
			return new IDefaultAkEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00030DE9 File Offset: 0x0002EFE9
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00030E14 File Offset: 0x0002F014
		public override EAkEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventType.Point;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000BD7 RID: 3031
		[Nullable(2)]
		protected new IDefaultAkEvent FbInstance;

		// Token: 0x04000BD8 RID: 3032
		[Nullable(2)]
		protected new IDefaultAkEvent_SetValue PocoInterface;
	}
}
