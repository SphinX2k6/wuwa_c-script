using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DB RID: 10715
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenLevelQte : IOpenQteConfig
	{
		// Token: 0x0600ECBD RID: 60605 RVA: 0x00228F11 File Offset: 0x00227111
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

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x0600ECBE RID: 60606 RVA: 0x00228F30 File Offset: 0x00227130
		public override EOpenQteType Type
		{
			get
			{
				return (EOpenQteType)this.Instance.Type;
			}
		}

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x0600ECBF RID: 60607 RVA: 0x00228F3D File Offset: 0x0022713D
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

		// Token: 0x0400825F RID: 33375
		private IOpenLevelQte Instance;

		// Token: 0x04008260 RID: 33376
		private ITargetEntityType _LevelQteEntityCache;

		// Token: 0x04008261 RID: 33377
		private bool _LevelQteEntityInited;
	}
}
