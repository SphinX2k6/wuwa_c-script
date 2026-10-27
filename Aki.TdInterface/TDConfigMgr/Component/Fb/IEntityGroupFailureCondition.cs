using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AEA RID: 2794
	public class IEntityGroupFailureCondition
	{
		// Token: 0x06004057 RID: 16471 RVA: 0x000A443A File Offset: 0x000A263A
		[NullableContext(1)]
		public static IEntityGroupFailureCondition Create(IEntityGroupFailureCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityGroupFailureCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x000A4459 File Offset: 0x000A2659
		public virtual EEntityGroupFailureCondition Type
		{
			get
			{
				return (EEntityGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x040023D7 RID: 9175
		private IEntityGroupFailureCondition Instance;
	}
}
