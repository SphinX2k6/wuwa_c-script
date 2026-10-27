using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A7 RID: 9895
	[NullableContext(1)]
	[Nullable(0)]
	public class StopUiScreenEffect : ActionParams
	{
		// Token: 0x0600DD7C RID: 56700 RVA: 0x0020E6CF File Offset: 0x0020C8CF
		public static StopUiScreenEffect Create(IStopUiScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopUiScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x0600DD7D RID: 56701 RVA: 0x0020E6EE File Offset: 0x0020C8EE
		public virtual string EffectDaPath
		{
			get
			{
				return this.Instance.EffectDaPath;
			}
		}

		// Token: 0x04007AFF RID: 31487
		private IStopUiScreenEffect Instance;
	}
}
