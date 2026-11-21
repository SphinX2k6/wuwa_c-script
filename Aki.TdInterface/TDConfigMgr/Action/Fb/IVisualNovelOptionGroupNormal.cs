using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002840 RID: 10304
	public class IVisualNovelOptionGroupNormal : IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600E545 RID: 58693 RVA: 0x0021DD7E File Offset: 0x0021BF7E
		public static IVisualNovelOptionGroupNormal Create(IVisualNovelOptionGroupNormal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupNormal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x0600E546 RID: 58694 RVA: 0x0021DD9D File Offset: 0x0021BF9D
		public override EVisualNovelOptionGroupType Type
		{
			get
			{
				return (EVisualNovelOptionGroupType)this.Instance.Type;
			}
		}

		// Token: 0x04007DC8 RID: 32200
		private IVisualNovelOptionGroupNormal Instance;
	}
}
