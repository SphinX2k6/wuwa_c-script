using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200066D RID: 1645
	public class IPathDrivenActorSpawnBase
	{
		// Token: 0x0600228A RID: 8842 RVA: 0x0005F368 File Offset: 0x0005D568
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

		// Token: 0x0600228B RID: 8843 RVA: 0x0005F3A0 File Offset: 0x0005D5A0
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

		// Token: 0x0600228C RID: 8844 RVA: 0x0005F3B3 File Offset: 0x0005D5B3
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

		// Token: 0x0600228D RID: 8845 RVA: 0x0005F3C6 File Offset: 0x0005D5C6
		public IPathDrivenActorSpawnBase_SetValue ToSetValue()
		{
			return new IPathDrivenActorSpawnBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x0005F3D9 File Offset: 0x0005D5D9
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x0005F404 File Offset: 0x0005D604
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

		// Token: 0x04001835 RID: 6197
		[Nullable(2)]
		protected IPathDrivenActorSpawnBase FbInstance;

		// Token: 0x04001836 RID: 6198
		[Nullable(2)]
		protected IPathDrivenActorSpawnBase_SetValue PocoInterface;
	}
}
