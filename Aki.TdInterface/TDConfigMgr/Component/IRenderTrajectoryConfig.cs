using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000723 RID: 1827
	public class IRenderTrajectoryConfig
	{
		// Token: 0x060026C6 RID: 9926 RVA: 0x00068364 File Offset: 0x00066564
		private IRenderTrajectoryConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderTrajectoryConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderTrajectoryConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderTrajectoryConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0006839C File Offset: 0x0006659C
		public static IRenderTrajectoryConfig Create([Nullable(2)] IRenderTrajectoryConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderTrajectoryConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000683AF File Offset: 0x000665AF
		public static IRenderTrajectoryConfig CreateFromSetValue([Nullable(2)] IRenderTrajectoryConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderTrajectoryConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000683C2 File Offset: 0x000665C2
		public IRenderTrajectoryConfig_SetValue ToSetValue()
		{
			return new IRenderTrajectoryConfig_SetValue
			{
				Time = this.Time,
				Effect = this.Effect
			};
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x000683E1 File Offset: 0x000665E1
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x00068410 File Offset: 0x00066610
		public virtual float Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x0006841E File Offset: 0x0006661E
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x00068449 File Offset: 0x00066649
		public virtual string Effect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Effect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Effect;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
			}
		}

		// Token: 0x04001A9A RID: 6810
		[Nullable(2)]
		protected IRenderTrajectoryConfig FbInstance;

		// Token: 0x04001A9B RID: 6811
		[Nullable(2)]
		protected IRenderTrajectoryConfig_SetValue PocoInterface;
	}
}
