using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000893 RID: 2195
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMovementComponent : IComponentBase
	{
		// Token: 0x060030F5 RID: 12533 RVA: 0x0007DE60 File Offset: 0x0007C060
		[NullableContext(1)]
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

		// Token: 0x060030F6 RID: 12534 RVA: 0x0007DE98 File Offset: 0x0007C098
		[NullableContext(1)]
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

		// Token: 0x060030F7 RID: 12535 RVA: 0x0007DEAB File Offset: 0x0007C0AB
		[NullableContext(1)]
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

		// Token: 0x060030F8 RID: 12536 RVA: 0x0007DEBE File Offset: 0x0007C0BE
		[NullableContext(1)]
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

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x0007DEF8 File Offset: 0x0007C0F8
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x0007DF32 File Offset: 0x0007C132
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

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x0007DF40 File Offset: 0x0007C140
		// (set) Token: 0x060030FC RID: 12540 RVA: 0x0007DF6A File Offset: 0x0007C16A
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

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x0007DF78 File Offset: 0x0007C178
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x0007DFD9 File Offset: 0x0007C1D9
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

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x0007DFF0 File Offset: 0x0007C1F0
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x0007E051 File Offset: 0x0007C251
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

		// Token: 0x04002033 RID: 8243
		protected new SceneItemMovementComponent FbInstance;

		// Token: 0x04002034 RID: 8244
		protected new SceneItemMovementComponent_SetValue PocoInterface;

		// Token: 0x04002035 RID: 8245
		[Nullable(1)]
		private ISplineMove _PatrolCache;

		// Token: 0x04002036 RID: 8246
		private bool _PatrolInited;

		// Token: 0x04002037 RID: 8247
		[Nullable(1)]
		private IMovementPlatformConfig _PlatformConfigCache;

		// Token: 0x04002038 RID: 8248
		private bool _PlatformConfigInited;
	}
}
