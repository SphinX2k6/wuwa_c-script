using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002929 RID: 10537
	public class IRoleTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600E9D6 RID: 59862 RVA: 0x002243D8 File Offset: 0x002225D8
		[NullableContext(1)]
		public static IRoleTowerPrefabConfig Create(IRoleTowerPrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerPrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x0600E9D7 RID: 59863 RVA: 0x002243F7 File Offset: 0x002225F7
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x040080FB RID: 33019
		private IRoleTowerPrefabConfig Instance;
	}
}
