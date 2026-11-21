using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001557 RID: 5463
	public class IPhotographTargetRolesOnScene : IPhotographTarget
	{
		// Token: 0x06007B36 RID: 31542 RVA: 0x001252F7 File Offset: 0x001234F7
		public static IPhotographTargetRolesOnScene Create(IPhotographTargetRolesOnScene? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographTargetRolesOnScene
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x06007B37 RID: 31543 RVA: 0x00125316 File Offset: 0x00123516
		public override EPhotographTargetType Type
		{
			get
			{
				return (EPhotographTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040046F5 RID: 18165
		private IPhotographTargetRolesOnScene Instance;
	}
}
