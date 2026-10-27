using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026EC RID: 9964
	public class IMonsterMoveSplineConfig
	{
		// Token: 0x0600DE8C RID: 56972 RVA: 0x00210428 File Offset: 0x0020E628
		[NullableContext(1)]
		public static IMonsterMoveSplineConfig Create(IMonsterMoveSplineConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterMoveSplineConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0600DE8D RID: 56973 RVA: 0x00210447 File Offset: 0x0020E647
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x0600DE8E RID: 56974 RVA: 0x00210454 File Offset: 0x0020E654
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04007B88 RID: 31624
		private IMonsterMoveSplineConfig Instance;
	}
}
