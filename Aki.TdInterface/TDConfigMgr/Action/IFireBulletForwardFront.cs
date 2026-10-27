using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A61 RID: 6753
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletForwardFront : IFireBulletType
	{
		// Token: 0x06009094 RID: 37012 RVA: 0x00150FC4 File Offset: 0x0014F1C4
		private IFireBulletForwardFront_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFireBulletForwardFront 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFireBulletForwardFront_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFireBulletForwardFront_SetValue());
			}
			return result;
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x00150FFC File Offset: 0x0014F1FC
		public static IFireBulletForwardFront Create([Nullable(2)] IFireBulletForwardFront instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletForwardFront
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x0015100F File Offset: 0x0014F20F
		public static IFireBulletForwardFront CreateFromSetValue([Nullable(2)] IFireBulletForwardFront_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFireBulletForwardFront
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x00151022 File Offset: 0x0014F222
		public new IFireBulletForwardFront_SetValue ToSetValue()
		{
			return new IFireBulletForwardFront_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				Launcher = this.Launcher
			};
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x06009098 RID: 37016 RVA: 0x0015104D File Offset: 0x0014F24D
		// (set) Token: 0x06009099 RID: 37017 RVA: 0x00151078 File Offset: 0x0014F278
		public override EFireBulletType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFireBulletType.TrackTarget;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0600909A RID: 37018 RVA: 0x00151086 File Offset: 0x0014F286
		// (set) Token: 0x0600909B RID: 37019 RVA: 0x001510B2 File Offset: 0x0014F2B2
		public virtual long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600909C RID: 37020 RVA: 0x001510C0 File Offset: 0x0014F2C0
		// (set) Token: 0x0600909D RID: 37021 RVA: 0x001510E7 File Offset: 0x0014F2E7
		public virtual ITargetEntityType Launcher
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Launcher;
				}
				IFireBulletForwardFront_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Launcher;
			}
			set
			{
				this.GetOrCreatePoco().Launcher = value;
			}
		}

		// Token: 0x04005949 RID: 22857
		[Nullable(2)]
		protected new IFireBulletForwardFront FbInstance;

		// Token: 0x0400594A RID: 22858
		[Nullable(2)]
		protected new IFireBulletForwardFront_SetValue PocoInterface;
	}
}
