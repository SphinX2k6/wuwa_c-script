using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EAC RID: 3756
	public class IPointChooseType
	{
		// Token: 0x060054B9 RID: 21689 RVA: 0x000D08B5 File Offset: 0x000CEAB5
		public static IPointChooseType Create(IPointChooseType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointChooseType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x060054BA RID: 21690 RVA: 0x000D08D4 File Offset: 0x000CEAD4
		public virtual EPointChooseType Type
		{
			get
			{
				return (EPointChooseType)this.Instance.Type;
			}
		}

		// Token: 0x0400306D RID: 12397
		private IPointChooseType Instance;
	}
}
