using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E11 RID: 3601
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoSaveGrid : IWuWaGoEntityBase
	{
		// Token: 0x06005175 RID: 20853 RVA: 0x000C8E98 File Offset: 0x000C7098
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x000C8EB7 File Offset: 0x000C70B7
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x000C8EC4 File Offset: 0x000C70C4
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

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x000C8EF8 File Offset: 0x000C70F8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IWuWaGoHintStepBase> HintSteps
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002EE8 RID: 12008
		private IWuWaGoSaveGrid Instance;

		// Token: 0x04002EE9 RID: 12009
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04002EEA RID: 12010
		private bool _LinkDataInited;

		// Token: 0x04002EEB RID: 12011
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IWuWaGoHintStepBase> _HintStepsCache;

		// Token: 0x04002EEC RID: 12012
		private bool _HintStepsInited;
	}
}
