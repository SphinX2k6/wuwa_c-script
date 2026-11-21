using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282F RID: 10287
	public class IVisualNovelPerformanceSwitchAudioState : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E4FF RID: 58623 RVA: 0x0021D6DE File Offset: 0x0021B8DE
		public static IVisualNovelPerformanceSwitchAudioState Create(IVisualNovelPerformanceSwitchAudioState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSwitchAudioState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x0600E500 RID: 58624 RVA: 0x0021D6FD File Offset: 0x0021B8FD
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x0600E501 RID: 58625 RVA: 0x0021D70C File Offset: 0x0021B90C
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

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x0600E502 RID: 58626 RVA: 0x0021D742 File Offset: 0x0021B942
		public virtual IAudioState AudioState
		{
			get
			{
				if (this._AudioStateInited)
				{
					return this._AudioStateCache;
				}
				this._AudioStateInited = true;
				this._AudioStateCache = IAudioState.Create(this.Instance.AudioState);
				return this._AudioStateCache;
			}
		}

		// Token: 0x04007DA9 RID: 32169
		private IVisualNovelPerformanceSwitchAudioState Instance;

		// Token: 0x04007DAA RID: 32170
		[Nullable(2)]
		private IAudioState _AudioStateCache;

		// Token: 0x04007DAB RID: 32171
		private bool _AudioStateInited;
	}
}
