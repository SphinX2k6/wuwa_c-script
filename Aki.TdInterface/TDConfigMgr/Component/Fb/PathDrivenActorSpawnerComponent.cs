using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F1C RID: 3868
	public class PathDrivenActorSpawnerComponent : IComponentBase
	{
		// Token: 0x060056F9 RID: 22265 RVA: 0x000D5412 File Offset: 0x000D3612
		public static PathDrivenActorSpawnerComponent Create(IPathDrivenActorSpawnerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PathDrivenActorSpawnerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x060056FA RID: 22266 RVA: 0x000D5434 File Offset: 0x000D3634
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

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x000D546C File Offset: 0x000D366C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x000D5482 File Offset: 0x000D3682
		public virtual IIntervalSplineSpawn SpawnRule
		{
			get
			{
				if (this._SpawnRuleInited)
				{
					return this._SpawnRuleCache;
				}
				this._SpawnRuleInited = true;
				this._SpawnRuleCache = IIntervalSplineSpawn.Create(this.Instance.SpawnRule);
				return this._SpawnRuleCache;
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x060056FD RID: 22269 RVA: 0x000D54B6 File Offset: 0x000D36B6
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ComponentReadHelper.ReadPathDrivenActorSpawnerComponent_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x040031E7 RID: 12775
		private IPathDrivenActorSpawnerComponent Instance;

		// Token: 0x040031E8 RID: 12776
		[Nullable(2)]
		private IIntervalSplineSpawn _SpawnRuleCache;

		// Token: 0x040031E9 RID: 12777
		private bool _SpawnRuleInited;

		// Token: 0x040031EA RID: 12778
		private ITargetEntityType _TargetCache;

		// Token: 0x040031EB RID: 12779
		private bool _TargetInited;
	}
}
