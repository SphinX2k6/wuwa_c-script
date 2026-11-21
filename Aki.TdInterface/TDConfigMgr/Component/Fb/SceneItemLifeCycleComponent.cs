using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB8 RID: 3256
	public class SceneItemLifeCycleComponent : IComponentBase
	{
		// Token: 0x06004A5F RID: 19039 RVA: 0x000BB13E File Offset: 0x000B933E
		public static SceneItemLifeCycleComponent Create(ISceneItemLifeCycleComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemLifeCycleComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06004A60 RID: 19040 RVA: 0x000BB160 File Offset: 0x000B9360
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

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x000BB198 File Offset: 0x000B9398
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06004A62 RID: 19042 RVA: 0x000BB1AE File Offset: 0x000B93AE
		public virtual ICreateStageConfig CreateStageConfig
		{
			get
			{
				if (this._CreateStageConfigInited)
				{
					return this._CreateStageConfigCache;
				}
				this._CreateStageConfigInited = true;
				this._CreateStageConfigCache = ICreateStageConfig.Create(this.Instance.CreateStageConfig);
				return this._CreateStageConfigCache;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06004A63 RID: 19043 RVA: 0x000BB1E2 File Offset: 0x000B93E2
		public virtual IDestroyStageConfig DestroyStageConfig
		{
			get
			{
				if (this._DestroyStageConfigInited)
				{
					return this._DestroyStageConfigCache;
				}
				this._DestroyStageConfigInited = true;
				this._DestroyStageConfigCache = IDestroyStageConfig.Create(this.Instance.DestroyStageConfig);
				return this._DestroyStageConfigCache;
			}
		}

		// Token: 0x04002A25 RID: 10789
		private ISceneItemLifeCycleComponent Instance;

		// Token: 0x04002A26 RID: 10790
		[Nullable(2)]
		private ICreateStageConfig _CreateStageConfigCache;

		// Token: 0x04002A27 RID: 10791
		private bool _CreateStageConfigInited;

		// Token: 0x04002A28 RID: 10792
		[Nullable(2)]
		private IDestroyStageConfig _DestroyStageConfigCache;

		// Token: 0x04002A29 RID: 10793
		private bool _DestroyStageConfigInited;
	}
}
