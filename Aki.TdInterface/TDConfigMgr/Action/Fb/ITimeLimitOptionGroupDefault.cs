using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200252A RID: 9514
	public class ITimeLimitOptionGroupDefault : ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600D41F RID: 54303 RVA: 0x001F696D File Offset: 0x001F4B6D
		[NullableContext(1)]
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

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x0600D420 RID: 54304 RVA: 0x001F698C File Offset: 0x001F4B8C
		public override ETimeLimitOptionGroupStyle Type
		{
			get
			{
				return (ETimeLimitOptionGroupStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x0600D421 RID: 54305 RVA: 0x001F6999 File Offset: 0x001F4B99
		public virtual int TimeoutOptionIndex
		{
			get
			{
				return this.Instance.TimeoutOptionIndex;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x0600D422 RID: 54306 RVA: 0x001F69A6 File Offset: 0x001F4BA6
		public virtual float TimeLimit
		{
			get
			{
				return this.Instance.TimeLimit;
			}
		}

		// Token: 0x04007432 RID: 29746
		private ITimeLimitOptionGroupDefault Instance;
	}
}
