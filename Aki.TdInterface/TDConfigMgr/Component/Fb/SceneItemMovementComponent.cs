using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFC RID: 3324
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMovementComponent : IComponentBase
	{
		// Token: 0x06004BC1 RID: 19393 RVA: 0x000BDD3A File Offset: 0x000BBF3A
		[NullableContext(0)]
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

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x000BDD5C File Offset: 0x000BBF5C
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

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x000BDD94 File Offset: 0x000BBF94
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x000BDDAA File Offset: 0x000BBFAA
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

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x000BDDDE File Offset: 0x000BBFDE
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

		// Token: 0x04002ACF RID: 10959
		private ISceneItemMovementComponent Instance;

		// Token: 0x04002AD0 RID: 10960
		private ISplineMove _PatrolCache;

		// Token: 0x04002AD1 RID: 10961
		private bool _PatrolInited;

		// Token: 0x04002AD2 RID: 10962
		private IMovementPlatformConfig _PlatformConfigCache;

		// Token: 0x04002AD3 RID: 10963
		private bool _PlatformConfigInited;
	}
}
