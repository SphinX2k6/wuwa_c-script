using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C56 RID: 11350
	public class ISetJigsawFoundationType
	{
		// Token: 0x0600F990 RID: 63888 RVA: 0x00243DFA File Offset: 0x00241FFA
		public static ISetJigsawFoundationType Create(ISetJigsawFoundationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetJigsawFoundationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x0600F991 RID: 63889 RVA: 0x00243E19 File Offset: 0x00242019
		public virtual ESetJigsawFoundationType Type
		{
			get
			{
				return (ESetJigsawFoundationType)this.Instance.Type;
			}
		}

		// Token: 0x04008866 RID: 34918
		private ISetJigsawFoundationType Instance;
	}
}
