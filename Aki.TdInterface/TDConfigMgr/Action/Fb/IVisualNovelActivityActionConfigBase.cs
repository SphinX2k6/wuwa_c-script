using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200258E RID: 9614
	public class IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600D7BC RID: 55228 RVA: 0x00201F02 File Offset: 0x00200102
		[NullableContext(1)]
		public static IVisualNovelActivityActionConfigBase Create(IVisualNovelActivityActionConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelActivityActionConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0600D7BD RID: 55229 RVA: 0x00201F21 File Offset: 0x00200121
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x0400775C RID: 30556
		private IVisualNovelActivityActionConfigBase Instance;
	}
}
