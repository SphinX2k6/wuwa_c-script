using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002215 RID: 8725
	public class IToggleDragActorPlayType
	{
		// Token: 0x0600BE40 RID: 48704 RVA: 0x001B7958 File Offset: 0x001B5B58
		private IToggleDragActorPlayType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleDragActorPlayType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleDragActorPlayType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleDragActorPlayType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE41 RID: 48705 RVA: 0x001B7990 File Offset: 0x001B5B90
		public static IToggleDragActorPlayType Create([Nullable(2)] IToggleDragActorPlayType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE42 RID: 48706 RVA: 0x001B79A3 File Offset: 0x001B5BA3
		public static IToggleDragActorPlayType CreateFromSetValue([Nullable(2)] IToggleDragActorPlayType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleDragActorPlayType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x001B79B6 File Offset: 0x001B5BB6
		public IToggleDragActorPlayType_SetValue ToSetValue()
		{
			return new IToggleDragActorPlayType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0600BE44 RID: 48708 RVA: 0x001B79C9 File Offset: 0x001B5BC9
		// (set) Token: 0x0600BE45 RID: 48709 RVA: 0x001B79F4 File Offset: 0x001B5BF4
		public virtual EToggleDragActorPlayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleDragActorPlayType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007221 RID: 29217
		[Nullable(2)]
		protected IToggleDragActorPlayType FbInstance;

		// Token: 0x04007222 RID: 29218
		[Nullable(2)]
		protected IToggleDragActorPlayType_SetValue PocoInterface;
	}
}
