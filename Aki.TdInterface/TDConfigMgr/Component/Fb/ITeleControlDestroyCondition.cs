using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B40 RID: 2880
	public class ITeleControlDestroyCondition
	{
		// Token: 0x0600426A RID: 17002 RVA: 0x000A9E6C File Offset: 0x000A806C
		[NullableContext(1)]
		public static ITeleControlDestroyCondition Create(ITeleControlDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x000A9E8B File Offset: 0x000A808B
		public virtual ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x0400256D RID: 9581
		private ITeleControlDestroyCondition Instance;
	}
}
