using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1B RID: 3611
	public class IPathDrivenActorInitialSpawnConfig
	{
		// Token: 0x060051B9 RID: 20921 RVA: 0x000C9863 File Offset: 0x000C7A63
		[NullableContext(1)]
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

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x000C9882 File Offset: 0x000C7A82
		public virtual bool EnableInitialSpawn
		{
			get
			{
				return this.Instance.EnableInitialSpawn;
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x000C9890 File Offset: 0x000C7A90
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

		// Token: 0x04002F10 RID: 12048
		private IPathDrivenActorInitialSpawnConfig Instance;

		// Token: 0x04002F11 RID: 12049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPathDrivenActorInitialSpawnHandle> _InitialSpawnHandlesCache;

		// Token: 0x04002F12 RID: 12050
		private bool _InitialSpawnHandlesInited;
	}
}
