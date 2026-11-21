using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F0 RID: 2288
	public class PathDrivenActorSpawnerComponent : IComponentBase
	{
		// Token: 0x06003213 RID: 12819 RVA: 0x00080684 File Offset: 0x0007E884
		private PathDrivenActorSpawnerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PathDrivenActorSpawnerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PathDrivenActorSpawnerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PathDrivenActorSpawnerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000806BC File Offset: 0x0007E8BC
		public static PathDrivenActorSpawnerComponent Create([Nullable(2)] PathDrivenActorSpawnerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PathDrivenActorSpawnerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000806CF File Offset: 0x0007E8CF
		public static PathDrivenActorSpawnerComponent CreateFromSetValue([Nullable(2)] PathDrivenActorSpawnerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PathDrivenActorSpawnerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000806E2 File Offset: 0x0007E8E2
		public new PathDrivenActorSpawnerComponent_SetValue ToSetValue()
		{
			return new PathDrivenActorSpawnerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SpawnRule = this.SpawnRule,
				Target = this.Target
			};
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x0008071C File Offset: 0x0007E91C
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x00080756 File Offset: 0x0007E956
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				PathDrivenActorSpawnerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x00080764 File Offset: 0x0007E964
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x0008078E File Offset: 0x0007E98E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x0008079C File Offset: 0x0007E99C
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x000807FD File Offset: 0x0007E9FD
		public virtual IIntervalSplineSpawn SpawnRule
		{
			get
			{
				if (this._SpawnRuleInited)
				{
					return this._SpawnRuleCache;
				}
				this._SpawnRuleInited = true;
				if (this.FbInstance != null)
				{
					this._SpawnRuleCache = IIntervalSplineSpawn.Create(this.FbInstance.SpawnRule);
				}
				else
				{
					PathDrivenActorSpawnerComponent_SetValue pocoInterface = this.PocoInterface;
					this._SpawnRuleCache = ((pocoInterface != null) ? pocoInterface.SpawnRule : null);
				}
				return this._SpawnRuleCache;
			}
			set
			{
				this.GetOrCreatePoco().SpawnRule = value;
				this._SpawnRuleInited = false;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x00080812 File Offset: 0x0007EA12
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x00080839 File Offset: 0x0007EA39
		[Nullable(2)]
		public virtual ITargetEntityType Target
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				PathDrivenActorSpawnerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x04002109 RID: 8457
		[Nullable(2)]
		protected new PathDrivenActorSpawnerComponent FbInstance;

		// Token: 0x0400210A RID: 8458
		[Nullable(2)]
		protected new PathDrivenActorSpawnerComponent_SetValue PocoInterface;

		// Token: 0x0400210B RID: 8459
		private IIntervalSplineSpawn _SpawnRuleCache;

		// Token: 0x0400210C RID: 8460
		private bool _SpawnRuleInited;
	}
}
