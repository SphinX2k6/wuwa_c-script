using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E73 RID: 3699
	public class SceneItemAiComponent : IComponentBase
	{
		// Token: 0x06005394 RID: 21396 RVA: 0x000CE1CD File Offset: 0x000CC3CD
		public static SceneItemAiComponent Create(ISceneItemAiComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemAiComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06005395 RID: 21397 RVA: 0x000CE1EC File Offset: 0x000CC3EC
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

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x000CE224 File Offset: 0x000CC424
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06005397 RID: 21399 RVA: 0x000CE23A File Offset: 0x000CC43A
		public virtual ISceneItemPatrol AiConfig
		{
			get
			{
				if (this._AiConfigInited)
				{
					return this._AiConfigCache;
				}
				this._AiConfigInited = true;
				this._AiConfigCache = ISceneItemPatrol.Create(this.Instance.AiConfig);
				return this._AiConfigCache;
			}
		}

		// Token: 0x04002FCC RID: 12236
		private ISceneItemAiComponent Instance;

		// Token: 0x04002FCD RID: 12237
		[Nullable(2)]
		private ISceneItemPatrol _AiConfigCache;

		// Token: 0x04002FCE RID: 12238
		private bool _AiConfigInited;
	}
}
