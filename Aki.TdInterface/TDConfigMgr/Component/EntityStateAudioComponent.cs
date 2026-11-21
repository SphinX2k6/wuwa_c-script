using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200010C RID: 268
	public class EntityStateAudioComponent : EntityAudioComponent
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0001E12C File Offset: 0x0001C32C
		private EntityStateAudioComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityStateAudioComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityStateAudioComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityStateAudioComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001E164 File Offset: 0x0001C364
		public static EntityStateAudioComponent Create([Nullable(2)] EntityStateAudioComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityStateAudioComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001E177 File Offset: 0x0001C377
		public static EntityStateAudioComponent CreateFromSetValue([Nullable(2)] EntityStateAudioComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityStateAudioComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001E18C File Offset: 0x0001C38C
		public new EntityStateAudioComponent_SetValue ToSetValue()
		{
			return new EntityStateAudioComponent_SetValue
			{
				Disabled = this.Disabled,
				AkEventType = this.AkEventType,
				AudioRangeType = this.AudioRangeType,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0001E1DC File Offset: 0x0001C3DC
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0001E216 File Offset: 0x0001C416
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityStateAudioComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001E224 File Offset: 0x0001C424
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0001E24B File Offset: 0x0001C44B
		public override IAkEventTypeConfig AkEventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEventType;
				}
				EntityStateAudioComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AkEventType;
			}
			set
			{
				this.GetOrCreatePoco().AkEventType = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0001E259 File Offset: 0x0001C459
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0001E284 File Offset: 0x0001C484
		public override EAudioRangeType AudioRangeType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioRangeType;
				}
				if (this.PocoInterface == null)
				{
					return EAudioRangeType.SceneActorRefComp;
				}
				return this.PocoInterface.AudioRangeType;
			}
			set
			{
				this.GetOrCreatePoco().AudioRangeType = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0001E294 File Offset: 0x0001C494
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0001E2BE File Offset: 0x0001C4BE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001E2CC File Offset: 0x0001C4CC
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0001E35F File Offset: 0x0001C55F
		public virtual List<IEntityStateAudioConfig> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityStateAudioConfig> config = this.FbInstance.Config;
					if (config != null)
					{
						this._ConfigCache = new List<IEntityStateAudioConfig>(config.Count);
						for (int i = 0; i < config.Count; i++)
						{
							this._ConfigCache.Add(IEntityStateAudioConfig.Create(config[i]));
						}
					}
				}
				else
				{
					EntityStateAudioComponent_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x0400058B RID: 1419
		[Nullable(2)]
		protected new EntityStateAudioComponent FbInstance;

		// Token: 0x0400058C RID: 1420
		[Nullable(2)]
		protected new EntityStateAudioComponent_SetValue PocoInterface;

		// Token: 0x0400058D RID: 1421
		private List<IEntityStateAudioConfig> _ConfigCache;

		// Token: 0x0400058E RID: 1422
		private bool _ConfigInited;
	}
}
