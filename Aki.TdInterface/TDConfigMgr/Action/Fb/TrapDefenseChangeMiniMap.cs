using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A89 RID: 10889
	public class TrapDefenseChangeMiniMap : ActionParams
	{
		// Token: 0x0600EF48 RID: 61256 RVA: 0x0022CB5C File Offset: 0x0022AD5C
		[NullableContext(1)]
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

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x0600EF49 RID: 61257 RVA: 0x0022CB7B File Offset: 0x0022AD7B
		public virtual int MiniMapId
		{
			get
			{
				return this.Instance.MiniMapId;
			}
		}

		// Token: 0x040083A9 RID: 33705
		private ITrapDefenseChangeMiniMap Instance;
	}
}
