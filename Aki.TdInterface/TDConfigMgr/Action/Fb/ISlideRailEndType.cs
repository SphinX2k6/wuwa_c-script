using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A17 RID: 10775
	public class ISlideRailEndType
	{
		// Token: 0x0600ED92 RID: 60818 RVA: 0x0022A08E File Offset: 0x0022828E
		[NullableContext(1)]
		public static ISlideRailEndType Create(ISlideRailEndType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailEndType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x0600ED93 RID: 60819 RVA: 0x0022A0AD File Offset: 0x002282AD
		public virtual ESlideRailEndType Type
		{
			get
			{
				return (ESlideRailEndType)this.Instance.Type;
			}
		}

		// Token: 0x040082C5 RID: 33477
		private ISlideRailEndType Instance;
	}
}
