using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200274D RID: 10061
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemainStarWarning : ICommonTipType
	{
		// Token: 0x0600E02D RID: 57389 RVA: 0x00212C70 File Offset: 0x00210E70
		public static IRemainStarWarning Create(IRemainStarWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemainStarWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004355 RID: 17237
		// (get) Token: 0x0600E02E RID: 57390 RVA: 0x00212C8F File Offset: 0x00210E8F
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x0600E02F RID: 57391 RVA: 0x00212C9C File Offset: 0x00210E9C
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x04007C4B RID: 31819
		private IRemainStarWarning Instance;
	}
}
