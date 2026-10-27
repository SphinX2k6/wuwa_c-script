using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B10 RID: 2832
	public class IGazePerformance
	{
		// Token: 0x0600416D RID: 16749 RVA: 0x000A7FEA File Offset: 0x000A61EA
		[NullableContext(1)]
		public static IGazePerformance Create(IGazePerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGazePerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x000A8009 File Offset: 0x000A6209
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x000A8016 File Offset: 0x000A6216
		public virtual float StayTime
		{
			get
			{
				return this.Instance.StayTime;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x000A8024 File Offset: 0x000A6224
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

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x000A805C File Offset: 0x000A625C
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

		// Token: 0x040024DD RID: 9437
		private IGazePerformance Instance;
	}
}
