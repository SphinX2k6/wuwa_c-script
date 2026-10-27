using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C0 RID: 9664
	public class IPromptStyleDefault : IPromptStyleBase
	{
		// Token: 0x0600D956 RID: 55638 RVA: 0x00206B9C File Offset: 0x00204D9C
		[NullableContext(1)]
		public static IPromptStyleDefault Create(IPromptStyleDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x0600D957 RID: 55639 RVA: 0x00206BBB File Offset: 0x00204DBB
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078B8 RID: 30904
		private IPromptStyleDefault Instance;
	}
}
