using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAB RID: 2987
	public class ITrafficAudioControl : IAudioControlType
	{
		// Token: 0x06004448 RID: 17480 RVA: 0x000AD265 File Offset: 0x000AB465
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

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x000AD284 File Offset: 0x000AB484
		public override EAudioControlType Type
		{
			get
			{
				return (EAudioControlType)this.Instance.Type;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600444A RID: 17482 RVA: 0x000AD291 File Offset: 0x000AB491
		public virtual string EngineAudio
		{
			get
			{
				return this.Instance.EngineAudio;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x000AD29E File Offset: 0x000AB49E
		public virtual string BrakingAudio
		{
			get
			{
				return this.Instance.BrakingAudio;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x000AD2AB File Offset: 0x000AB4AB
		public virtual string BrakingShortAudio
		{
			get
			{
				return this.Instance.BrakingShortAudio;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x000AD2B8 File Offset: 0x000AB4B8
		public virtual string HornAudio
		{
			get
			{
				return this.Instance.HornAudio;
			}
		}

		// Token: 0x040025CA RID: 9674
		private ITrafficAudioControl Instance;
	}
}
