using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002789 RID: 10121
	public class IHideRangeType
	{
		// Token: 0x0600E15B RID: 57691 RVA: 0x00214D2B File Offset: 0x00212F2B
		[NullableContext(1)]
		public static IHideRangeType Create(IHideRangeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideRangeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700440B RID: 17419
		// (get) Token: 0x0600E15C RID: 57692 RVA: 0x00214D4A File Offset: 0x00212F4A
		public virtual EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x04007CED RID: 31981
		private IHideRangeType Instance;
	}
}
