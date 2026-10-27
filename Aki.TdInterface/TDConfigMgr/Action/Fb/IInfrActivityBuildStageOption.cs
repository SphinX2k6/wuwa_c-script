using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002653 RID: 9811
	public class IInfrActivityBuildStageOption
	{
		// Token: 0x0600DBFF RID: 56319 RVA: 0x0020BEB1 File Offset: 0x0020A0B1
		[NullableContext(1)]
		public static IInfrActivityBuildStageOption Create(IInfrActivityBuildStageOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityBuildStageOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x0600DC00 RID: 56320 RVA: 0x0020BED0 File Offset: 0x0020A0D0
		public virtual EInfrActivityBuildStageType Type
		{
			get
			{
				return (EInfrActivityBuildStageType)this.Instance.Type;
			}
		}

		// Token: 0x04007A4F RID: 31311
		private IInfrActivityBuildStageOption Instance;
	}
}
