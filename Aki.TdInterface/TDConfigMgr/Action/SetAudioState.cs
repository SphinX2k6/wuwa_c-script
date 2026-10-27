using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200219D RID: 8605
	[NullableContext(1)]
	[Nullable(0)]
	public class SetAudioState : ActionParams
	{
		// Token: 0x0600BCFE RID: 48382 RVA: 0x001B3698 File Offset: 0x001B1898
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

		// Token: 0x0600BCFF RID: 48383 RVA: 0x001B36D0 File Offset: 0x001B18D0
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

		// Token: 0x0600BD00 RID: 48384 RVA: 0x001B36E3 File Offset: 0x001B18E3
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

		// Token: 0x0600BD01 RID: 48385 RVA: 0x001B36F6 File Offset: 0x001B18F6
		public SetAudioState_SetValue ToSetValue()
		{
			return new SetAudioState_SetValue
			{
				AudioConfig = this.AudioConfig
			};
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600BD02 RID: 48386 RVA: 0x001B370C File Offset: 0x001B190C
		// (set) Token: 0x0600BD03 RID: 48387 RVA: 0x001B376D File Offset: 0x001B196D
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

		// Token: 0x040070CD RID: 28877
		[Nullable(2)]
		protected new SetAudioState FbInstance;

		// Token: 0x040070CE RID: 28878
		[Nullable(2)]
		protected SetAudioState_SetValue PocoInterface;

		// Token: 0x040070CF RID: 28879
		private IAudioState _AudioConfigCache;

		// Token: 0x040070D0 RID: 28880
		private bool _AudioConfigInited;
	}
}
