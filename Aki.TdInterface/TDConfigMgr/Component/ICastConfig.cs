using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000217 RID: 535
	[NullableContext(1)]
	[Nullable(0)]
	public class ICastConfig
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x00028524 File Offset: 0x00026724
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

		// Token: 0x0600091B RID: 2331 RVA: 0x0002855C File Offset: 0x0002675C
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

		// Token: 0x0600091C RID: 2332 RVA: 0x0002856F File Offset: 0x0002676F
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

		// Token: 0x0600091D RID: 2333 RVA: 0x00028582 File Offset: 0x00026782
		public ICastConfig_SetValue ToSetValue()
		{
			return new ICastConfig_SetValue
			{
				CastAngularVelocity = this.CastAngularVelocity,
				CastCameraShake = this.CastCameraShake,
				CastVelocity = this.CastVelocity
			};
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x000285AD File Offset: 0x000267AD
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x000285D8 File Offset: 0x000267D8
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x000285E6 File Offset: 0x000267E6
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00028611 File Offset: 0x00026811
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002861F File Offset: 0x0002681F
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0002864A File Offset: 0x0002684A
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

		// Token: 0x0400098C RID: 2444
		[Nullable(2)]
		protected ICastConfig FbInstance;

		// Token: 0x0400098D RID: 2445
		[Nullable(2)]
		protected ICastConfig_SetValue PocoInterface;
	}
}
