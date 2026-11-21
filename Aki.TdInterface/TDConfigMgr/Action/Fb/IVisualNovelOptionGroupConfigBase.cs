using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283F RID: 10303
	public class IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600E542 RID: 58690 RVA: 0x0021DD4A File Offset: 0x0021BF4A
		public static IVisualNovelOptionGroupConfigBase Create(IVisualNovelOptionGroupConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x0600E543 RID: 58691 RVA: 0x0021DD69 File Offset: 0x0021BF69
		public virtual EVisualNovelOptionGroupType Type
		{
			get
			{
				return (EVisualNovelOptionGroupType)this.Instance.Type;
			}
		}

		// Token: 0x04007DC7 RID: 32199
		private IVisualNovelOptionGroupConfigBase Instance;
	}
}
