using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001400 RID: 5120
	public class IPhotographTargetRolesOnScene : IPhotographTarget
	{
		// Token: 0x06007475 RID: 29813 RVA: 0x00116913 File Offset: 0x00114B13
		[NullableContext(1)]
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

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x00116932 File Offset: 0x00114B32
		public override EPhotographTargetType Type
		{
			get
			{
				return (EPhotographTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04004364 RID: 17252
		private IPhotographTargetRolesOnScene Instance;
	}
}
