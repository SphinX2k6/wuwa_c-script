using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014FF RID: 5375
	public class ITakePhoto2PosCondition
	{
		// Token: 0x060079C0 RID: 31168 RVA: 0x00122E05 File Offset: 0x00121005
		public static ITakePhoto2PosCondition Create(ITakePhoto2PosCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2PosCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x00122E24 File Offset: 0x00121024
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x04004611 RID: 17937
		private ITakePhoto2PosCondition Instance;
	}
}
