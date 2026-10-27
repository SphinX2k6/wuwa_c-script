using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002791 RID: 10129
	public class IHideGroupType
	{
		// Token: 0x0600E17A RID: 57722 RVA: 0x00215169 File Offset: 0x00213369
		[NullableContext(1)]
		public static IHideGroupType Create(IHideGroupType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideGroupType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700441A RID: 17434
		// (get) Token: 0x0600E17B RID: 57723 RVA: 0x00215188 File Offset: 0x00213388
		public virtual EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x04007D01 RID: 32001
		private IHideGroupType Instance;
	}
}
