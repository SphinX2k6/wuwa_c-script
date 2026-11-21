using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B04 RID: 11012
	public class ILiftMoveTypeCustomSpeed : ILiftMoveType
	{
		// Token: 0x0600F24D RID: 62029 RVA: 0x00236696 File Offset: 0x00234896
		public static ILiftMoveTypeCustomSpeed Create(ILiftMoveTypeCustomSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeCustomSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x0600F24E RID: 62030 RVA: 0x002366B5 File Offset: 0x002348B5
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x0600F24F RID: 62031 RVA: 0x002366C2 File Offset: 0x002348C2
		public virtual float TotalTime
		{
			get
			{
				return this.Instance.TotalTime;
			}
		}

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x0600F250 RID: 62032 RVA: 0x002366CF File Offset: 0x002348CF
		public virtual string TimePathCurve
		{
			get
			{
				return this.Instance.TimePathCurve;
			}
		}

		// Token: 0x040084FC RID: 34044
		private ILiftMoveTypeCustomSpeed Instance;
	}
}
