using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E17 RID: 11799
	public class ILiveDanmakuPool
	{
		// Token: 0x0601004D RID: 65613 RVA: 0x0024E1A9 File Offset: 0x0024C3A9
		public static ILiveDanmakuPool Create(ILiveDanmakuPool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuPool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x0601004E RID: 65614 RVA: 0x0024E1C8 File Offset: 0x0024C3C8
		public virtual int DanmakuPoolId
		{
			get
			{
				return this.Instance.DanmakuPoolId;
			}
		}

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x0601004F RID: 65615 RVA: 0x0024E1D5 File Offset: 0x0024C3D5
		public virtual float Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x06010050 RID: 65616 RVA: 0x0024E1E2 File Offset: 0x0024C3E2
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x06010051 RID: 65617 RVA: 0x0024E1EF File Offset: 0x0024C3EF
		public virtual ELiveDanmakuLoopType LoopType
		{
			get
			{
				return (ELiveDanmakuLoopType)this.Instance.LoopType;
			}
		}

		// Token: 0x04008BDD RID: 35805
		private ILiveDanmakuPool Instance;
	}
}
