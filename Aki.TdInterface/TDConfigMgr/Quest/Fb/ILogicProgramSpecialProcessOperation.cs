using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F4 RID: 4852
	public class ILogicProgramSpecialProcessOperation
	{
		// Token: 0x06006EB4 RID: 28340 RVA: 0x0010B628 File Offset: 0x00109828
		[NullableContext(1)]
		public static ILogicProgramSpecialProcessOperation Create(ILogicProgramSpecialProcessOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILogicProgramSpecialProcessOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06006EB5 RID: 28341 RVA: 0x0010B647 File Offset: 0x00109847
		public virtual ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x04003F74 RID: 16244
		private ILogicProgramSpecialProcessOperation Instance;
	}
}
