using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB3 RID: 11699
	public class IRoleSceneVoice : IAudioTypeBase
	{
		// Token: 0x0600FEDD RID: 65245 RVA: 0x0024BEDC File Offset: 0x0024A0DC
		public static IRoleSceneVoice Create(IRoleSceneVoice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleSceneVoice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005025 RID: 20517
		// (get) Token: 0x0600FEDE RID: 65246 RVA: 0x0024BEFB File Offset: 0x0024A0FB
		public override EAudioType Type
		{
			get
			{
				return (EAudioType)this.Instance.Type;
			}
		}

		// Token: 0x17005026 RID: 20518
		// (get) Token: 0x0600FEDF RID: 65247 RVA: 0x0024BF08 File Offset: 0x0024A108
		public virtual int VoiceGroupData
		{
			get
			{
				return this.Instance.VoiceGroupData;
			}
		}

		// Token: 0x04008B1D RID: 35613
		private IRoleSceneVoice Instance;
	}
}
