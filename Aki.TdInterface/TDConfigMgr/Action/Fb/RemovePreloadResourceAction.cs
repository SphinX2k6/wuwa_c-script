using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD9 RID: 11481
	public class RemovePreloadResourceAction : ActionParams
	{
		// Token: 0x0600FB92 RID: 64402 RVA: 0x00246E82 File Offset: 0x00245082
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

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x0600FB93 RID: 64403 RVA: 0x00246EA1 File Offset: 0x002450A1
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

		// Token: 0x04008973 RID: 35187
		private IRemovePreloadResourceAction Instance;

		// Token: 0x04008974 RID: 35188
		private IRemovePreloadResourceCharacterType _RemovePreloadResourceObjectTypeCache;

		// Token: 0x04008975 RID: 35189
		private bool _RemovePreloadResourceObjectTypeInited;
	}
}
