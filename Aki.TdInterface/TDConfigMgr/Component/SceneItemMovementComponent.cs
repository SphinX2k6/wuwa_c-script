using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000936 RID: 2358
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMovementComponent : IComponentBase
	{
		// Token: 0x06003431 RID: 13361 RVA: 0x00085348 File Offset: 0x00083548
		[NullableContext(0)]
		private SceneItemMovementComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SceneItemMovementComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SceneItemMovementComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SceneItemMovementComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00085380 File Offset: 0x00083580
		[NullableContext(0)]
		public static SceneItemMovementComponent Create([Nullable(2)] SceneItemMovementComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemMovementComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00085393 File Offset: 0x00083593
		[NullableContext(0)]
		public static SceneItemMovementComponent CreateFromSetValue([Nullable(2)] SceneItemMovementComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SceneItemMovementComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x000853A6 File Offset: 0x000835A6
		[NullableContext(0)]
		public new SceneItemMovementComponent_SetValue ToSetValue()
		{
			return new SceneItemMovementComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Patrol = this.Patrol,
				PlatformConfig = this.PlatformConfig
			};
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06003435 RID: 13365 RVA: 0x000853E0 File Offset: 0x000835E0
		// (set) Token: 0x06003436 RID: 13366 RVA: 0x0008541A File Offset: 0x0008361A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SceneItemMovementComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x00085428 File Offset: 0x00083628
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x00085452 File Offset: 0x00083652
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

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x00085460 File Offset: 0x00083660
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x000854C1 File Offset: 0x000836C1
		public virtual ISplineMove Patrol
		{
			get
			{
				if (this._PatrolInited)
				{
					return this._PatrolCache;
				}
				this._PatrolInited = true;
				if (this.FbInstance != null)
				{
					this._PatrolCache = ISplineMove.Create(this.FbInstance.Patrol);
				}
				else
				{
					SceneItemMovementComponent_SetValue pocoInterface = this.PocoInterface;
					this._PatrolCache = ((pocoInterface != null) ? pocoInterface.Patrol : null);
				}
				return this._PatrolCache;
			}
			set
			{
				this.GetOrCreatePoco().Patrol = value;
				this._PatrolInited = false;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x000854D8 File Offset: 0x000836D8
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x00085539 File Offset: 0x00083739
		public virtual IMovementPlatformConfig PlatformConfig
		{
			get
			{
				if (this._PlatformConfigInited)
				{
					return this._PlatformConfigCache;
				}
				this._PlatformConfigInited = true;
				if (this.FbInstance != null)
				{
					this._PlatformConfigCache = IMovementPlatformConfig.Create(this.FbInstance.PlatformConfig);
				}
				else
				{
					SceneItemMovementComponent_SetValue pocoInterface = this.PocoInterface;
					this._PlatformConfigCache = ((pocoInterface != null) ? pocoInterface.PlatformConfig : null);
				}
				return this._PlatformConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PlatformConfig = value;
				this._PlatformConfigInited = false;
			}
		}

		// Token: 0x04002245 RID: 8773
		protected new SceneItemMovementComponent FbInstance;

		// Token: 0x04002246 RID: 8774
		protected new SceneItemMovementComponent_SetValue PocoInterface;

		// Token: 0x04002247 RID: 8775
		[Nullable(0)]
		private ISplineMove _PatrolCache;

		// Token: 0x04002248 RID: 8776
		private bool _PatrolInited;

		// Token: 0x04002249 RID: 8777
		[Nullable(0)]
		private IMovementPlatformConfig _PlatformConfigCache;

		// Token: 0x0400224A RID: 8778
		private bool _PlatformConfigInited;
	}
}
