using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296E RID: 10606
	public class UnlockDungeonEntry : ActionParams
	{
		// Token: 0x0600EB5D RID: 60253 RVA: 0x0022AF4E File Offset: 0x0022914E
		public static UnlockDungeonEntry Create(IUnlockDungeonEntry? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockDungeonEntry
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x0600EB5E RID: 60254 RVA: 0x0022AF6D File Offset: 0x0022916D
		public virtual int DungeonEntryId
		{
			get
			{
				return this.Instance.DungeonEntryId;
			}
		}

		// Token: 0x040081A0 RID: 33184
		private IUnlockDungeonEntry Instance;
	}
}
