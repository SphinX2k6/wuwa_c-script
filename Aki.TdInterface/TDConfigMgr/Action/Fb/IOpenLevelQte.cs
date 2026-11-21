using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC8 RID: 11464
	public class IOpenLevelQte : IOpenQteConfig
	{
		// Token: 0x0600FB54 RID: 64340 RVA: 0x00246895 File Offset: 0x00244A95
		public static IOpenLevelQte Create(IOpenLevelQte? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenLevelQte
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x0600FB55 RID: 64341 RVA: 0x002468B4 File Offset: 0x00244AB4
		public override EOpenQteType Type
		{
			get
			{
				return (EOpenQteType)this.Instance.Type;
			}
		}

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x0600FB56 RID: 64342 RVA: 0x002468C1 File Offset: 0x00244AC1
		public virtual ITargetEntityType LevelQteEntity
		{
			get
			{
				if (this._LevelQteEntityInited)
				{
					return this._LevelQteEntityCache;
				}
				this._LevelQteEntityInited = true;
				this._LevelQteEntityCache = ActionReadHelper.ReadIOpenLevelQte_LevelQteEntity(this.Instance);
				return this._LevelQteEntityCache;
			}
		}

		// Token: 0x04008950 RID: 35152
		private IOpenLevelQte Instance;

		// Token: 0x04008951 RID: 35153
		private ITargetEntityType _LevelQteEntityCache;

		// Token: 0x04008952 RID: 35154
		private bool _LevelQteEntityInited;
	}
}
