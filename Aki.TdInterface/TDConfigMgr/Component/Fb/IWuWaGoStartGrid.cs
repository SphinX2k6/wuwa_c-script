using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F0F RID: 3855
	public class IWuWaGoStartGrid : IWuWaGoEntityBase
	{
		// Token: 0x060056A5 RID: 22181 RVA: 0x000D4870 File Offset: 0x000D2A70
		public static IWuWaGoStartGrid Create(IWuWaGoStartGrid? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoStartGrid
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x060056A6 RID: 22182 RVA: 0x000D488F File Offset: 0x000D2A8F
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x060056A7 RID: 22183 RVA: 0x000D489C File Offset: 0x000D2A9C
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

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x000D48D0 File Offset: 0x000D2AD0
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
				this._HintStepsCache = ComponentReadHelper.ReadIWuWaGoStartGrid_HintSteps(this.Instance);
				return this._HintStepsCache;
			}
		}

		// Token: 0x040031B8 RID: 12728
		private IWuWaGoStartGrid Instance;

		// Token: 0x040031B9 RID: 12729
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x040031BA RID: 12730
		private bool _LinkDataInited;

		// Token: 0x040031BB RID: 12731
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IWuWaGoHintStepBase> _HintStepsCache;

		// Token: 0x040031BC RID: 12732
		private bool _HintStepsInited;
	}
}
