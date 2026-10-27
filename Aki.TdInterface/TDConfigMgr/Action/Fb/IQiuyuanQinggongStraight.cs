using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FB RID: 10235
	public class IQiuyuanQinggongStraight : ILeisureInteractType
	{
		// Token: 0x0600E33B RID: 58171 RVA: 0x0021824A File Offset: 0x0021644A
		[NullableContext(1)]
		public static IQiuyuanQinggongStraight Create(IQiuyuanQinggongStraight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongStraight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x0600E33C RID: 58172 RVA: 0x00218269 File Offset: 0x00216469
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DDF RID: 32223
		private IQiuyuanQinggongStraight Instance;
	}
}
