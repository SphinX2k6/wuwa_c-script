using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DEA RID: 11754
	public class TetrisTriggerDelayFall : ActionParams
	{
		// Token: 0x0600FFAB RID: 65451 RVA: 0x0024D3BD File Offset: 0x0024B5BD
		public static TetrisTriggerDelayFall Create(ITetrisTriggerDelayFall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisTriggerDelayFall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008B8E RID: 35726
		private ITetrisTriggerDelayFall Instance;
	}
}
