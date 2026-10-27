using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA1 RID: 2977
	public class ITargetGearGroupFailureCondition
	{
		// Token: 0x0600445E RID: 17502 RVA: 0x000ADB51 File Offset: 0x000ABD51
		[NullableContext(1)]
		public static ITargetGearGroupFailureCondition Create(ITargetGearGroupFailureCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupFailureCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x000ADB70 File Offset: 0x000ABD70
		public virtual ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x0400269A RID: 9882
		private ITargetGearGroupFailureCondition Instance;
	}
}
