using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023E RID: 574
	public class ICastConfig
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00029CE4 File Offset: 0x00027EE4
		private ICastConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICastConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICastConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICastConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00029D1C File Offset: 0x00027F1C
		public static ICastConfig Create([Nullable(2)] ICastConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICastConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00029D2F File Offset: 0x00027F2F
		public static ICastConfig CreateFromSetValue([Nullable(2)] ICastConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICastConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00029D42 File Offset: 0x00027F42
		public ICastConfig_SetValue ToSetValue()
		{
			return new ICastConfig_SetValue
			{
				CastAngularVelocity = this.CastAngularVelocity,
				CastCameraShake = this.CastCameraShake,
				CastVelocity = this.CastVelocity
			};
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00029D6D File Offset: 0x00027F6D
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00029D98 File Offset: 0x00027F98
		public virtual int CastAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CastAngularVelocity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CastAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().CastAngularVelocity = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00029DA6 File Offset: 0x00027FA6
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00029DD1 File Offset: 0x00027FD1
		public virtual string CastCameraShake
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CastCameraShake;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CastCameraShake;
			}
			set
			{
				this.GetOrCreatePoco().CastCameraShake = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00029DDF File Offset: 0x00027FDF
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00029E0A File Offset: 0x0002800A
		public virtual int CastVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CastVelocity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CastVelocity;
			}
			set
			{
				this.GetOrCreatePoco().CastVelocity = value;
			}
		}

		// Token: 0x04000A16 RID: 2582
		[Nullable(2)]
		protected ICastConfig FbInstance;

		// Token: 0x04000A17 RID: 2583
		[Nullable(2)]
		protected ICastConfig_SetValue PocoInterface;
	}
}
