using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B48 RID: 11080
	public class IDartChampionOwnerInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600F39B RID: 62363 RVA: 0x00238A56 File Offset: 0x00236C56
		public static IDartChampionOwnerInteractType Create(IDartChampionOwnerInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartChampionOwnerInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x0600F39C RID: 62364 RVA: 0x00238A75 File Offset: 0x00236C75
		public override EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x0600F39D RID: 62365 RVA: 0x00238A82 File Offset: 0x00236C82
		public virtual int CompetitorId
		{
			get
			{
				return this.Instance.CompetitorId;
			}
		}

		// Token: 0x0400859A RID: 34202
		private IDartChampionOwnerInteractType Instance;
	}
}
