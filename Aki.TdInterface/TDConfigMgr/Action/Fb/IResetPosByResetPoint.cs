using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DDB RID: 11739
	public class IResetPosByResetPoint : IResetPosType
	{
		// Token: 0x0600FF6F RID: 65391 RVA: 0x0024CE19 File Offset: 0x0024B019
		public static IResetPosByResetPoint Create(IResetPosByResetPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosByResetPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x0600FF70 RID: 65392 RVA: 0x0024CE38 File Offset: 0x0024B038
		public override EResetPosType Type
		{
			get
			{
				return (EResetPosType)this.Instance.Type;
			}
		}

		// Token: 0x04008B73 RID: 35699
		private IResetPosByResetPoint Instance;
	}
}
