using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DD7 RID: 11735
	public class IPresentationType
	{
		// Token: 0x0600FF60 RID: 65376 RVA: 0x0024CCCA File Offset: 0x0024AECA
		public static IPresentationType Create(IPresentationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPresentationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005060 RID: 20576
		// (get) Token: 0x0600FF61 RID: 65377 RVA: 0x0024CCE9 File Offset: 0x0024AEE9
		public virtual EResetPresentationType Type
		{
			get
			{
				return (EResetPresentationType)this.Instance.Type;
			}
		}

		// Token: 0x04008B6D RID: 35693
		private IPresentationType Instance;
	}
}
