using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A02 RID: 10754
	public class IDungeonEventType
	{
		// Token: 0x0600ED51 RID: 60753 RVA: 0x00229B4B File Offset: 0x00227D4B
		[NullableContext(1)]
		public static IDungeonEventType Create(IDungeonEventType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonEventType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x0600ED52 RID: 60754 RVA: 0x00229B6A File Offset: 0x00227D6A
		public virtual EDungeonEventType Type
		{
			get
			{
				return (EDungeonEventType)this.Instance.Type;
			}
		}

		// Token: 0x040082A4 RID: 33444
		private IDungeonEventType Instance;
	}
}
