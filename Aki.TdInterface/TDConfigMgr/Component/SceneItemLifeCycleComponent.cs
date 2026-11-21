using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000934 RID: 2356
	public class SceneItemLifeCycleComponent : IComponentBase
	{
		// Token: 0x06003423 RID: 13347 RVA: 0x00085130 File Offset: 0x00083330
		private SceneItemLifeCycleComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SceneItemLifeCycleComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SceneItemLifeCycleComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SceneItemLifeCycleComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00085168 File Offset: 0x00083368
		public static SceneItemLifeCycleComponent Create([Nullable(2)] SceneItemLifeCycleComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemLifeCycleComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x0008517B File Offset: 0x0008337B
		public static SceneItemLifeCycleComponent CreateFromSetValue([Nullable(2)] SceneItemLifeCycleComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SceneItemLifeCycleComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x0008518E File Offset: 0x0008338E
		public new SceneItemLifeCycleComponent_SetValue ToSetValue()
		{
			return new SceneItemLifeCycleComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				CreateStageConfig = this.CreateStageConfig,
				DestroyStageConfig = this.DestroyStageConfig
			};
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x000851C8 File Offset: 0x000833C8
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x00085202 File Offset: 0x00083402
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SceneItemLifeCycleComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x00085210 File Offset: 0x00083410
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x0008523A File Offset: 0x0008343A
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

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x00085248 File Offset: 0x00083448
		// (set) Token: 0x0600342C RID: 13356 RVA: 0x000852A9 File Offset: 0x000834A9
		public virtual ICreateStageConfig CreateStageConfig
		{
			get
			{
				if (this._CreateStageConfigInited)
				{
					return this._CreateStageConfigCache;
				}
				this._CreateStageConfigInited = true;
				if (this.FbInstance != null)
				{
					this._CreateStageConfigCache = ICreateStageConfig.Create(this.FbInstance.CreateStageConfig);
				}
				else
				{
					SceneItemLifeCycleComponent_SetValue pocoInterface = this.PocoInterface;
					this._CreateStageConfigCache = ((pocoInterface != null) ? pocoInterface.CreateStageConfig : null);
				}
				return this._CreateStageConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().CreateStageConfig = value;
				this._CreateStageConfigInited = false;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x000852C0 File Offset: 0x000834C0
		// (set) Token: 0x0600342E RID: 13358 RVA: 0x00085321 File Offset: 0x00083521
		public virtual IDestroyStageConfig DestroyStageConfig
		{
			get
			{
				if (this._DestroyStageConfigInited)
				{
					return this._DestroyStageConfigCache;
				}
				this._DestroyStageConfigInited = true;
				if (this.FbInstance != null)
				{
					this._DestroyStageConfigCache = IDestroyStageConfig.Create(this.FbInstance.DestroyStageConfig);
				}
				else
				{
					SceneItemLifeCycleComponent_SetValue pocoInterface = this.PocoInterface;
					this._DestroyStageConfigCache = ((pocoInterface != null) ? pocoInterface.DestroyStageConfig : null);
				}
				return this._DestroyStageConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().DestroyStageConfig = value;
				this._DestroyStageConfigInited = false;
			}
		}

		// Token: 0x0400223B RID: 8763
		[Nullable(2)]
		protected new SceneItemLifeCycleComponent FbInstance;

		// Token: 0x0400223C RID: 8764
		[Nullable(2)]
		protected new SceneItemLifeCycleComponent_SetValue PocoInterface;

		// Token: 0x0400223D RID: 8765
		private ICreateStageConfig _CreateStageConfigCache;

		// Token: 0x0400223E RID: 8766
		private bool _CreateStageConfigInited;

		// Token: 0x0400223F RID: 8767
		private IDestroyStageConfig _DestroyStageConfigCache;

		// Token: 0x04002240 RID: 8768
		private bool _DestroyStageConfigInited;
	}
}
