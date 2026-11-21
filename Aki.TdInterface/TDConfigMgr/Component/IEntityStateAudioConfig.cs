using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037E RID: 894
	public class IEntityStateAudioConfig
	{
		// Token: 0x06001168 RID: 4456 RVA: 0x0003B510 File Offset: 0x00039710
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

		// Token: 0x06001169 RID: 4457 RVA: 0x0003B548 File Offset: 0x00039748
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

		// Token: 0x0600116A RID: 4458 RVA: 0x0003B55B File Offset: 0x0003975B
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

		// Token: 0x0600116B RID: 4459 RVA: 0x0003B570 File Offset: 0x00039770
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0003B5BE File Offset: 0x000397BE
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x0003B5E9 File Offset: 0x000397E9
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0003B5F7 File Offset: 0x000397F7
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x0003B622 File Offset: 0x00039822
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0003B630 File Offset: 0x00039830
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x0003B657 File Offset: 0x00039857
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0003B668 File Offset: 0x00039868
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x0003B6C9 File Offset: 0x000398C9
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

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0003B6E0 File Offset: 0x000398E0
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x0003B71A File Offset: 0x0003991A
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

		// Token: 0x04000E91 RID: 3729
		[Nullable(2)]
		protected IEntityStateAudioConfig FbInstance;

		// Token: 0x04000E92 RID: 3730
		[Nullable(2)]
		protected IEntityStateAudioConfig_SetValue PocoInterface;

		// Token: 0x04000E93 RID: 3731
		private IAudioFade _AudioFadeCache;

		// Token: 0x04000E94 RID: 3732
		private bool _AudioFadeInited;
	}
}
