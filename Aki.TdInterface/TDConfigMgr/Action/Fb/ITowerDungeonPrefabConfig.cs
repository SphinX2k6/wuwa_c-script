using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002926 RID: 10534
	public class ITowerDungeonPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600E9CA RID: 59850 RVA: 0x00224315 File Offset: 0x00222515
		[NullableContext(1)]
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

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x0600E9CB RID: 59851 RVA: 0x00224334 File Offset: 0x00222534
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x00224341 File Offset: 0x00222541
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x040080F8 RID: 33016
		private ITowerDungeonPrefabConfig Instance;
	}
}
