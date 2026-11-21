using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1C RID: 3612
	public class ISceneTextGuideUiActionMappingIcon
	{
		// Token: 0x060051D9 RID: 20953 RVA: 0x000CA7DE File Offset: 0x000C89DE
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

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x000CA7FD File Offset: 0x000C89FD
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x000CA80A File Offset: 0x000C8A0A
		public virtual string ActionName
		{
			get
			{
				return this.Instance.ActionName;
			}
		}

		// Token: 0x04002EA9 RID: 11945
		private ISceneTextGuideUiActionMappingIcon Instance;
	}
}
