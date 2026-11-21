using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D7D RID: 11645
	public class TrapDefenseChangeMiniMap : ActionParams
	{
		// Token: 0x0600FDFE RID: 65022 RVA: 0x0024A868 File Offset: 0x00248A68
		public static TrapDefenseChangeMiniMap Create(ITrapDefenseChangeMiniMap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TrapDefenseChangeMiniMap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FB2 RID: 20402
		// (get) Token: 0x0600FDFF RID: 65023 RVA: 0x0024A887 File Offset: 0x00248A87
		public virtual int MiniMapId
		{
			get
			{
				return this.Instance.MiniMapId;
			}
		}

		// Token: 0x04008AAD RID: 35501
		private ITrapDefenseChangeMiniMap Instance;
	}
}
