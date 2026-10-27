using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000682 RID: 1666
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderTrajectoryConfig
	{
		// Token: 0x060023AA RID: 9130 RVA: 0x0006139C File Offset: 0x0005F59C
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

		// Token: 0x060023AB RID: 9131 RVA: 0x000613D4 File Offset: 0x0005F5D4
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

		// Token: 0x060023AC RID: 9132 RVA: 0x000613E7 File Offset: 0x0005F5E7
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

		// Token: 0x060023AD RID: 9133 RVA: 0x000613FA File Offset: 0x0005F5FA
		public IRenderTrajectoryConfig_SetValue ToSetValue()
		{
			return new IRenderTrajectoryConfig_SetValue
			{
				Time = this.Time,
				Effect = this.Effect
			};
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x00061419 File Offset: 0x0005F619
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x00061448 File Offset: 0x0005F648
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

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x00061456 File Offset: 0x0005F656
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x00061481 File Offset: 0x0005F681
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

		// Token: 0x0400189D RID: 6301
		[Nullable(2)]
		protected IRenderTrajectoryConfig FbInstance;

		// Token: 0x0400189E RID: 6302
		[Nullable(2)]
		protected IRenderTrajectoryConfig_SetValue PocoInterface;
	}
}
