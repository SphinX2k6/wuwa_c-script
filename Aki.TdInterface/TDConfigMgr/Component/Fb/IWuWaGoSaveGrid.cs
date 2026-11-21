using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F0D RID: 3853
	public class IWuWaGoSaveGrid : IWuWaGoEntityBase
	{
		// Token: 0x0600569C RID: 22172 RVA: 0x000D4760 File Offset: 0x000D2960
		public static IWuWaGoSaveGrid Create(IWuWaGoSaveGrid? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoSaveGrid
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x000D477F File Offset: 0x000D297F
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x0600569E RID: 22174 RVA: 0x000D478C File Offset: 0x000D298C
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				this._LinkDataCache = IWuWaGoGridLinkData.Create(this.Instance.LinkData);
				return this._LinkDataCache;
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x0600569F RID: 22175 RVA: 0x000D47C0 File Offset: 0x000D29C0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IWuWaGoHintStepBase> HintSteps
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._HintStepsInited)
				{
					return this._HintStepsCache;
				}
				this._HintStepsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				this._HintStepsCache = ComponentReadHelper.ReadIWuWaGoSaveGrid_HintSteps(this.Instance);
				return this._HintStepsCache;
			}
		}

		// Token: 0x040031B0 RID: 12720
		private IWuWaGoSaveGrid Instance;

		// Token: 0x040031B1 RID: 12721
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x040031B2 RID: 12722
		private bool _LinkDataInited;

		// Token: 0x040031B3 RID: 12723
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IWuWaGoHintStepBase> _HintStepsCache;

		// Token: 0x040031B4 RID: 12724
		private bool _HintStepsInited;
	}
}
