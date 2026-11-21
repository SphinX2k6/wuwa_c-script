using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000104 RID: 260
	public class EntityCustomAudioComponent : EntityAudioComponent
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x0001D93C File Offset: 0x0001BB3C
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

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001D974 File Offset: 0x0001BB74
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

		// Token: 0x060003FA RID: 1018 RVA: 0x0001D987 File Offset: 0x0001BB87
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

		// Token: 0x060003FB RID: 1019 RVA: 0x0001D99C File Offset: 0x0001BB9C
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0001D9EC File Offset: 0x0001BBEC
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0001DA26 File Offset: 0x0001BC26
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0001DA34 File Offset: 0x0001BC34
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0001DA5B File Offset: 0x0001BC5B
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0001DA69 File Offset: 0x0001BC69
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0001DA94 File Offset: 0x0001BC94
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0001DACE File Offset: 0x0001BCCE
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

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001DADC File Offset: 0x0001BCDC
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0001DB03 File Offset: 0x0001BD03
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

		// Token: 0x0400056A RID: 1386
		[Nullable(2)]
		protected new EntityCustomAudioComponent FbInstance;

		// Token: 0x0400056B RID: 1387
		[Nullable(2)]
		protected new EntityCustomAudioComponent_SetValue PocoInterface;
	}
}
