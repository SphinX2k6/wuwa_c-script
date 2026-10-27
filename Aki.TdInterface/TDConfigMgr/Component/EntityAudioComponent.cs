using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000F5 RID: 245
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityAudioComponent : IComponentBase
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
		private EntityAudioComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityAudioComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityAudioComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityAudioComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		public static EntityAudioComponent Create([Nullable(2)] EntityAudioComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityAudioComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0001CA0B File Offset: 0x0001AC0B
		public static EntityAudioComponent CreateFromSetValue([Nullable(2)] EntityAudioComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityAudioComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0001CA1E File Offset: 0x0001AC1E
		public new EntityAudioComponent_SetValue ToSetValue()
		{
			return new EntityAudioComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AkEventType = this.AkEventType,
				AudioRangeType = this.AudioRangeType
			};
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0001CA58 File Offset: 0x0001AC58
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0001CA92 File Offset: 0x0001AC92
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityAudioComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0001CACA File Offset: 0x0001ACCA
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0001CAFF File Offset: 0x0001ACFF
		public virtual IAkEventTypeConfig AkEventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEventType;
				}
				EntityAudioComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0001CB0D File Offset: 0x0001AD0D
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0001CB38 File Offset: 0x0001AD38
		public virtual EAudioRangeType AudioRangeType
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

		// Token: 0x04000527 RID: 1319
		[Nullable(2)]
		protected new EntityAudioComponent FbInstance;

		// Token: 0x04000528 RID: 1320
		[Nullable(2)]
		protected new EntityAudioComponent_SetValue PocoInterface;
	}
}
