using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B7 RID: 10167
	public class ITalkOptionParamType
	{
		// Token: 0x0600E109 RID: 57609 RVA: 0x0021173C File Offset: 0x0020F93C
		public static ITalkOptionParamType Create(ITalkOptionParamType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionParamType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x0600E10A RID: 57610 RVA: 0x0021175B File Offset: 0x0020F95B
		public virtual ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007A55 RID: 31317
		private ITalkOptionParamType Instance;
	}
}
