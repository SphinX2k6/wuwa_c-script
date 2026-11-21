using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9F RID: 3231
	public class INpcSpecialMarkTrafficLight : INpcSpecialMarkBase
	{
		// Token: 0x060049DA RID: 18906 RVA: 0x000BA079 File Offset: 0x000B8279
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

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060049DB RID: 18907 RVA: 0x000BA098 File Offset: 0x000B8298
		public override ESpecialNpcMarkType Type
		{
			get
			{
				return (ESpecialNpcMarkType)this.Instance.Type;
			}
		}

		// Token: 0x040029D2 RID: 10706
		private INpcSpecialMarkTrafficLight Instance;
	}
}
