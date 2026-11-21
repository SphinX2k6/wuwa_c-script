using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002211 RID: 8721
	public class IToggleDragActorPlayDisable : IToggleDragActorPlayType
	{
		// Token: 0x0600BE1E RID: 48670 RVA: 0x001B7550 File Offset: 0x001B5750
		private IToggleDragActorPlayDisable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleDragActorPlayDisable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleDragActorPlayDisable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleDragActorPlayDisable_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE1F RID: 48671 RVA: 0x001B7588 File Offset: 0x001B5788
		public static IToggleDragActorPlayDisable Create([Nullable(2)] IToggleDragActorPlayDisable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayDisable
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE20 RID: 48672 RVA: 0x001B759B File Offset: 0x001B579B
		public static IToggleDragActorPlayDisable CreateFromSetValue([Nullable(2)] IToggleDragActorPlayDisable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleDragActorPlayDisable
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x001B75AE File Offset: 0x001B57AE
		public new IToggleDragActorPlayDisable_SetValue ToSetValue()
		{
			return new IToggleDragActorPlayDisable_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0600BE22 RID: 48674 RVA: 0x001B75C1 File Offset: 0x001B57C1
		// (set) Token: 0x0600BE23 RID: 48675 RVA: 0x001B75EC File Offset: 0x001B57EC
		public override EToggleDragActorPlayType Type
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

		// Token: 0x04007210 RID: 29200
		[Nullable(2)]
		protected new IToggleDragActorPlayDisable FbInstance;

		// Token: 0x04007211 RID: 29201
		[Nullable(2)]
		protected new IToggleDragActorPlayDisable_SetValue PocoInterface;
	}
}
