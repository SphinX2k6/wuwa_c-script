using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000337 RID: 823
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityStateAudioConfig
	{
		// Token: 0x06001036 RID: 4150 RVA: 0x00038544 File Offset: 0x00036744
		private IEntityStateAudioConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityStateAudioConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityStateAudioConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityStateAudioConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0003857C File Offset: 0x0003677C
		public static IEntityStateAudioConfig Create([Nullable(2)] IEntityStateAudioConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityStateAudioConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0003858F File Offset: 0x0003678F
		public static IEntityStateAudioConfig CreateFromSetValue([Nullable(2)] IEntityStateAudioConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityStateAudioConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x000385A4 File Offset: 0x000367A4
		public IEntityStateAudioConfig_SetValue ToSetValue()
		{
			return new IEntityStateAudioConfig_SetValue
			{
				State = this.State,
				AkEvent = this.AkEvent,
				LeaveAkEvent = this.LeaveAkEvent,
				AudioFade = this.AudioFade,
				IsBanVehicleRadio = this.IsBanVehicleRadio
			};
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x000385F2 File Offset: 0x000367F2
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x0003861D File Offset: 0x0003681D
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0003862B File Offset: 0x0003682B
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00038656 File Offset: 0x00036856
		public virtual string AkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AkEvent;
			}
			set
			{
				this.GetOrCreatePoco().AkEvent = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00038664 File Offset: 0x00036864
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x0003868B File Offset: 0x0003688B
		[Nullable(2)]
		public virtual string LeaveAkEvent
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveAkEvent;
				}
				IEntityStateAudioConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LeaveAkEvent;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().LeaveAkEvent = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0003869C File Offset: 0x0003689C
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x000386FD File Offset: 0x000368FD
		[Nullable(2)]
		public virtual IAudioFade AudioFade
		{
			[NullableContext(2)]
			get
			{
				if (this._AudioFadeInited)
				{
					return this._AudioFadeCache;
				}
				this._AudioFadeInited = true;
				if (this.FbInstance != null)
				{
					this._AudioFadeCache = IAudioFade.Create(this.FbInstance.AudioFade);
				}
				else
				{
					IEntityStateAudioConfig_SetValue pocoInterface = this.PocoInterface;
					this._AudioFadeCache = ((pocoInterface != null) ? pocoInterface.AudioFade : null);
				}
				return this._AudioFadeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AudioFade = value;
				this._AudioFadeInited = false;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00038714 File Offset: 0x00036914
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x0003874E File Offset: 0x0003694E
		public virtual bool? IsBanVehicleRadio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsBanVehicleRadio;
				}
				IEntityStateAudioConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsBanVehicleRadio;
			}
			set
			{
				this.GetOrCreatePoco().IsBanVehicleRadio = value;
			}
		}

		// Token: 0x04000DA6 RID: 3494
		[Nullable(2)]
		protected IEntityStateAudioConfig FbInstance;

		// Token: 0x04000DA7 RID: 3495
		[Nullable(2)]
		protected IEntityStateAudioConfig_SetValue PocoInterface;

		// Token: 0x04000DA8 RID: 3496
		private IAudioFade _AudioFadeCache;

		// Token: 0x04000DA9 RID: 3497
		private bool _AudioFadeInited;
	}
}
