using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A12 RID: 23058
	public class IIntervalSplineSpawnAudioConfigBase_UnionUnion
	{
		// Token: 0x1700A798 RID: 42904
		// (get) Token: 0x06025A97 RID: 154263 RVA: 0x00529C39 File Offset: 0x00527E39
		// (set) Token: 0x06025A98 RID: 154264 RVA: 0x00529C41 File Offset: 0x00527E41
		public IIntervalSplineSpawnAudioConfigBase_Union Type { get; set; }

		// Token: 0x1700A799 RID: 42905
		// (get) Token: 0x06025A99 RID: 154265 RVA: 0x00529C4A File Offset: 0x00527E4A
		// (set) Token: 0x06025A9A RID: 154266 RVA: 0x00529C52 File Offset: 0x00527E52
		public object Value { get; set; }

		// Token: 0x06025A9B RID: 154267 RVA: 0x00529C5B File Offset: 0x00527E5B
		public IIntervalSplineSpawnAudioConfigBase_UnionUnion()
		{
			this.Type = IIntervalSplineSpawnAudioConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025A9C RID: 154268 RVA: 0x00529C71 File Offset: 0x00527E71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025A9D RID: 154269 RVA: 0x00529C83 File Offset: 0x00527E83
		public IIntervalSplineSpawnAudioConfigBaseT AsIIntervalSplineSpawnAudioConfigBase()
		{
			return this.As<IIntervalSplineSpawnAudioConfigBaseT>();
		}

		// Token: 0x06025A9E RID: 154270 RVA: 0x00529C8B File Offset: 0x00527E8B
		public static IIntervalSplineSpawnAudioConfigBase_UnionUnion FromIIntervalSplineSpawnAudioConfigBase(IIntervalSplineSpawnAudioConfigBaseT _iintervalsplinespawnaudioconfigbase)
		{
			return new IIntervalSplineSpawnAudioConfigBase_UnionUnion
			{
				Type = IIntervalSplineSpawnAudioConfigBase_Union.IIntervalSplineSpawnAudioConfigBase,
				Value = _iintervalsplinespawnaudioconfigbase
			};
		}

		// Token: 0x06025A9F RID: 154271 RVA: 0x00529CA0 File Offset: 0x00527EA0
		public IIntervalSplineSpawnAllActorAudioT AsIIntervalSplineSpawnAllActorAudio()
		{
			return this.As<IIntervalSplineSpawnAllActorAudioT>();
		}

		// Token: 0x06025AA0 RID: 154272 RVA: 0x00529CA8 File Offset: 0x00527EA8
		public static IIntervalSplineSpawnAudioConfigBase_UnionUnion FromIIntervalSplineSpawnAllActorAudio(IIntervalSplineSpawnAllActorAudioT _iintervalsplinespawnallactoraudio)
		{
			return new IIntervalSplineSpawnAudioConfigBase_UnionUnion
			{
				Type = IIntervalSplineSpawnAudioConfigBase_Union.IIntervalSplineSpawnAllActorAudio,
				Value = _iintervalsplinespawnallactoraudio
			};
		}

		// Token: 0x06025AA1 RID: 154273 RVA: 0x00529CC0 File Offset: 0x00527EC0
		public static int Pack(FlatBufferBuilder builder, IIntervalSplineSpawnAudioConfigBase_UnionUnion _o)
		{
			IIntervalSplineSpawnAudioConfigBase_Union type = _o.Type;
			if (type == IIntervalSplineSpawnAudioConfigBase_Union.IIntervalSplineSpawnAudioConfigBase)
			{
				return IIntervalSplineSpawnAudioConfigBase.Pack(builder, _o.AsIIntervalSplineSpawnAudioConfigBase()).Value;
			}
			if (type != IIntervalSplineSpawnAudioConfigBase_Union.IIntervalSplineSpawnAllActorAudio)
			{
				return 0;
			}
			return IIntervalSplineSpawnAllActorAudio.Pack(builder, _o.AsIIntervalSplineSpawnAllActorAudio()).Value;
		}
	}
}
