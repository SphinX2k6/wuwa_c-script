using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296A RID: 10602
	public class StopUiScreenEffect : ActionParams
	{
		// Token: 0x0600EB53 RID: 60243 RVA: 0x0022AE6F File Offset: 0x0022906F
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

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x0600EB54 RID: 60244 RVA: 0x0022AE8E File Offset: 0x0022908E
		public virtual string EffectDaPath
		{
			get
			{
				return this.Instance.EffectDaPath;
			}
		}

		// Token: 0x0400819C RID: 33180
		private IStopUiScreenEffect Instance;
	}
}
