using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FA RID: 10234
	public class IQiuyuanQinggongExploration4 : ILeisureInteractType
	{
		// Token: 0x0600E338 RID: 58168 RVA: 0x00218216 File Offset: 0x00216416
		[NullableContext(1)]
		public static IQiuyuanQinggongExploration4 Create(IQiuyuanQinggongExploration4? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration4
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x0600E339 RID: 58169 RVA: 0x00218235 File Offset: 0x00216435
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DDE RID: 32222
		private IQiuyuanQinggongExploration4 Instance;
	}
}
