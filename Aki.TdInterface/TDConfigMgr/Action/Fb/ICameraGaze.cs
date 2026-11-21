using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAC RID: 10924
	public class ICameraGaze
	{
		// Token: 0x0600F0E0 RID: 61664 RVA: 0x002345C2 File Offset: 0x002327C2
		public static ICameraGaze Create(ICameraGaze? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraGaze
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x0600F0E1 RID: 61665 RVA: 0x002345E1 File Offset: 0x002327E1
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x0600F0E2 RID: 61666 RVA: 0x002345EE File Offset: 0x002327EE
		public virtual float StayTime
		{
			get
			{
				return this.Instance.StayTime;
			}
		}

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x0600F0E3 RID: 61667 RVA: 0x002345FC File Offset: 0x002327FC
		public virtual float? FadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeOutTime);
			}
		}

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x0600F0E4 RID: 61668 RVA: 0x00234634 File Offset: 0x00232834
		public virtual bool? LockCamera
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.LockCamera);
			}
		}

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x0600F0E5 RID: 61669 RVA: 0x0023466A File Offset: 0x0023286A
		public virtual int LockPriority
		{
			get
			{
				return this.Instance.LockPriority;
			}
		}

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x0600F0E6 RID: 61670 RVA: 0x00234678 File Offset: 0x00232878
		public virtual bool? GazeInHook
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.GazeInHook);
			}
		}

		// Token: 0x04008468 RID: 33896
		private ICameraGaze Instance;
	}
}
