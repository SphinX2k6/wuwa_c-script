using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002789 RID: 10121
	public class IStateProgramSpecialProcessBase
	{
		// Token: 0x0600E01C RID: 57372 RVA: 0x0020FC01 File Offset: 0x0020DE01
		public static IStateProgramSpecialProcessBase Create(IStateProgramSpecialProcessBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateProgramSpecialProcessBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x0600E01D RID: 57373 RVA: 0x0020FC20 File Offset: 0x0020DE20
		public virtual ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x040079ED RID: 31213
		private IStateProgramSpecialProcessBase Instance;
	}
}
