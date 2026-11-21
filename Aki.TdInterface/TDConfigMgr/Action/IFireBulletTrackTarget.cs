using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BFA RID: 7162
	public class IFireBulletTrackTarget : IFireBulletType
	{
		// Token: 0x06009818 RID: 38936 RVA: 0x001611BC File Offset: 0x0015F3BC
		private IFireBulletTrackTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFireBulletTrackTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFireBulletTrackTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFireBulletTrackTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x001611F4 File Offset: 0x0015F3F4
		public static IFireBulletTrackTarget Create([Nullable(2)] IFireBulletTrackTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletTrackTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x00161207 File Offset: 0x0015F407
		public static IFireBulletTrackTarget CreateFromSetValue([Nullable(2)] IFireBulletTrackTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFireBulletTrackTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x0016121C File Offset: 0x0015F41C
		public new IFireBulletTrackTarget_SetValue ToSetValue()
		{
			return new IFireBulletTrackTarget_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				Launcher = this.Launcher,
				Target = this.Target,
				WaitDestroy = this.WaitDestroy
			};
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0600981C RID: 38940 RVA: 0x0016126A File Offset: 0x0015F46A
		// (set) Token: 0x0600981D RID: 38941 RVA: 0x00161295 File Offset: 0x0015F495
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

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0600981E RID: 38942 RVA: 0x001612A3 File Offset: 0x0015F4A3
		// (set) Token: 0x0600981F RID: 38943 RVA: 0x001612CF File Offset: 0x0015F4CF
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

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x06009820 RID: 38944 RVA: 0x001612DD File Offset: 0x0015F4DD
		// (set) Token: 0x06009821 RID: 38945 RVA: 0x00161304 File Offset: 0x0015F504
		public virtual ITargetEntityType Launcher
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Launcher;
				}
				IFireBulletTrackTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x06009822 RID: 38946 RVA: 0x00161312 File Offset: 0x0015F512
		// (set) Token: 0x06009823 RID: 38947 RVA: 0x00161339 File Offset: 0x0015F539
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IFireBulletTrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x06009824 RID: 38948 RVA: 0x00161348 File Offset: 0x0015F548
		// (set) Token: 0x06009825 RID: 38949 RVA: 0x00161382 File Offset: 0x0015F582
		public virtual bool? WaitDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WaitDestroy;
				}
				IFireBulletTrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WaitDestroy;
			}
			set
			{
				this.GetOrCreatePoco().WaitDestroy = value;
			}
		}

		// Token: 0x04005DB9 RID: 23993
		[Nullable(2)]
		protected new IFireBulletTrackTarget FbInstance;

		// Token: 0x04005DBA RID: 23994
		[Nullable(2)]
		protected new IFireBulletTrackTarget_SetValue PocoInterface;
	}
}
