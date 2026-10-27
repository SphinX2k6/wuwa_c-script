using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE9 RID: 3049
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemLifeCycleComponent : IComponentBase
	{
		// Token: 0x06004601 RID: 17921 RVA: 0x000B0FC2 File Offset: 0x000AF1C2
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

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x000B0FE4 File Offset: 0x000AF1E4
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

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06004603 RID: 17923 RVA: 0x000B101C File Offset: 0x000AF21C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06004604 RID: 17924 RVA: 0x000B1032 File Offset: 0x000AF232
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

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06004605 RID: 17925 RVA: 0x000B1066 File Offset: 0x000AF266
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

		// Token: 0x040027DA RID: 10202
		private ISceneItemLifeCycleComponent Instance;

		// Token: 0x040027DB RID: 10203
		[Nullable(2)]
		private ICreateStageConfig _CreateStageConfigCache;

		// Token: 0x040027DC RID: 10204
		private bool _CreateStageConfigInited;

		// Token: 0x040027DD RID: 10205
		[Nullable(2)]
		private IDestroyStageConfig _DestroyStageConfigCache;

		// Token: 0x040027DE RID: 10206
		private bool _DestroyStageConfigInited;
	}
}
