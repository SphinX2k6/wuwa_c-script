using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005DA RID: 1498
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathDrivenActorMoveBase
	{
		// Token: 0x06001FB6 RID: 8118 RVA: 0x00058C20 File Offset: 0x00056E20
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

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00058C58 File Offset: 0x00056E58
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

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00058C6B File Offset: 0x00056E6B
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

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00058C7E File Offset: 0x00056E7E
		public IPathDrivenActorMoveBase_SetValue ToSetValue()
		{
			return new IPathDrivenActorMoveBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00058C91 File Offset: 0x00056E91
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00058CBC File Offset: 0x00056EBC
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

		// Token: 0x0400165B RID: 5723
		[Nullable(2)]
		protected IPathDrivenActorMoveBase FbInstance;

		// Token: 0x0400165C RID: 5724
		[Nullable(2)]
		protected IPathDrivenActorMoveBase_SetValue PocoInterface;
	}
}
