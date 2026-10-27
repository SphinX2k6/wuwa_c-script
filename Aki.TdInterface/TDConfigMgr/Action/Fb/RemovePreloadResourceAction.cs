using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EC RID: 10732
	[NullableContext(1)]
	[Nullable(0)]
	public class RemovePreloadResourceAction : ActionParams
	{
		// Token: 0x0600ECFB RID: 60667 RVA: 0x002294FE File Offset: 0x002276FE
		public static RemovePreloadResourceAction Create(IRemovePreloadResourceAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemovePreloadResourceAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x0022951D File Offset: 0x0022771D
		public virtual IRemovePreloadResourceCharacterType RemovePreloadResourceObjectType
		{
			get
			{
				if (this._RemovePreloadResourceObjectTypeInited)
				{
					return this._RemovePreloadResourceObjectTypeCache;
				}
				this._RemovePreloadResourceObjectTypeInited = true;
				this._RemovePreloadResourceObjectTypeCache = ActionReadHelper.ReadRemovePreloadResourceAction_RemovePreloadResourceObjectType(this.Instance);
				return this._RemovePreloadResourceObjectTypeCache;
			}
		}

		// Token: 0x04008282 RID: 33410
		private IRemovePreloadResourceAction Instance;

		// Token: 0x04008283 RID: 33411
		private IRemovePreloadResourceCharacterType _RemovePreloadResourceObjectTypeCache;

		// Token: 0x04008284 RID: 33412
		private bool _RemovePreloadResourceObjectTypeInited;
	}
}
