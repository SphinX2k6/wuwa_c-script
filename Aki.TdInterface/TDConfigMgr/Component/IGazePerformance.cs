using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200042D RID: 1069
	public class IGazePerformance
	{
		// Token: 0x06001547 RID: 5447 RVA: 0x00043834 File Offset: 0x00041A34
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

		// Token: 0x06001548 RID: 5448 RVA: 0x0004386C File Offset: 0x00041A6C
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

		// Token: 0x06001549 RID: 5449 RVA: 0x0004387F File Offset: 0x00041A7F
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

		// Token: 0x0600154A RID: 5450 RVA: 0x00043892 File Offset: 0x00041A92
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

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x000438C9 File Offset: 0x00041AC9
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x000438F8 File Offset: 0x00041AF8
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00043906 File Offset: 0x00041B06
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x00043935 File Offset: 0x00041B35
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00043944 File Offset: 0x00041B44
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0004397E File Offset: 0x00041B7E
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0004398C File Offset: 0x00041B8C
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x000439C6 File Offset: 0x00041BC6
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

		// Token: 0x040010C5 RID: 4293
		[Nullable(2)]
		protected IGazePerformance FbInstance;

		// Token: 0x040010C6 RID: 4294
		[Nullable(2)]
		protected IGazePerformance_SetValue PocoInterface;
	}
}
