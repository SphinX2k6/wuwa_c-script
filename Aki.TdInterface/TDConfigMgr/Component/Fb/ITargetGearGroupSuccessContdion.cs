using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9C RID: 2972
	public class ITargetGearGroupSuccessContdion
	{
		// Token: 0x0600444D RID: 17485 RVA: 0x000AD9D6 File Offset: 0x000ABBD6
		[NullableContext(1)]
		public static ITargetGearGroupSuccessContdion Create(ITargetGearGroupSuccessContdion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupSuccessContdion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x000AD9F5 File Offset: 0x000ABBF5
		public virtual ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002693 RID: 9875
		private ITargetGearGroupSuccessContdion Instance;
	}
}
