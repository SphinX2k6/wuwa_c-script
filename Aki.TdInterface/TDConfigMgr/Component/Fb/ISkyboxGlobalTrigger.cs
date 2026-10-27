using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BFA RID: 3066
	public class ISkyboxGlobalTrigger : ISkyboxTrigger
	{
		// Token: 0x06004669 RID: 18025 RVA: 0x000B1D90 File Offset: 0x000AFF90
		[NullableContext(1)]
		public static ISkyboxGlobalTrigger Create(ISkyboxGlobalTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxGlobalTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x000B1DAF File Offset: 0x000AFFAF
		public override ETriggerMode Type
		{
			get
			{
				return (ETriggerMode)this.Instance.Type;
			}
		}

		// Token: 0x04002813 RID: 10259
		private ISkyboxGlobalTrigger Instance;
	}
}
