using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002581 RID: 9601
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceSwitchAudioState : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D785 RID: 55173 RVA: 0x002019AA File Offset: 0x001FFBAA
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

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600D786 RID: 55174 RVA: 0x002019C9 File Offset: 0x001FFBC9
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0600D787 RID: 55175 RVA: 0x002019D8 File Offset: 0x001FFBD8
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

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x0600D788 RID: 55176 RVA: 0x00201A0E File Offset: 0x001FFC0E
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

		// Token: 0x04007743 RID: 30531
		private IVisualNovelPerformanceSwitchAudioState Instance;

		// Token: 0x04007744 RID: 30532
		[Nullable(2)]
		private IAudioState _AudioStateCache;

		// Token: 0x04007745 RID: 30533
		private bool _AudioStateInited;
	}
}
