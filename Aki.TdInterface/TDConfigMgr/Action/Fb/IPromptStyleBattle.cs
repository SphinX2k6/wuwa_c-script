using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C2 RID: 9666
	public class IPromptStyleBattle : IPromptStyleBase
	{
		// Token: 0x0600D95C RID: 55644 RVA: 0x00206C04 File Offset: 0x00204E04
		[NullableContext(1)]
		public static IPromptStyleBattle Create(IPromptStyleBattle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBattle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x0600D95D RID: 55645 RVA: 0x00206C23 File Offset: 0x00204E23
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078BA RID: 30906
		private IPromptStyleBattle Instance;
	}
}
