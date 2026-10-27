using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026AB RID: 9899
	public class UnlockDungeonEntry : ActionParams
	{
		// Token: 0x0600DD86 RID: 56710 RVA: 0x0020E7AE File Offset: 0x0020C9AE
		[NullableContext(1)]
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

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x0600DD87 RID: 56711 RVA: 0x0020E7CD File Offset: 0x0020C9CD
		public virtual int DungeonEntryId
		{
			get
			{
				return this.Instance.DungeonEntryId;
			}
		}

		// Token: 0x04007B03 RID: 31491
		private IUnlockDungeonEntry Instance;
	}
}
