using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF6 RID: 7158
	public class IFireBulletForwardFront : IFireBulletType
	{
		// Token: 0x060097FE RID: 38910 RVA: 0x00160EF0 File Offset: 0x0015F0F0
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

		// Token: 0x060097FF RID: 38911 RVA: 0x00160F28 File Offset: 0x0015F128
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

		// Token: 0x06009800 RID: 38912 RVA: 0x00160F3B File Offset: 0x0015F13B
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

		// Token: 0x06009801 RID: 38913 RVA: 0x00160F4E File Offset: 0x0015F14E
		public new IFireBulletForwardFront_SetValue ToSetValue()
		{
			return new IFireBulletForwardFront_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				Launcher = this.Launcher
			};
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x06009802 RID: 38914 RVA: 0x00160F79 File Offset: 0x0015F179
		// (set) Token: 0x06009803 RID: 38915 RVA: 0x00160FA4 File Offset: 0x0015F1A4
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

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x06009804 RID: 38916 RVA: 0x00160FB2 File Offset: 0x0015F1B2
		// (set) Token: 0x06009805 RID: 38917 RVA: 0x00160FDE File Offset: 0x0015F1DE
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

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x06009806 RID: 38918 RVA: 0x00160FEC File Offset: 0x0015F1EC
		// (set) Token: 0x06009807 RID: 38919 RVA: 0x00161013 File Offset: 0x0015F213
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

		// Token: 0x04005DAE RID: 23982
		[Nullable(2)]
		protected new IFireBulletForwardFront FbInstance;

		// Token: 0x04005DAF RID: 23983
		[Nullable(2)]
		protected new IFireBulletForwardFront_SetValue PocoInterface;
	}
}
