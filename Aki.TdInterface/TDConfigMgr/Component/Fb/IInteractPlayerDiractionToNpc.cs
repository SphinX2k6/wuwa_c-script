using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3C RID: 2876
	public class IInteractPlayerDiractionToNpc : IInteractPlayerDiractionType
	{
		// Token: 0x060041C9 RID: 16841 RVA: 0x000A77AD File Offset: 0x000A59AD
		public static IInteractPlayerDiractionToNpc Create(IInteractPlayerDiractionToNpc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToNpc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x000A77CC File Offset: 0x000A59CC
		public override EInteractPlayerDiractionType Type
		{
			get
			{
				return (EInteractPlayerDiractionType)this.Instance.Type;
			}
		}

		// Token: 0x0400246F RID: 9327
		private IInteractPlayerDiractionToNpc Instance;
	}
}
