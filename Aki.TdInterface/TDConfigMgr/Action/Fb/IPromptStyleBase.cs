using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025BF RID: 9663
	public class IPromptStyleBase
	{
		// Token: 0x0600D953 RID: 55635 RVA: 0x00206B68 File Offset: 0x00204D68
		[NullableContext(1)]
		public static IPromptStyleBase Create(IPromptStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x0600D954 RID: 55636 RVA: 0x00206B87 File Offset: 0x00204D87
		public virtual EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078B7 RID: 30903
		private IPromptStyleBase Instance;
	}
}
