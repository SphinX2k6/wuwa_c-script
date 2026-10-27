using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200084D RID: 2125
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorSpawnerComponent : IComponentBase
	{
		// Token: 0x06002ED7 RID: 11991 RVA: 0x0007919C File Offset: 0x0007739C
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

		// Token: 0x06002ED8 RID: 11992 RVA: 0x000791D4 File Offset: 0x000773D4
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

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000791E7 File Offset: 0x000773E7
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

		// Token: 0x06002EDA RID: 11994 RVA: 0x000791FA File Offset: 0x000773FA
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

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x00079234 File Offset: 0x00077434
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x0007926E File Offset: 0x0007746E
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

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x0007927C File Offset: 0x0007747C
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x000792A6 File Offset: 0x000774A6
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

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x000792B4 File Offset: 0x000774B4
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00079315 File Offset: 0x00077515
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

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x0007932A File Offset: 0x0007752A
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x00079351 File Offset: 0x00077551
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

		// Token: 0x04001EF7 RID: 7927
		[Nullable(2)]
		protected new PathDrivenActorSpawnerComponent FbInstance;

		// Token: 0x04001EF8 RID: 7928
		[Nullable(2)]
		protected new PathDrivenActorSpawnerComponent_SetValue PocoInterface;

		// Token: 0x04001EF9 RID: 7929
		private IIntervalSplineSpawn _SpawnRuleCache;

		// Token: 0x04001EFA RID: 7930
		private bool _SpawnRuleInited;
	}
}
