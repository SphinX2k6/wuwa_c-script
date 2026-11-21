using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F4 RID: 756
	public class IDefaultAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x00033CAC File Offset: 0x00031EAC
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

		// Token: 0x06000E02 RID: 3586 RVA: 0x00033CE4 File Offset: 0x00031EE4
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

		// Token: 0x06000E03 RID: 3587 RVA: 0x00033CF7 File Offset: 0x00031EF7
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

		// Token: 0x06000E04 RID: 3588 RVA: 0x00033D0A File Offset: 0x00031F0A
		public new IDefaultAkEvent_SetValue ToSetValue()
		{
			return new IDefaultAkEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00033D1D File Offset: 0x00031F1D
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00033D48 File Offset: 0x00031F48
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

		// Token: 0x04000CC1 RID: 3265
		[Nullable(2)]
		protected new IDefaultAkEvent FbInstance;

		// Token: 0x04000CC2 RID: 3266
		[Nullable(2)]
		protected new IDefaultAkEvent_SetValue PocoInterface;
	}
}
