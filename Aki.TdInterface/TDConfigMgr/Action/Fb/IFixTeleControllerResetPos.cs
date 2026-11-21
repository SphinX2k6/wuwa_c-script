using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002783 RID: 10115
	public class IFixTeleControllerResetPos : ActionParams
	{
		// Token: 0x0600E00B RID: 57355 RVA: 0x0020F9C6 File Offset: 0x0020DBC6
		public static IFixTeleControllerResetPos Create(IFixTeleControllerResetPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixTeleControllerResetPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x0600E00C RID: 57356 RVA: 0x0020F9E5 File Offset: 0x0020DBE5
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x040079E1 RID: 31201
		private IFixTeleControllerResetPos Instance;
	}
}
