using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD1 RID: 3025
	public class INpcSpecialMarkTrafficLight : INpcSpecialMarkBase
	{
		// Token: 0x06004581 RID: 17793 RVA: 0x000AFFB5 File Offset: 0x000AE1B5
		[NullableContext(1)]
		public static INpcSpecialMarkTrafficLight Create(INpcSpecialMarkTrafficLight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkTrafficLight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x000AFFD4 File Offset: 0x000AE1D4
		public override ESpecialNpcMarkType Type
		{
			get
			{
				return (ESpecialNpcMarkType)this.Instance.Type;
			}
		}

		// Token: 0x0400278A RID: 10122
		private INpcSpecialMarkTrafficLight Instance;
	}
}
