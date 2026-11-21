using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD2 RID: 11474
	public class IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600FB78 RID: 64376 RVA: 0x00246C2F File Offset: 0x00244E2F
		public static IRemovePreloadResourceCharacterType Create(IRemovePreloadResourceCharacterType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourceCharacterType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x0600FB79 RID: 64377 RVA: 0x00246C4E File Offset: 0x00244E4E
		public virtual ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x04008966 RID: 35174
		private IRemovePreloadResourceCharacterType Instance;
	}
}
