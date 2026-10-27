using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C29 RID: 3113
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMovementComponent : IComponentBase
	{
		// Token: 0x06004751 RID: 18257 RVA: 0x000B398A File Offset: 0x000B1B8A
		[NullableContext(1)]
		public static SceneItemMovementComponent Create(ISceneItemMovementComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemMovementComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x000B39AC File Offset: 0x000B1BAC
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x000B39E4 File Offset: 0x000B1BE4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x000B39FA File Offset: 0x000B1BFA
		public virtual ISplineMove Patrol
		{
			get
			{
				if (this._PatrolInited)
				{
					return this._PatrolCache;
				}
				this._PatrolInited = true;
				this._PatrolCache = ISplineMove.Create(this.Instance.Patrol);
				return this._PatrolCache;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x000B3A2E File Offset: 0x000B1C2E
		public virtual IMovementPlatformConfig PlatformConfig
		{
			get
			{
				if (this._PlatformConfigInited)
				{
					return this._PlatformConfigCache;
				}
				this._PlatformConfigInited = true;
				this._PlatformConfigCache = IMovementPlatformConfig.Create(this.Instance.PlatformConfig);
				return this._PlatformConfigCache;
			}
		}

		// Token: 0x0400287A RID: 10362
		private ISceneItemMovementComponent Instance;

		// Token: 0x0400287B RID: 10363
		private ISplineMove _PatrolCache;

		// Token: 0x0400287C RID: 10364
		private bool _PatrolInited;

		// Token: 0x0400287D RID: 10365
		private IMovementPlatformConfig _PlatformConfigCache;

		// Token: 0x0400287E RID: 10366
		private bool _PlatformConfigInited;
	}
}
