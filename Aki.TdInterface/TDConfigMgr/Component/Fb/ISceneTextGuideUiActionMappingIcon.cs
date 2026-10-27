using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D22 RID: 3362
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextGuideUiActionMappingIcon
	{
		// Token: 0x06004CBD RID: 19645 RVA: 0x000BF09A File Offset: 0x000BD29A
		public static ISceneTextGuideUiActionMappingIcon Create(ISceneTextGuideUiActionMappingIcon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUiActionMappingIcon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x000BF0B9 File Offset: 0x000BD2B9
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x000BF0C6 File Offset: 0x000BD2C6
		public virtual string ActionName
		{
			get
			{
				return this.Instance.ActionName;
			}
		}

		// Token: 0x04002BE9 RID: 11241
		private ISceneTextGuideUiActionMappingIcon Instance;
	}
}
