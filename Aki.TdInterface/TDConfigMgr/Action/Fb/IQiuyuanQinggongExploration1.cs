using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F7 RID: 10231
	public class IQiuyuanQinggongExploration1 : ILeisureInteractType
	{
		// Token: 0x0600E32F RID: 58159 RVA: 0x0021817A File Offset: 0x0021637A
		[NullableContext(1)]
		public static IQiuyuanQinggongExploration1 Create(IQiuyuanQinggongExploration1? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration1
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x0600E330 RID: 58160 RVA: 0x00218199 File Offset: 0x00216399
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DDB RID: 32219
		private IQiuyuanQinggongExploration1 Instance;
	}
}
