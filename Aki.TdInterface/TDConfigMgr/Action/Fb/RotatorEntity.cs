using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C6 RID: 10182
	[NullableContext(1)]
	[Nullable(0)]
	public class RotatorEntity : ActionParams
	{
		// Token: 0x0600E273 RID: 57971 RVA: 0x0021717D File Offset: 0x0021537D
		public static RotatorEntity Create(IRotatorEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RotatorEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x0600E274 RID: 57972 RVA: 0x0021719C File Offset: 0x0021539C
		public virtual ITargetEntityType Entity
		{
			get
			{
				if (this._EntityInited)
				{
					return this._EntityCache;
				}
				this._EntityInited = true;
				this._EntityCache = ActionReadHelper.ReadRotatorEntity_Entity(this.Instance);
				return this._EntityCache;
			}
		}

		// Token: 0x04007D94 RID: 32148
		private IRotatorEntity Instance;

		// Token: 0x04007D95 RID: 32149
		private ITargetEntityType _EntityCache;

		// Token: 0x04007D96 RID: 32150
		private bool _EntityInited;
	}
}
