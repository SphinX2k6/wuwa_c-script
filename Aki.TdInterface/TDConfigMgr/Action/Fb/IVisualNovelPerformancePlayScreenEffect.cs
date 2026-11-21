using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282A RID: 10282
	public class IVisualNovelPerformancePlayScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E4E6 RID: 58598 RVA: 0x0021D40D File Offset: 0x0021B60D
		public static IVisualNovelPerformancePlayScreenEffect Create(IVisualNovelPerformancePlayScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformancePlayScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x0600E4E7 RID: 58599 RVA: 0x0021D42C File Offset: 0x0021B62C
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x0600E4E8 RID: 58600 RVA: 0x0021D43C File Offset: 0x0021B63C
		public override float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x0600E4E9 RID: 58601 RVA: 0x0021D472 File Offset: 0x0021B672
		public virtual IVisualNovelPlayScreenEffectConfigBase EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				this._EffectConfigCache = ActionReadHelper.ReadIVisualNovelPerformancePlayScreenEffect_EffectConfig(this.Instance);
				return this._EffectConfigCache;
			}
		}

		// Token: 0x04007DA0 RID: 32160
		private IVisualNovelPerformancePlayScreenEffect Instance;

		// Token: 0x04007DA1 RID: 32161
		private IVisualNovelPlayScreenEffectConfigBase _EffectConfigCache;

		// Token: 0x04007DA2 RID: 32162
		private bool _EffectConfigInited;
	}
}
