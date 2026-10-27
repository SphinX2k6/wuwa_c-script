using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548C RID: 21644
	public class IIntervalSplineSpawnAudioConfigBase_UnionUnion
	{
		// Token: 0x17009F5E RID: 40798
		// (get) Token: 0x060239DF RID: 145887 RVA: 0x004ECBC5 File Offset: 0x004EADC5
		// (set) Token: 0x060239E0 RID: 145888 RVA: 0x004ECBCD File Offset: 0x004EADCD
		public IIntervalSplineSpawnAudioConfigBase_Union Type { get; set; }

		// Token: 0x17009F5F RID: 40799
		// (get) Token: 0x060239E1 RID: 145889 RVA: 0x004ECBD6 File Offset: 0x004EADD6
		// (set) Token: 0x060239E2 RID: 145890 RVA: 0x004ECBDE File Offset: 0x004EADDE
		public object Value { get; set; }

		// Token: 0x060239E3 RID: 145891 RVA: 0x004ECBE7 File Offset: 0x004EADE7
		public IIntervalSplineSpawnAudioConfigBase_UnionUnion()
		{
			this.Type = IIntervalSplineSpawnAudioConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060239E4 RID: 145892 RVA: 0x004ECBFD File Offset: 0x004EADFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060239E5 RID: 145893 RVA: 0x004ECC0F File Offset: 0x004EAE0F
		public IIntervalSplineSpawnAudioConfigBaseT AsIIntervalSplineSpawnAudioConfigBase()
		{
			return this.As<IIntervalSplineSpawnAudioConfigBaseT>();
		}

		// Token: 0x060239E6 RID: 145894 RVA: 0x004ECC17 File Offset: 0x004EAE17
		public static IIntervalSplineSpawnAudioConfigBase_UnionUnion FromIIntervalSplineSpawnAudioConfigBase(IIntervalSplineSpawnAudioConfigBaseT _iintervalsplinespawnaudioconfigbase)
		{
			return new IIntervalSplineSpawnAudioConfigBase_UnionUnion
			{
				Type = IIntervalSplineSpawnAudioConfigBase_Union.IIntervalSplineSpawnAudioConfigBase,
				Value = _iintervalsplinespawnaudioconfigbase
			};
		}

		// Token: 0x060239E7 RID: 145895 RVA: 0x004ECC2C File Offset: 0x004EAE2C
		public IIntervalSplineSpawnAllActorAudioT AsIIntervalSplineSpawnAllActorAudio()
		{
			return this.As<IIntervalSplineSpawnAllActorAudioT>();
		}

		// Token: 0x060239E8 RID: 145896 RVA: 0x004ECC34 File Offset: 0x004EAE34
		public static IIntervalSplineSpawnAudioConfigBase_UnionUnion FromIIntervalSplineSpawnAllActorAudio(IIntervalSplineSpawnAllActorAudioT _iintervalsplinespawnallactoraudio)
		{
			return new IIntervalSplineSpawnAudioConfigBase_UnionUnion
			{
				Type = IIntervalSplineSpawnAudioConfigBase_Union.IIntervalSplineSpawnAllActorAudio,
				Value = _iintervalsplinespawnallactoraudio
			};
		}

		// Token: 0x060239E9 RID: 145897 RVA: 0x004ECC4C File Offset: 0x004EAE4C
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
