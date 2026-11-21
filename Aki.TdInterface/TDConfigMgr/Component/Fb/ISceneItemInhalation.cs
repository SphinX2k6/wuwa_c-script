using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E5A RID: 3674
	public class ISceneItemInhalation : IInhalationPerformanceType
	{
		// Token: 0x0600531A RID: 21274 RVA: 0x000CD391 File Offset: 0x000CB591
		public static ISceneItemInhalation Create(ISceneItemInhalation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemInhalation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x000CD3B0 File Offset: 0x000CB5B0
		public override EInhalationPerformanceType Type
		{
			get
			{
				return (EInhalationPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002F75 RID: 12149
		private ISceneItemInhalation Instance;
	}
}
