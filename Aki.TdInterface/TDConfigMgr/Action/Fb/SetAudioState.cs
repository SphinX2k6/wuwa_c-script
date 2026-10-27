using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298A RID: 10634
	[NullableContext(1)]
	[Nullable(0)]
	public class SetAudioState : ActionParams
	{
		// Token: 0x0600EB80 RID: 60288 RVA: 0x002271C9 File Offset: 0x002253C9
		public static SetAudioState Create(ISetAudioState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAudioState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x0600EB81 RID: 60289 RVA: 0x002271E8 File Offset: 0x002253E8
		public virtual IAudioState AudioConfig
		{
			get
			{
				if (this._AudioConfigInited)
				{
					return this._AudioConfigCache;
				}
				this._AudioConfigInited = true;
				this._AudioConfigCache = IAudioState.Create(this.Instance.AudioConfig);
				return this._AudioConfigCache;
			}
		}

		// Token: 0x040081B2 RID: 33202
		private ISetAudioState Instance;

		// Token: 0x040081B3 RID: 33203
		[Nullable(2)]
		private IAudioState _AudioConfigCache;

		// Token: 0x040081B4 RID: 33204
		private bool _AudioConfigInited;
	}
}
