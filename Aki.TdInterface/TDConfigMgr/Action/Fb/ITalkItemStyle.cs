using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E6 RID: 10214
	public class ITalkItemStyle
	{
		// Token: 0x0600E1FB RID: 57851 RVA: 0x00213726 File Offset: 0x00211926
		public static ITalkItemStyle Create(ITalkItemStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x0600E1FC RID: 57852 RVA: 0x00213745 File Offset: 0x00211945
		public virtual ETalkItemStyle Type
		{
			get
			{
				return (ETalkItemStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007AE0 RID: 31456
		private ITalkItemStyle Instance;
	}
}
