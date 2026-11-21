using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279C RID: 10140
	public class ISetAreaTimeBase
	{
		// Token: 0x0600E0A0 RID: 57504 RVA: 0x00210DBC File Offset: 0x0020EFBC
		public static ISetAreaTimeBase Create(ISetAreaTimeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x0600E0A1 RID: 57505 RVA: 0x00210DDB File Offset: 0x0020EFDB
		public virtual ESetAreaTime Type
		{
			get
			{
				return (ESetAreaTime)this.Instance.Type;
			}
		}

		// Token: 0x04007A26 RID: 31270
		private ISetAreaTimeBase Instance;
	}
}
