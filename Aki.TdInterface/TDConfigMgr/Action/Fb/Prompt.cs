using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F3 RID: 9459
	public class Prompt : ActionParams
	{
		// Token: 0x0600D339 RID: 54073 RVA: 0x001F530E File Offset: 0x001F350E
		[NullableContext(1)]
		public static Prompt Create(IPrompt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Prompt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0600D33A RID: 54074 RVA: 0x001F532D File Offset: 0x001F352D
		public virtual int GeneralTextId
		{
			get
			{
				return this.Instance.GeneralTextId;
			}
		}

		// Token: 0x040073D1 RID: 29649
		private IPrompt Instance;
	}
}
