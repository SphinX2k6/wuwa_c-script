using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200066B RID: 1643
	public class IPathDrivenActorMoveBase
	{
		// Token: 0x06002282 RID: 8834 RVA: 0x0005F2AC File Offset: 0x0005D4AC
		private IPathDrivenActorMoveBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathDrivenActorMoveBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathDrivenActorMoveBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathDrivenActorMoveBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x0005F2E4 File Offset: 0x0005D4E4
		public static IPathDrivenActorMoveBase Create([Nullable(2)] IPathDrivenActorMoveBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorMoveBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x0005F2F7 File Offset: 0x0005D4F7
		public static IPathDrivenActorMoveBase CreateFromSetValue([Nullable(2)] IPathDrivenActorMoveBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathDrivenActorMoveBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0005F30A File Offset: 0x0005D50A
		public IPathDrivenActorMoveBase_SetValue ToSetValue()
		{
			return new IPathDrivenActorMoveBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x0005F31D File Offset: 0x0005D51D
		// (set) Token: 0x06002287 RID: 8839 RVA: 0x0005F348 File Offset: 0x0005D548
		public virtual EPathDrivenActorMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathDrivenActorMoveType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001832 RID: 6194
		[Nullable(2)]
		protected IPathDrivenActorMoveBase FbInstance;

		// Token: 0x04001833 RID: 6195
		[Nullable(2)]
		protected IPathDrivenActorMoveBase_SetValue PocoInterface;
	}
}
