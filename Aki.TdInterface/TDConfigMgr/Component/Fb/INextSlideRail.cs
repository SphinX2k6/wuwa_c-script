using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E8F RID: 3727
	public class INextSlideRail
	{
		// Token: 0x06005429 RID: 21545 RVA: 0x000CF71A File Offset: 0x000CD91A
		public static INextSlideRail Create(INextSlideRail? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INextSlideRail
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x000CF739 File Offset: 0x000CD939
		public virtual ETriggerKey TriggerKey
		{
			get
			{
				return (ETriggerKey)this.Instance.TriggerKey;
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x0600542B RID: 21547 RVA: 0x000CF746 File Offset: 0x000CD946
		public virtual int TargetRailEntityId
		{
			get
			{
				return this.Instance.TargetRailEntityId;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x000CF754 File Offset: 0x000CD954
		public virtual bool? IsFallbackRail
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFallbackRail);
			}
		}

		// Token: 0x04003032 RID: 12338
		private INextSlideRail Instance;
	}
}
