using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000FB RID: 251
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityCustomAudioComponent : EntityAudioComponent
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		private EntityCustomAudioComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityCustomAudioComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityCustomAudioComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityCustomAudioComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001D000 File Offset: 0x0001B200
		public static EntityCustomAudioComponent Create([Nullable(2)] EntityCustomAudioComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityCustomAudioComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001D013 File Offset: 0x0001B213
		public static EntityCustomAudioComponent CreateFromSetValue([Nullable(2)] EntityCustomAudioComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityCustomAudioComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001D028 File Offset: 0x0001B228
		public new EntityCustomAudioComponent_SetValue ToSetValue()
		{
			return new EntityCustomAudioComponent_SetValue
			{
				Disabled = this.Disabled,
				AkEventType = this.AkEventType,
				AudioRangeType = this.AudioRangeType,
				EdIsLocked = this.EdIsLocked,
				AudioControlType = this.AudioControlType
			};
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001D078 File Offset: 0x0001B278
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0001D0B2 File Offset: 0x0001B2B2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityCustomAudioComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0001D0E7 File Offset: 0x0001B2E7
		public override IAkEventTypeConfig AkEventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEventType;
				}
				EntityCustomAudioComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0001D0F5 File Offset: 0x0001B2F5
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0001D120 File Offset: 0x0001B320
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0001D130 File Offset: 0x0001B330
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0001D15A File Offset: 0x0001B35A
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0001D168 File Offset: 0x0001B368
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0001D18F File Offset: 0x0001B38F
		public virtual IAudioControlType AudioControlType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioControlType;
				}
				EntityCustomAudioComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AudioControlType;
			}
			set
			{
				this.GetOrCreatePoco().AudioControlType = value;
			}
		}

		// Token: 0x04000540 RID: 1344
		[Nullable(2)]
		protected new EntityCustomAudioComponent FbInstance;

		// Token: 0x04000541 RID: 1345
		[Nullable(2)]
		protected new EntityCustomAudioComponent_SetValue PocoInterface;
	}
}
