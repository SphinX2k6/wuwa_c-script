using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001399 RID: 5017
	public class IShowUi
	{
		// Token: 0x060072B9 RID: 29369 RVA: 0x00113BA6 File Offset: 0x00111DA6
		[NullableContext(1)]
		public static IShowUi Create(IShowUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x060072BA RID: 29370 RVA: 0x00113BC5 File Offset: 0x00111DC5
		public virtual EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x04004257 RID: 16983
		private IShowUi Instance;
	}
}
