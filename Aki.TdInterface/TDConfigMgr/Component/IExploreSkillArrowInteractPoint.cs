using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000347 RID: 839
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillArrowInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06001096 RID: 4246 RVA: 0x000393C4 File Offset: 0x000375C4
		private IExploreSkillArrowInteractPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillArrowInteractPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillArrowInteractPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillArrowInteractPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x000393FC File Offset: 0x000375FC
		public static IExploreSkillArrowInteractPoint Create([Nullable(2)] IExploreSkillArrowInteractPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillArrowInteractPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0003940F File Offset: 0x0003760F
		public static IExploreSkillArrowInteractPoint CreateFromSetValue([Nullable(2)] IExploreSkillArrowInteractPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillArrowInteractPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00039422 File Offset: 0x00037622
		public new IExploreSkillArrowInteractPoint_SetValue ToSetValue()
		{
			return new IExploreSkillArrowInteractPoint_SetValue
			{
				Type = this.Type,
				MinDistance = this.MinDistance,
				InteractWaitTime = this.InteractWaitTime,
				ShootWaitTime = this.ShootWaitTime
			};
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00039459 File Offset: 0x00037659
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00039484 File Offset: 0x00037684
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00039492 File Offset: 0x00037692
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x000394C1 File Offset: 0x000376C1
		public virtual float MinDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinDistance;
			}
			set
			{
				this.GetOrCreatePoco().MinDistance = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x000394CF File Offset: 0x000376CF
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x000394FE File Offset: 0x000376FE
		public virtual float InteractWaitTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractWaitTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.InteractWaitTime;
			}
			set
			{
				this.GetOrCreatePoco().InteractWaitTime = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0003950C File Offset: 0x0003770C
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0003953B File Offset: 0x0003773B
		public virtual float ShootWaitTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShootWaitTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ShootWaitTime;
			}
			set
			{
				this.GetOrCreatePoco().ShootWaitTime = value;
			}
		}

		// Token: 0x04000DE6 RID: 3558
		[Nullable(2)]
		protected new IExploreSkillArrowInteractPoint FbInstance;

		// Token: 0x04000DE7 RID: 3559
		[Nullable(2)]
		protected new IExploreSkillArrowInteractPoint_SetValue PocoInterface;
	}
}
