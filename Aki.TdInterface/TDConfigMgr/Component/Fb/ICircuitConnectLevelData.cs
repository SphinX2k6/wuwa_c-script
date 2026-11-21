using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F59 RID: 3929
	public class ICircuitConnectLevelData
	{
		// Token: 0x0600580E RID: 22542 RVA: 0x000D74E6 File Offset: 0x000D56E6
		public static ICircuitConnectLevelData Create(ICircuitConnectLevelData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectLevelData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600580F RID: 22543 RVA: 0x000D7505 File Offset: 0x000D5705
		public virtual ICircuitConnectModeBase Mode
		{
			get
			{
				if (this._ModeInited)
				{
					return this._ModeCache;
				}
				this._ModeInited = true;
				this._ModeCache = ComponentReadHelper.ReadICircuitConnectLevelData_Mode(this.Instance);
				return this._ModeCache;
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x000D7534 File Offset: 0x000D5734
		public virtual float RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06005811 RID: 22545 RVA: 0x000D7541 File Offset: 0x000D5741
		public virtual float ConnectTolerance
		{
			get
			{
				return this.Instance.ConnectTolerance;
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x000D7550 File Offset: 0x000D5750
		public virtual List<ICircuitConnectLinkageGroup> LinkageGroups
		{
			get
			{
				if (this._LinkageGroupsInited)
				{
					return this._LinkageGroupsCache;
				}
				this._LinkageGroupsInited = true;
				int linkageGroupsLength = this.Instance.LinkageGroupsLength;
				this._LinkageGroupsCache = new List<ICircuitConnectLinkageGroup>(linkageGroupsLength);
				for (int i = 0; i < linkageGroupsLength; i++)
				{
					this._LinkageGroupsCache.Add(ICircuitConnectLinkageGroup.Create(this.Instance.LinkageGroups(i)));
				}
				return this._LinkageGroupsCache;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06005813 RID: 22547 RVA: 0x000D75BC File Offset: 0x000D57BC
		public virtual List<ICircuitConnectLayout> Layout
		{
			get
			{
				if (this._LayoutInited)
				{
					return this._LayoutCache;
				}
				this._LayoutInited = true;
				int layoutLength = this.Instance.LayoutLength;
				this._LayoutCache = new List<ICircuitConnectLayout>(layoutLength);
				for (int i = 0; i < layoutLength; i++)
				{
					this._LayoutCache.Add(ICircuitConnectLayout.Create(this.Instance.Layout(i)));
				}
				return this._LayoutCache;
			}
		}

		// Token: 0x0400328C RID: 12940
		private ICircuitConnectLevelData Instance;

		// Token: 0x0400328D RID: 12941
		private ICircuitConnectModeBase _ModeCache;

		// Token: 0x0400328E RID: 12942
		private bool _ModeInited;

		// Token: 0x0400328F RID: 12943
		private List<ICircuitConnectLinkageGroup> _LinkageGroupsCache;

		// Token: 0x04003290 RID: 12944
		private bool _LinkageGroupsInited;

		// Token: 0x04003291 RID: 12945
		private List<ICircuitConnectLayout> _LayoutCache;

		// Token: 0x04003292 RID: 12946
		private bool _LayoutInited;
	}
}
