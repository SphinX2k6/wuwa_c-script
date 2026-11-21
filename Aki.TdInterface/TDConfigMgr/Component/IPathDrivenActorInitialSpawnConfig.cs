using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000667 RID: 1639
	public class IPathDrivenActorInitialSpawnConfig
	{
		// Token: 0x0600226E RID: 8814 RVA: 0x0005F03C File Offset: 0x0005D23C
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

		// Token: 0x0600226F RID: 8815 RVA: 0x0005F074 File Offset: 0x0005D274
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

		// Token: 0x06002270 RID: 8816 RVA: 0x0005F087 File Offset: 0x0005D287
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

		// Token: 0x06002271 RID: 8817 RVA: 0x0005F09A File Offset: 0x0005D29A
		public IPathDrivenActorInitialSpawnConfig_SetValue ToSetValue()
		{
			return new IPathDrivenActorInitialSpawnConfig_SetValue
			{
				EnableInitialSpawn = this.EnableInitialSpawn,
				InitialSpawnHandles = this.InitialSpawnHandles
			};
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x0005F0B9 File Offset: 0x0005D2B9
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x0005F0E4 File Offset: 0x0005D2E4
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

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0005F0F4 File Offset: 0x0005D2F4
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x0005F187 File Offset: 0x0005D387
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPathDrivenActorInitialSpawnHandle> InitialSpawnHandles
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().InitialSpawnHandles = value;
				this._InitialSpawnHandlesInited = false;
			}
		}

		// Token: 0x04001828 RID: 6184
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnConfig FbInstance;

		// Token: 0x04001829 RID: 6185
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnConfig_SetValue PocoInterface;

		// Token: 0x0400182A RID: 6186
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPathDrivenActorInitialSpawnHandle> _InitialSpawnHandlesCache;

		// Token: 0x0400182B RID: 6187
		private bool _InitialSpawnHandlesInited;
	}
}
