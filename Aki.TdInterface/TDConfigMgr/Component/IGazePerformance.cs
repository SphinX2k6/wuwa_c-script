using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003D6 RID: 982
	[NullableContext(1)]
	[Nullable(0)]
	public class IGazePerformance
	{
		// Token: 0x060013B9 RID: 5049 RVA: 0x0003FCB4 File Offset: 0x0003DEB4
		private IGazePerformance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGazePerformance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGazePerformance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGazePerformance_SetValue());
			}
			return result;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0003FCEC File Offset: 0x0003DEEC
		public static IGazePerformance Create([Nullable(2)] IGazePerformance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGazePerformance
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0003FCFF File Offset: 0x0003DEFF
		public static IGazePerformance CreateFromSetValue([Nullable(2)] IGazePerformance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGazePerformance
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0003FD12 File Offset: 0x0003DF12
		public IGazePerformance_SetValue ToSetValue()
		{
			return new IGazePerformance_SetValue
			{
				FadeInTime = this.FadeInTime,
				StayTime = this.StayTime,
				FadeOutTime = this.FadeOutTime,
				LockCamera = this.LockCamera
			};
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0003FD49 File Offset: 0x0003DF49
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0003FD78 File Offset: 0x0003DF78
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0003FD86 File Offset: 0x0003DF86
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0003FDB5 File Offset: 0x0003DFB5
		public virtual float StayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.StayTime;
			}
			set
			{
				this.GetOrCreatePoco().StayTime = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0003FDC4 File Offset: 0x0003DFC4
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0003FDFE File Offset: 0x0003DFFE
		public virtual float? FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				IGazePerformance_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0003FE0C File Offset: 0x0003E00C
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0003FE46 File Offset: 0x0003E046
		public virtual bool? LockCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockCamera;
				}
				IGazePerformance_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LockCamera;
			}
			set
			{
				this.GetOrCreatePoco().LockCamera = value;
			}
		}

		// Token: 0x04000FAC RID: 4012
		[Nullable(2)]
		protected IGazePerformance FbInstance;

		// Token: 0x04000FAD RID: 4013
		[Nullable(2)]
		protected IGazePerformance_SetValue PocoInterface;
	}
}
