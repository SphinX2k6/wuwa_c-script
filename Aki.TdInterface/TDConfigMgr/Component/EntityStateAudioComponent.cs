using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000103 RID: 259
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityStateAudioComponent : EntityAudioComponent
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x0001D7B8 File Offset: 0x0001B9B8
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

		// Token: 0x0600042F RID: 1071 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
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

		// Token: 0x06000430 RID: 1072 RVA: 0x0001D803 File Offset: 0x0001BA03
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

		// Token: 0x06000431 RID: 1073 RVA: 0x0001D818 File Offset: 0x0001BA18
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0001D868 File Offset: 0x0001BA68
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0001D8A2 File Offset: 0x0001BAA2
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0001D8D7 File Offset: 0x0001BAD7
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0001D8E5 File Offset: 0x0001BAE5
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0001D910 File Offset: 0x0001BB10
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001D920 File Offset: 0x0001BB20
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0001D94A File Offset: 0x0001BB4A
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0001D958 File Offset: 0x0001BB58
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0001D9EB File Offset: 0x0001BBEB
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

		// Token: 0x04000561 RID: 1377
		[Nullable(2)]
		protected new EntityStateAudioComponent FbInstance;

		// Token: 0x04000562 RID: 1378
		[Nullable(2)]
		protected new EntityStateAudioComponent_SetValue PocoInterface;

		// Token: 0x04000563 RID: 1379
		private List<IEntityStateAudioConfig> _ConfigCache;

		// Token: 0x04000564 RID: 1380
		private bool _ConfigInited;
	}
}
