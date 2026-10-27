using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B60 RID: 2912
	public class IBuildingBlockFoundation : IItemFoundationType
	{
		// Token: 0x06004312 RID: 17170 RVA: 0x000AB119 File Offset: 0x000A9319
		[NullableContext(1)]
		public static IBuildingBlockFoundation Create(IBuildingBlockFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuildingBlockFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06004313 RID: 17171 RVA: 0x000AB138 File Offset: 0x000A9338
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x040025DB RID: 9691
		private IBuildingBlockFoundation Instance;
	}
}
