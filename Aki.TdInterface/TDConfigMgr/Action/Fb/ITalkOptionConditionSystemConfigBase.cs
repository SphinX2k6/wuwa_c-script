using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200250D RID: 9485
	public class ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600D397 RID: 54167 RVA: 0x001F5B34 File Offset: 0x001F3D34
		[NullableContext(1)]
		public static ITalkOptionConditionSystemConfigBase Create(ITalkOptionConditionSystemConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionConditionSystemConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0600D398 RID: 54168 RVA: 0x001F5B53 File Offset: 0x001F3D53
		public virtual ETalkOptionConditionSystem Type
		{
			get
			{
				return (ETalkOptionConditionSystem)this.Instance.Type;
			}
		}

		// Token: 0x040073FD RID: 29693
		private ITalkOptionConditionSystemConfigBase Instance;
	}
}
