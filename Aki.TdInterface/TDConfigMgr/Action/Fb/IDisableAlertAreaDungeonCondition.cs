using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EF RID: 10735
	public class IDisableAlertAreaDungeonCondition : IDisableAlertAreaCondition
	{
		// Token: 0x0600ED05 RID: 60677 RVA: 0x002295C9 File Offset: 0x002277C9
		[NullableContext(1)]
		public static IDisableAlertAreaDungeonCondition Create(IDisableAlertAreaDungeonCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaDungeonCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AE9 RID: 19177
		// (get) Token: 0x0600ED06 RID: 60678 RVA: 0x002295E8 File Offset: 0x002277E8
		public override EDisableAlertAreaCondition Type
		{
			get
			{
				return (EDisableAlertAreaCondition)this.Instance.Type;
			}
		}

		// Token: 0x17004AEA RID: 19178
		// (get) Token: 0x0600ED07 RID: 60679 RVA: 0x002295F5 File Offset: 0x002277F5
		public virtual int RelatedDungeonId
		{
			get
			{
				return this.Instance.RelatedDungeonId;
			}
		}

		// Token: 0x04008287 RID: 33415
		private IDisableAlertAreaDungeonCondition Instance;
	}
}
