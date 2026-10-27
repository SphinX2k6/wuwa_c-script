using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C3 RID: 9667
	public class IPromptStyleBattle2 : IPromptStyleBase
	{
		// Token: 0x0600D95F RID: 55647 RVA: 0x00206C38 File Offset: 0x00204E38
		[NullableContext(1)]
		public static IPromptStyleBattle2 Create(IPromptStyleBattle2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBattle2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x0600D960 RID: 55648 RVA: 0x00206C57 File Offset: 0x00204E57
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078BB RID: 30907
		private IPromptStyleBattle2 Instance;
	}
}
