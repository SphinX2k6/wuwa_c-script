using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000FE RID: 254
	public class EntityAudioComponent : IComponentBase
	{
		// Token: 0x060003CC RID: 972 RVA: 0x0001D334 File Offset: 0x0001B534
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

		// Token: 0x060003CD RID: 973 RVA: 0x0001D36C File Offset: 0x0001B56C
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

		// Token: 0x060003CE RID: 974 RVA: 0x0001D37F File Offset: 0x0001B57F
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

		// Token: 0x060003CF RID: 975 RVA: 0x0001D392 File Offset: 0x0001B592
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0001D406 File Offset: 0x0001B606
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

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0001D414 File Offset: 0x0001B614
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0001D43E File Offset: 0x0001B63E
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0001D44C File Offset: 0x0001B64C
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0001D473 File Offset: 0x0001B673
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001D481 File Offset: 0x0001B681
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x0001D4AC File Offset: 0x0001B6AC
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

		// Token: 0x04000551 RID: 1361
		[Nullable(2)]
		protected new EntityAudioComponent FbInstance;

		// Token: 0x04000552 RID: 1362
		[Nullable(2)]
		protected new EntityAudioComponent_SetValue PocoInterface;
	}
}
