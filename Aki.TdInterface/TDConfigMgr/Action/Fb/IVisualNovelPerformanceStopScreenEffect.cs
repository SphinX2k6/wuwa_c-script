using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282D RID: 10285
	public class IVisualNovelPerformanceStopScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E4F2 RID: 58610 RVA: 0x0021D51E File Offset: 0x0021B71E
		public static IVisualNovelPerformanceStopScreenEffect Create(IVisualNovelPerformanceStopScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceStopScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x0600E4F3 RID: 58611 RVA: 0x0021D53D File Offset: 0x0021B73D
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x0600E4F4 RID: 58612 RVA: 0x0021D54C File Offset: 0x0021B74C
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

		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x0600E4F5 RID: 58613 RVA: 0x0021D582 File Offset: 0x0021B782
		public virtual IVisualNovelStopScreenEffectPersistent EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				this._EffectConfigCache = IVisualNovelStopScreenEffectPersistent.Create(this.Instance.EffectConfig);
				return this._EffectConfigCache;
			}
		}

		// Token: 0x04007DA5 RID: 32165
		private IVisualNovelPerformanceStopScreenEffect Instance;

		// Token: 0x04007DA6 RID: 32166
		[Nullable(2)]
		private IVisualNovelStopScreenEffectPersistent _EffectConfigCache;

		// Token: 0x04007DA7 RID: 32167
		private bool _EffectConfigInited;
	}
}
