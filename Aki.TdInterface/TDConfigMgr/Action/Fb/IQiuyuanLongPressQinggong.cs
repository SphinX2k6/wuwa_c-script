using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC8 RID: 10952
	public class IQiuyuanLongPressQinggong : ILeisureInteractType
	{
		// Token: 0x0600F14E RID: 61774 RVA: 0x00234F76 File Offset: 0x00233176
		public static IQiuyuanLongPressQinggong Create(IQiuyuanLongPressQinggong? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanLongPressQinggong
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x0600F14F RID: 61775 RVA: 0x00234F95 File Offset: 0x00233195
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008496 RID: 33942
		private IQiuyuanLongPressQinggong Instance;
	}
}
