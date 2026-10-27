using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000891 RID: 2193
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemLifeCycleComponent : IComponentBase
	{
		// Token: 0x060030E7 RID: 12519 RVA: 0x0007DC48 File Offset: 0x0007BE48
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

		// Token: 0x060030E8 RID: 12520 RVA: 0x0007DC80 File Offset: 0x0007BE80
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

		// Token: 0x060030E9 RID: 12521 RVA: 0x0007DC93 File Offset: 0x0007BE93
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

		// Token: 0x060030EA RID: 12522 RVA: 0x0007DCA6 File Offset: 0x0007BEA6
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

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x0007DCE0 File Offset: 0x0007BEE0
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x0007DD1A File Offset: 0x0007BF1A
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

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x0007DD28 File Offset: 0x0007BF28
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x0007DD52 File Offset: 0x0007BF52
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

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x0007DD60 File Offset: 0x0007BF60
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x0007DDC1 File Offset: 0x0007BFC1
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

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x0007DDD8 File Offset: 0x0007BFD8
		// (set) Token: 0x060030F2 RID: 12530 RVA: 0x0007DE39 File Offset: 0x0007C039
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

		// Token: 0x04002029 RID: 8233
		[Nullable(2)]
		protected new SceneItemLifeCycleComponent FbInstance;

		// Token: 0x0400202A RID: 8234
		[Nullable(2)]
		protected new SceneItemLifeCycleComponent_SetValue PocoInterface;

		// Token: 0x0400202B RID: 8235
		private ICreateStageConfig _CreateStageConfigCache;

		// Token: 0x0400202C RID: 8236
		private bool _CreateStageConfigInited;

		// Token: 0x0400202D RID: 8237
		private IDestroyStageConfig _DestroyStageConfigCache;

		// Token: 0x0400202E RID: 8238
		private bool _DestroyStageConfigInited;
	}
}
