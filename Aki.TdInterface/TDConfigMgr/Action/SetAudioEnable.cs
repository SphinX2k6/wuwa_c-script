using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200219B RID: 8603
	[NullableContext(1)]
	[Nullable(0)]
	public class SetAudioEnable : ActionParams
	{
		// Token: 0x0600BCF4 RID: 48372 RVA: 0x001B3558 File Offset: 0x001B1758
		private SetAudioEnable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetAudioEnable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetAudioEnable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetAudioEnable_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x001B3590 File Offset: 0x001B1790
		public static SetAudioEnable Create([Nullable(2)] SetAudioEnable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAudioEnable
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x001B35A3 File Offset: 0x001B17A3
		public static SetAudioEnable CreateFromSetValue([Nullable(2)] SetAudioEnable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetAudioEnable
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x001B35B6 File Offset: 0x001B17B6
		public SetAudioEnable_SetValue ToSetValue()
		{
			return new SetAudioEnable_SetValue
			{
				SetAudioEnableType = this.SetAudioEnableType,
				AudioType = this.AudioType
			};
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x001B35D5 File Offset: 0x001B17D5
		// (set) Token: 0x0600BCF9 RID: 48377 RVA: 0x001B3600 File Offset: 0x001B1800
		public virtual EAudioEnableType SetAudioEnableType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetAudioEnableType;
				}
				if (this.PocoInterface == null)
				{
					return EAudioEnableType.Enable;
				}
				return this.PocoInterface.SetAudioEnableType;
			}
			set
			{
				this.GetOrCreatePoco().SetAudioEnableType = value;
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600BCFA RID: 48378 RVA: 0x001B3610 File Offset: 0x001B1810
		// (set) Token: 0x0600BCFB RID: 48379 RVA: 0x001B3671 File Offset: 0x001B1871
		public virtual IRoleSceneVoice AudioType
		{
			get
			{
				if (this._AudioTypeInited)
				{
					return this._AudioTypeCache;
				}
				this._AudioTypeInited = true;
				if (this.FbInstance != null)
				{
					this._AudioTypeCache = IRoleSceneVoice.Create(this.FbInstance.AudioType);
				}
				else
				{
					SetAudioEnable_SetValue pocoInterface = this.PocoInterface;
					this._AudioTypeCache = ((pocoInterface != null) ? pocoInterface.AudioType : null);
				}
				return this._AudioTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().AudioType = value;
				this._AudioTypeInited = false;
			}
		}

		// Token: 0x040070C7 RID: 28871
		[Nullable(2)]
		protected new SetAudioEnable FbInstance;

		// Token: 0x040070C8 RID: 28872
		[Nullable(2)]
		protected SetAudioEnable_SetValue PocoInterface;

		// Token: 0x040070C9 RID: 28873
		private IRoleSceneVoice _AudioTypeCache;

		// Token: 0x040070CA RID: 28874
		private bool _AudioTypeInited;
	}
}
