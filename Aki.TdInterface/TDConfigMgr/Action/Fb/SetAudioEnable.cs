using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC0 RID: 10944
	[NullableContext(1)]
	[Nullable(0)]
	public class SetAudioEnable : ActionParams
	{
		// Token: 0x0600F02B RID: 61483 RVA: 0x0022E211 File Offset: 0x0022C411
		public static SetAudioEnable Create(ISetAudioEnable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAudioEnable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x0600F02C RID: 61484 RVA: 0x0022E230 File Offset: 0x0022C430
		public virtual EAudioEnableType SetAudioEnableType
		{
			get
			{
				return (EAudioEnableType)this.Instance.SetAudioEnableType;
			}
		}

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x0600F02D RID: 61485 RVA: 0x0022E23D File Offset: 0x0022C43D
		public virtual IRoleSceneVoice AudioType
		{
			get
			{
				if (this._AudioTypeInited)
				{
					return this._AudioTypeCache;
				}
				this._AudioTypeInited = true;
				this._AudioTypeCache = IRoleSceneVoice.Create(this.Instance.AudioType);
				return this._AudioTypeCache;
			}
		}

		// Token: 0x0400841A RID: 33818
		private ISetAudioEnable Instance;

		// Token: 0x0400841B RID: 33819
		[Nullable(2)]
		private IRoleSceneVoice _AudioTypeCache;

		// Token: 0x0400841C RID: 33820
		private bool _AudioTypeInited;
	}
}
