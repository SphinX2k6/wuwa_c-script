using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D6 RID: 1494
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathDrivenActorInitialSpawnConfig
	{
		// Token: 0x06001FA2 RID: 8098 RVA: 0x000589B0 File Offset: 0x00056BB0
		private IPathDrivenActorInitialSpawnConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathDrivenActorInitialSpawnConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathDrivenActorInitialSpawnConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathDrivenActorInitialSpawnConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000589E8 File Offset: 0x00056BE8
		public static IPathDrivenActorInitialSpawnConfig Create([Nullable(2)] IPathDrivenActorInitialSpawnConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000589FB File Offset: 0x00056BFB
		public static IPathDrivenActorInitialSpawnConfig CreateFromSetValue([Nullable(2)] IPathDrivenActorInitialSpawnConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00058A0E File Offset: 0x00056C0E
		public IPathDrivenActorInitialSpawnConfig_SetValue ToSetValue()
		{
			return new IPathDrivenActorInitialSpawnConfig_SetValue
			{
				EnableInitialSpawn = this.EnableInitialSpawn,
				InitialSpawnHandles = this.InitialSpawnHandles
			};
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00058A2D File Offset: 0x00056C2D
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x00058A58 File Offset: 0x00056C58
		public virtual bool EnableInitialSpawn
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableInitialSpawn;
				}
				return this.PocoInterface != null && this.PocoInterface.EnableInitialSpawn;
			}
			set
			{
				this.GetOrCreatePoco().EnableInitialSpawn = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00058A68 File Offset: 0x00056C68
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x00058AFB File Offset: 0x00056CFB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IPathDrivenActorInitialSpawnHandle> InitialSpawnHandles
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._InitialSpawnHandlesInited)
				{
					return this._InitialSpawnHandlesCache;
				}
				this._InitialSpawnHandlesInited = true;
				if (this.FbInstance != null)
				{
					List<IPathDrivenActorInitialSpawnHandle> initialSpawnHandles = this.FbInstance.InitialSpawnHandles;
					if (initialSpawnHandles != null)
					{
						this._InitialSpawnHandlesCache = new List<IPathDrivenActorInitialSpawnHandle>(initialSpawnHandles.Count);
						for (int i = 0; i < initialSpawnHandles.Count; i++)
						{
							this._InitialSpawnHandlesCache.Add(IPathDrivenActorInitialSpawnHandle.Create(initialSpawnHandles[i]));
						}
					}
				}
				else
				{
					IPathDrivenActorInitialSpawnConfig_SetValue pocoInterface = this.PocoInterface;
					this._InitialSpawnHandlesCache = ((pocoInterface != null) ? pocoInterface.InitialSpawnHandles : null);
				}
				return this._InitialSpawnHandlesCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().InitialSpawnHandles = value;
				this._InitialSpawnHandlesInited = false;
			}
		}

		// Token: 0x04001651 RID: 5713
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnConfig FbInstance;

		// Token: 0x04001652 RID: 5714
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnConfig_SetValue PocoInterface;

		// Token: 0x04001653 RID: 5715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPathDrivenActorInitialSpawnHandle> _InitialSpawnHandlesCache;

		// Token: 0x04001654 RID: 5716
		private bool _InitialSpawnHandlesInited;
	}
}
