using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C02 RID: 11266
	public class ITowerDungeonPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600F81C RID: 63516 RVA: 0x0024166D File Offset: 0x0023F86D
		public static ITowerDungeonPrefabConfig Create(ITowerDungeonPrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITowerDungeonPrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x0600F81D RID: 63517 RVA: 0x0024168C File Offset: 0x0023F88C
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x0600F81E RID: 63518 RVA: 0x00241699 File Offset: 0x0023F899
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x040087C6 RID: 34758
		private ITowerDungeonPrefabConfig Instance;
	}
}
