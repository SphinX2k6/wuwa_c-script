using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D77 RID: 3447
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemAiComponent : IComponentBase
	{
		// Token: 0x06004E6F RID: 20079 RVA: 0x000C297D File Offset: 0x000C0B7D
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

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06004E70 RID: 20080 RVA: 0x000C299C File Offset: 0x000C0B9C
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

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06004E71 RID: 20081 RVA: 0x000C29D4 File Offset: 0x000C0BD4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06004E72 RID: 20082 RVA: 0x000C29EA File Offset: 0x000C0BEA
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

		// Token: 0x04002D06 RID: 11526
		private ISceneItemAiComponent Instance;

		// Token: 0x04002D07 RID: 11527
		[Nullable(2)]
		private ISceneItemPatrol _AiConfigCache;

		// Token: 0x04002D08 RID: 11528
		private bool _AiConfigInited;
	}
}
