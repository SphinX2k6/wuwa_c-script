using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200038E RID: 910
	public class IExploreSkillArrowInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x060011C8 RID: 4552 RVA: 0x0003C390 File Offset: 0x0003A590
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

		// Token: 0x060011C9 RID: 4553 RVA: 0x0003C3C8 File Offset: 0x0003A5C8
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

		// Token: 0x060011CA RID: 4554 RVA: 0x0003C3DB File Offset: 0x0003A5DB
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

		// Token: 0x060011CB RID: 4555 RVA: 0x0003C3EE File Offset: 0x0003A5EE
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0003C425 File Offset: 0x0003A625
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x0003C450 File Offset: 0x0003A650
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

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0003C45E File Offset: 0x0003A65E
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x0003C48D File Offset: 0x0003A68D
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0003C49B File Offset: 0x0003A69B
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x0003C4CA File Offset: 0x0003A6CA
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

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0003C4D8 File Offset: 0x0003A6D8
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0003C507 File Offset: 0x0003A707
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

		// Token: 0x04000ED1 RID: 3793
		[Nullable(2)]
		protected new IExploreSkillArrowInteractPoint FbInstance;

		// Token: 0x04000ED2 RID: 3794
		[Nullable(2)]
		protected new IExploreSkillArrowInteractPoint_SetValue PocoInterface;
	}
}
