using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F9 RID: 10233
	public class IQiuyuanQinggongExploration3 : ILeisureInteractType
	{
		// Token: 0x0600E335 RID: 58165 RVA: 0x002181E2 File Offset: 0x002163E2
		[NullableContext(1)]
		public static IQiuyuanQinggongExploration3 Create(IQiuyuanQinggongExploration3? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration3
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x0600E336 RID: 58166 RVA: 0x00218201 File Offset: 0x00216401
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DDD RID: 32221
		private IQiuyuanQinggongExploration3 Instance;
	}
}
