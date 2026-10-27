using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E4 RID: 9444
	public class IStateProgramSpecialProcessBase
	{
		// Token: 0x0600D2C7 RID: 53959 RVA: 0x001F43A5 File Offset: 0x001F25A5
		[NullableContext(1)]
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

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x0600D2C8 RID: 53960 RVA: 0x001F43C4 File Offset: 0x001F25C4
		public virtual ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x040073A0 RID: 29600
		private IStateProgramSpecialProcessBase Instance;
	}
}
