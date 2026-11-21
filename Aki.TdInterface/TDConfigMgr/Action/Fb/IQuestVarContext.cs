using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278E RID: 10126
	public class IQuestVarContext : IVarContext
	{
		// Token: 0x0600E04A RID: 57418 RVA: 0x00210316 File Offset: 0x0020E516
		public static IQuestVarContext Create(IQuestVarContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestVarContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600E04B RID: 57419 RVA: 0x00210335 File Offset: 0x0020E535
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600E04C RID: 57420 RVA: 0x00210342 File Offset: 0x0020E542
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007A00 RID: 31232
		private IQuestVarContext Instance;
	}
}
