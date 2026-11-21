using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F17 RID: 3863
	public class IPathDrivenActorInitialSpawnConfig
	{
		// Token: 0x060056E0 RID: 22240 RVA: 0x000D512B File Offset: 0x000D332B
		public static IPathDrivenActorInitialSpawnConfig Create(IPathDrivenActorInitialSpawnConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x060056E1 RID: 22241 RVA: 0x000D514A File Offset: 0x000D334A
		public virtual bool EnableInitialSpawn
		{
			get
			{
				return this.Instance.EnableInitialSpawn;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x000D5158 File Offset: 0x000D3358
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int initialSpawnHandlesLength = this.Instance.InitialSpawnHandlesLength;
				this._InitialSpawnHandlesCache = new List<IPathDrivenActorInitialSpawnHandle>(initialSpawnHandlesLength);
				for (int i = 0; i < initialSpawnHandlesLength; i++)
				{
					this._InitialSpawnHandlesCache.Add(IPathDrivenActorInitialSpawnHandle.Create(this.Instance.InitialSpawnHandles(i)));
				}
				return this._InitialSpawnHandlesCache;
			}
		}

		// Token: 0x040031D8 RID: 12760
		private IPathDrivenActorInitialSpawnConfig Instance;

		// Token: 0x040031D9 RID: 12761
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPathDrivenActorInitialSpawnHandle> _InitialSpawnHandlesCache;

		// Token: 0x040031DA RID: 12762
		private bool _InitialSpawnHandlesInited;
	}
}
