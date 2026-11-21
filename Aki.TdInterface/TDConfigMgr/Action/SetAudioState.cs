using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002408 RID: 9224
	public class SetAudioState : ActionParams
	{
		// Token: 0x0600C8B8 RID: 51384 RVA: 0x001CACD0 File Offset: 0x001C8ED0
		private SetAudioState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetAudioState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetAudioState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetAudioState_SetValue());
			}
			return result;
		}

		// Token: 0x0600C8B9 RID: 51385 RVA: 0x001CAD08 File Offset: 0x001C8F08
		public static SetAudioState Create([Nullable(2)] SetAudioState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAudioState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C8BA RID: 51386 RVA: 0x001CAD1B File Offset: 0x001C8F1B
		public static SetAudioState CreateFromSetValue([Nullable(2)] SetAudioState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetAudioState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C8BB RID: 51387 RVA: 0x001CAD2E File Offset: 0x001C8F2E
		public SetAudioState_SetValue ToSetValue()
		{
			return new SetAudioState_SetValue
			{
				AudioConfig = this.AudioConfig
			};
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0600C8BC RID: 51388 RVA: 0x001CAD44 File Offset: 0x001C8F44
		// (set) Token: 0x0600C8BD RID: 51389 RVA: 0x001CADA5 File Offset: 0x001C8FA5
		public virtual IAudioState AudioConfig
		{
			get
			{
				if (this._AudioConfigInited)
				{
					return this._AudioConfigCache;
				}
				this._AudioConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AudioConfigCache = IAudioState.Create(this.FbInstance.AudioConfig);
				}
				else
				{
					SetAudioState_SetValue pocoInterface = this.PocoInterface;
					this._AudioConfigCache = ((pocoInterface != null) ? pocoInterface.AudioConfig : null);
				}
				return this._AudioConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().AudioConfig = value;
				this._AudioConfigInited = false;
			}
		}

		// Token: 0x04007715 RID: 30485
		[Nullable(2)]
		protected new SetAudioState FbInstance;

		// Token: 0x04007716 RID: 30486
		[Nullable(2)]
		protected SetAudioState_SetValue PocoInterface;

		// Token: 0x04007717 RID: 30487
		private IAudioState _AudioConfigCache;

		// Token: 0x04007718 RID: 30488
		private bool _AudioConfigInited;
	}
}
