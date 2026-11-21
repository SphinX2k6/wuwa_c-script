using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015AB RID: 5547
	public class IRecallData
	{
		// Token: 0x06007D13 RID: 32019 RVA: 0x001294A6 File Offset: 0x001276A6
		public static IRecallData Create(IRecallData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x06007D14 RID: 32020 RVA: 0x001294C5 File Offset: 0x001276C5
		public virtual ERecallDataType Type
		{
			get
			{
				return (ERecallDataType)this.Instance.Type;
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x06007D15 RID: 32021 RVA: 0x001294D2 File Offset: 0x001276D2
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04004845 RID: 18501
		private IRecallData Instance;
	}
}
