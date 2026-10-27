using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABF RID: 10943
	public class IRoleSceneVoice : IAudioTypeBase
	{
		// Token: 0x0600F027 RID: 61479 RVA: 0x0022E1D0 File Offset: 0x0022C3D0
		[NullableContext(1)]
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

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x0600F028 RID: 61480 RVA: 0x0022E1EF File Offset: 0x0022C3EF
		public override EAudioType Type
		{
			get
			{
				return (EAudioType)this.Instance.Type;
			}
		}

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x0600F029 RID: 61481 RVA: 0x0022E1FC File Offset: 0x0022C3FC
		public virtual int VoiceGroupData
		{
			get
			{
				return this.Instance.VoiceGroupData;
			}
		}

		// Token: 0x04008419 RID: 33817
		private IRoleSceneVoice Instance;
	}
}
