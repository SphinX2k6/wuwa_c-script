using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D9 RID: 10201
	public class ICameraGaze
	{
		// Token: 0x0600E2BC RID: 58044 RVA: 0x0021778E File Offset: 0x0021598E
		[NullableContext(1)]
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

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x002177AD File Offset: 0x002159AD
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x0600E2BE RID: 58046 RVA: 0x002177BA File Offset: 0x002159BA
		public virtual float StayTime
		{
			get
			{
				return this.Instance.StayTime;
			}
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x002177C8 File Offset: 0x002159C8
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

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x0600E2C0 RID: 58048 RVA: 0x00217800 File Offset: 0x00215A00
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

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x0600E2C1 RID: 58049 RVA: 0x00217836 File Offset: 0x00215A36
		public virtual int LockPriority
		{
			get
			{
				return this.Instance.LockPriority;
			}
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x0600E2C2 RID: 58050 RVA: 0x00217844 File Offset: 0x00215A44
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

		// Token: 0x04007DAD RID: 32173
		private ICameraGaze Instance;
	}
}
