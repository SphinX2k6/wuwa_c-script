using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D1 RID: 10193
	public class ITimeLimitOptionGroupDefault : ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600E17F RID: 57727 RVA: 0x002123CD File Offset: 0x002105CD
		public static ITimeLimitOptionGroupDefault Create(ITimeLimitOptionGroupDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0600E180 RID: 57728 RVA: 0x002123EC File Offset: 0x002105EC
		public override ETimeLimitOptionGroupStyle Type
		{
			get
			{
				return (ETimeLimitOptionGroupStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x0600E181 RID: 57729 RVA: 0x002123F9 File Offset: 0x002105F9
		public virtual int TimeoutOptionIndex
		{
			get
			{
				return this.Instance.TimeoutOptionIndex;
			}
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x0600E182 RID: 57730 RVA: 0x00212406 File Offset: 0x00210606
		public virtual float TimeLimit
		{
			get
			{
				return this.Instance.TimeLimit;
			}
		}

		// Token: 0x04007A87 RID: 31367
		private ITimeLimitOptionGroupDefault Instance;
	}
}
