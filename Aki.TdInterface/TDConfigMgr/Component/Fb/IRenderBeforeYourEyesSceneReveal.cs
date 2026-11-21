using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E69 RID: 3689
	public class IRenderBeforeYourEyesSceneReveal : IRenderSpecifiedRangeType
	{
		// Token: 0x06005360 RID: 21344 RVA: 0x000CDB0F File Offset: 0x000CBD0F
		public static IRenderBeforeYourEyesSceneReveal Create(IRenderBeforeYourEyesSceneReveal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderBeforeYourEyesSceneReveal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x000CDB2E File Offset: 0x000CBD2E
		public override ERenderSpecifiedRangeType Type
		{
			get
			{
				return (ERenderSpecifiedRangeType)this.Instance.Type;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x000CDB3B File Offset: 0x000CBD3B
		public virtual ITargetEntityType CenterTarget
		{
			get
			{
				if (this._CenterTargetInited)
				{
					return this._CenterTargetCache;
				}
				this._CenterTargetInited = true;
				this._CenterTargetCache = ComponentReadHelper.ReadIRenderBeforeYourEyesSceneReveal_CenterTarget(this.Instance);
				return this._CenterTargetCache;
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x000CDB6C File Offset: 0x000CBD6C
		public virtual List<IRenderStateRadiusConfig> StateRadiusConfigs
		{
			get
			{
				if (this._StateRadiusConfigsInited)
				{
					return this._StateRadiusConfigsCache;
				}
				this._StateRadiusConfigsInited = true;
				int stateRadiusConfigsLength = this.Instance.StateRadiusConfigsLength;
				this._StateRadiusConfigsCache = new List<IRenderStateRadiusConfig>(stateRadiusConfigsLength);
				for (int i = 0; i < stateRadiusConfigsLength; i++)
				{
					this._StateRadiusConfigsCache.Add(IRenderStateRadiusConfig.Create(this.Instance.StateRadiusConfigs(i)));
				}
				return this._StateRadiusConfigsCache;
			}
		}

		// Token: 0x04002FA2 RID: 12194
		private IRenderBeforeYourEyesSceneReveal Instance;

		// Token: 0x04002FA3 RID: 12195
		private ITargetEntityType _CenterTargetCache;

		// Token: 0x04002FA4 RID: 12196
		private bool _CenterTargetInited;

		// Token: 0x04002FA5 RID: 12197
		private List<IRenderStateRadiusConfig> _StateRadiusConfigsCache;

		// Token: 0x04002FA6 RID: 12198
		private bool _StateRadiusConfigsInited;
	}
}
