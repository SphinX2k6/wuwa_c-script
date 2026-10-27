using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005DC RID: 1500
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathDrivenActorSpawnBase
	{
		// Token: 0x06001FBE RID: 8126 RVA: 0x00058CDC File Offset: 0x00056EDC
		private IPathDrivenActorSpawnBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathDrivenActorSpawnBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathDrivenActorSpawnBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathDrivenActorSpawnBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00058D14 File Offset: 0x00056F14
		public static IPathDrivenActorSpawnBase Create([Nullable(2)] IPathDrivenActorSpawnBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorSpawnBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00058D27 File Offset: 0x00056F27
		public static IPathDrivenActorSpawnBase CreateFromSetValue([Nullable(2)] IPathDrivenActorSpawnBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathDrivenActorSpawnBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00058D3A File Offset: 0x00056F3A
		public IPathDrivenActorSpawnBase_SetValue ToSetValue()
		{
			return new IPathDrivenActorSpawnBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00058D4D File Offset: 0x00056F4D
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00058D78 File Offset: 0x00056F78
		public virtual EPathDrivenActorSpawnType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathDrivenActorSpawnType.IntervalSplineSpawn;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400165E RID: 5726
		[Nullable(2)]
		protected IPathDrivenActorSpawnBase FbInstance;

		// Token: 0x0400165F RID: 5727
		[Nullable(2)]
		protected IPathDrivenActorSpawnBase_SetValue PocoInterface;
	}
}
