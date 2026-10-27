using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C1 RID: 9665
	public class IPromptStylePhoto : IPromptStyleBase
	{
		// Token: 0x0600D959 RID: 55641 RVA: 0x00206BD0 File Offset: 0x00204DD0
		[NullableContext(1)]
		public static IPromptStylePhoto Create(IPromptStylePhoto? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStylePhoto
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x0600D95A RID: 55642 RVA: 0x00206BEF File Offset: 0x00204DEF
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078B9 RID: 30905
		private IPromptStylePhoto Instance;
	}
}
