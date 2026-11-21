using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C11 RID: 3089
	public class IThrowDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x060046CC RID: 18124 RVA: 0x000B3FCC File Offset: 0x000B21CC
		public static IThrowDestroyCondition Create(IThrowDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x000B3FEB File Offset: 0x000B21EB
		public override ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x000B3FF8 File Offset: 0x000B21F8
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x040027B8 RID: 10168
		private IThrowDestroyCondition Instance;
	}
}
