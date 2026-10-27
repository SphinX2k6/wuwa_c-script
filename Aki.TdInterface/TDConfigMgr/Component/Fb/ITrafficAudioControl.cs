using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AE1 RID: 2785
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrafficAudioControl : IAudioControlType
	{
		// Token: 0x0600401E RID: 16414 RVA: 0x000A3C71 File Offset: 0x000A1E71
		public static ITrafficAudioControl Create(ITrafficAudioControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrafficAudioControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600401F RID: 16415 RVA: 0x000A3C90 File Offset: 0x000A1E90
		public override EAudioControlType Type
		{
			get
			{
				return (EAudioControlType)this.Instance.Type;
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x000A3C9D File Offset: 0x000A1E9D
		public virtual string EngineAudio
		{
			get
			{
				return this.Instance.EngineAudio;
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x000A3CAA File Offset: 0x000A1EAA
		public virtual string BrakingAudio
		{
			get
			{
				return this.Instance.BrakingAudio;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x000A3CB7 File Offset: 0x000A1EB7
		public virtual string BrakingShortAudio
		{
			get
			{
				return this.Instance.BrakingShortAudio;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06004023 RID: 16419 RVA: 0x000A3CC4 File Offset: 0x000A1EC4
		public virtual string HornAudio
		{
			get
			{
				return this.Instance.HornAudio;
			}
		}

		// Token: 0x040023AE RID: 9134
		private ITrafficAudioControl Instance;
	}
}
