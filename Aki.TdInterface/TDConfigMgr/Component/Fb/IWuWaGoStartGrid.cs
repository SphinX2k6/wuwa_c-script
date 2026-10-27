using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E13 RID: 3603
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoStartGrid : IWuWaGoEntityBase
	{
		// Token: 0x0600517E RID: 20862 RVA: 0x000C8FA8 File Offset: 0x000C71A8
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

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x0600517F RID: 20863 RVA: 0x000C8FC7 File Offset: 0x000C71C7
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x000C8FD4 File Offset: 0x000C71D4
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

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x000C9008 File Offset: 0x000C7208
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
				this._HintStepsCache = ComponentReadHelper.ReadIWuWaGoStartGrid_HintSteps(this.Instance);
				return this._HintStepsCache;
			}
		}

		// Token: 0x04002EF0 RID: 12016
		private IWuWaGoStartGrid Instance;

		// Token: 0x04002EF1 RID: 12017
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04002EF2 RID: 12018
		private bool _LinkDataInited;

		// Token: 0x04002EF3 RID: 12019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IWuWaGoHintStepBase> _HintStepsCache;

		// Token: 0x04002EF4 RID: 12020
		private bool _HintStepsInited;
	}
}
