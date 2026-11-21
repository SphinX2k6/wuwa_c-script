using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6A RID: 3178
	public class ITargetGearGroupSuccessContdion
	{
		// Token: 0x060048A6 RID: 18598 RVA: 0x000B7A9A File Offset: 0x000B5C9A
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

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x060048A7 RID: 18599 RVA: 0x000B7AB9 File Offset: 0x000B5CB9
		public virtual ETargetGearGroupSuccessCondition Type
		{
			get
			{
				return (ETargetGearGroupSuccessCondition)this.Instance.Type;
			}
		}

		// Token: 0x040028DB RID: 10459
		private ITargetGearGroupSuccessContdion Instance;
	}
}
