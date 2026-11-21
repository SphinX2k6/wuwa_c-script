using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D6C RID: 11628
	public class ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x0600FDBA RID: 64954 RVA: 0x0024A174 File Offset: 0x00248374
		public static ICommonBtOverrideTaskInfoBase Create(ICommonBtOverrideTaskInfoBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverrideTaskInfoBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F90 RID: 20368
		// (get) Token: 0x0600FDBB RID: 64955 RVA: 0x0024A193 File Offset: 0x00248393
		public virtual ECommonBtPlaceholderTargetType Type
		{
			get
			{
				return (ECommonBtPlaceholderTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008A86 RID: 35462
		private ICommonBtOverrideTaskInfoBase Instance;
	}
}
