using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002406 RID: 9222
	public class SetAudioEnable : ActionParams
	{
		// Token: 0x0600C8AE RID: 51374 RVA: 0x001CAB90 File Offset: 0x001C8D90
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

		// Token: 0x0600C8AF RID: 51375 RVA: 0x001CABC8 File Offset: 0x001C8DC8
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

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x001CABDB File Offset: 0x001C8DDB
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

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x001CABEE File Offset: 0x001C8DEE
		public SetAudioEnable_SetValue ToSetValue()
		{
			return new SetAudioEnable_SetValue
			{
				SetAudioEnableType = this.SetAudioEnableType,
				AudioType = this.AudioType
			};
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0600C8B2 RID: 51378 RVA: 0x001CAC0D File Offset: 0x001C8E0D
		// (set) Token: 0x0600C8B3 RID: 51379 RVA: 0x001CAC38 File Offset: 0x001C8E38
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

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0600C8B4 RID: 51380 RVA: 0x001CAC48 File Offset: 0x001C8E48
		// (set) Token: 0x0600C8B5 RID: 51381 RVA: 0x001CACA9 File Offset: 0x001C8EA9
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

		// Token: 0x0400770F RID: 30479
		[Nullable(2)]
		protected new SetAudioEnable FbInstance;

		// Token: 0x04007710 RID: 30480
		[Nullable(2)]
		protected SetAudioEnable_SetValue PocoInterface;

		// Token: 0x04007711 RID: 30481
		private IRoleSceneVoice _AudioTypeCache;

		// Token: 0x04007712 RID: 30482
		private bool _AudioTypeInited;
	}
}
