using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC9 RID: 10953
	public class IQiuyuanQinggongEnd : ILeisureInteractType
	{
		// Token: 0x0600F151 RID: 61777 RVA: 0x00234FAA File Offset: 0x002331AA
		public static IQiuyuanQinggongEnd Create(IQiuyuanQinggongEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x0600F152 RID: 61778 RVA: 0x00234FC9 File Offset: 0x002331C9
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008497 RID: 33943
		private IQiuyuanQinggongEnd Instance;
	}
}
