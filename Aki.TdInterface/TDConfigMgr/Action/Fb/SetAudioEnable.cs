using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB4 RID: 11700
	public class SetAudioEnable : ActionParams
	{
		// Token: 0x0600FEE1 RID: 65249 RVA: 0x0024BF1D File Offset: 0x0024A11D
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

		// Token: 0x17005027 RID: 20519
		// (get) Token: 0x0600FEE2 RID: 65250 RVA: 0x0024BF3C File Offset: 0x0024A13C
		public virtual EAudioEnableType SetAudioEnableType
		{
			get
			{
				return (EAudioEnableType)this.Instance.SetAudioEnableType;
			}
		}

		// Token: 0x17005028 RID: 20520
		// (get) Token: 0x0600FEE3 RID: 65251 RVA: 0x0024BF49 File Offset: 0x0024A149
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

		// Token: 0x04008B1E RID: 35614
		private ISetAudioEnable Instance;

		// Token: 0x04008B1F RID: 35615
		[Nullable(2)]
		private IRoleSceneVoice _AudioTypeCache;

		// Token: 0x04008B20 RID: 35616
		private bool _AudioTypeInited;
	}
}
