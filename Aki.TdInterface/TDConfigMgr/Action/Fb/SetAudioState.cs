using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C70 RID: 11376
	public class SetAudioState : ActionParams
	{
		// Token: 0x0600F9FB RID: 63995 RVA: 0x00244921 File Offset: 0x00242B21
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

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x0600F9FC RID: 63996 RVA: 0x00244940 File Offset: 0x00242B40
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

		// Token: 0x04008896 RID: 34966
		private ISetAudioState Instance;

		// Token: 0x04008897 RID: 34967
		[Nullable(2)]
		private IAudioState _AudioConfigCache;

		// Token: 0x04008898 RID: 34968
		private bool _AudioConfigInited;
	}
}
