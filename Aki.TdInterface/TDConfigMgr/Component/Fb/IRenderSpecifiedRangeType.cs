using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E63 RID: 3683
	public class IRenderSpecifiedRangeType
	{
		// Token: 0x0600533F RID: 21311 RVA: 0x000CD7A2 File Offset: 0x000CB9A2
		public static IRenderSpecifiedRangeType Create(IRenderSpecifiedRangeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderSpecifiedRangeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x000CD7C1 File Offset: 0x000CB9C1
		public virtual ERenderSpecifiedRangeType Type
		{
			get
			{
				return (ERenderSpecifiedRangeType)this.Instance.Type;
			}
		}

		// Token: 0x04002F88 RID: 12168
		private IRenderSpecifiedRangeType Instance;
	}
}
