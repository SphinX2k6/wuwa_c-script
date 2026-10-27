using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E20 RID: 3616
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorSpawnerComponent : IComponentBase
	{
		// Token: 0x060051D2 RID: 20946 RVA: 0x000C9B4A File Offset: 0x000C7D4A
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

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x000C9B6C File Offset: 0x000C7D6C
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

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x000C9BA4 File Offset: 0x000C7DA4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x000C9BBA File Offset: 0x000C7DBA
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

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x000C9BEE File Offset: 0x000C7DEE
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

		// Token: 0x04002F1F RID: 12063
		private IPathDrivenActorSpawnerComponent Instance;

		// Token: 0x04002F20 RID: 12064
		[Nullable(2)]
		private IIntervalSplineSpawn _SpawnRuleCache;

		// Token: 0x04002F21 RID: 12065
		private bool _SpawnRuleInited;

		// Token: 0x04002F22 RID: 12066
		private ITargetEntityType _TargetCache;

		// Token: 0x04002F23 RID: 12067
		private bool _TargetInited;
	}
}
