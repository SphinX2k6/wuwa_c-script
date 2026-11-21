using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000272 RID: 626
	public class ICircuitConnectLevelData
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x0002D4EC File Offset: 0x0002B6EC
		private ICircuitConnectLevelData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectLevelData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectLevelData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectLevelData_SetValue());
			}
			return result;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0002D524 File Offset: 0x0002B724
		public static ICircuitConnectLevelData Create([Nullable(2)] ICircuitConnectLevelData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectLevelData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002D537 File Offset: 0x0002B737
		public static ICircuitConnectLevelData CreateFromSetValue([Nullable(2)] ICircuitConnectLevelData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectLevelData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002D54C File Offset: 0x0002B74C
		public ICircuitConnectLevelData_SetValue ToSetValue()
		{
			return new ICircuitConnectLevelData_SetValue
			{
				Mode = this.Mode,
				RotationSpeed = this.RotationSpeed,
				ConnectTolerance = this.ConnectTolerance,
				LinkageGroups = this.LinkageGroups,
				Layout = this.Layout
			};
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0002D59A File Offset: 0x0002B79A
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0002D5C1 File Offset: 0x0002B7C1
		public virtual ICircuitConnectModeBase Mode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mode;
				}
				ICircuitConnectLevelData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Mode;
			}
			set
			{
				this.GetOrCreatePoco().Mode = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002D5CF File Offset: 0x0002B7CF
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0002D5FE File Offset: 0x0002B7FE
		public virtual float RotationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RotationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().RotationSpeed = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0002D60C File Offset: 0x0002B80C
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0002D63B File Offset: 0x0002B83B
		public virtual float ConnectTolerance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConnectTolerance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ConnectTolerance;
			}
			set
			{
				this.GetOrCreatePoco().ConnectTolerance = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0002D64C File Offset: 0x0002B84C
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x0002D6DF File Offset: 0x0002B8DF
		public virtual List<ICircuitConnectLinkageGroup> LinkageGroups
		{
			get
			{
				if (this._LinkageGroupsInited)
				{
					return this._LinkageGroupsCache;
				}
				this._LinkageGroupsInited = true;
				if (this.FbInstance != null)
				{
					List<ICircuitConnectLinkageGroup> linkageGroups = this.FbInstance.LinkageGroups;
					if (linkageGroups != null)
					{
						this._LinkageGroupsCache = new List<ICircuitConnectLinkageGroup>(linkageGroups.Count);
						for (int i = 0; i < linkageGroups.Count; i++)
						{
							this._LinkageGroupsCache.Add(ICircuitConnectLinkageGroup.Create(linkageGroups[i]));
						}
					}
				}
				else
				{
					ICircuitConnectLevelData_SetValue pocoInterface = this.PocoInterface;
					this._LinkageGroupsCache = ((pocoInterface != null) ? pocoInterface.LinkageGroups : null);
				}
				return this._LinkageGroupsCache;
			}
			set
			{
				this.GetOrCreatePoco().LinkageGroups = value;
				this._LinkageGroupsInited = false;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0002D6F4 File Offset: 0x0002B8F4
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0002D787 File Offset: 0x0002B987
		public virtual List<ICircuitConnectLayout> Layout
		{
			get
			{
				if (this._LayoutInited)
				{
					return this._LayoutCache;
				}
				this._LayoutInited = true;
				if (this.FbInstance != null)
				{
					List<ICircuitConnectLayout> layout = this.FbInstance.Layout;
					if (layout != null)
					{
						this._LayoutCache = new List<ICircuitConnectLayout>(layout.Count);
						for (int i = 0; i < layout.Count; i++)
						{
							this._LayoutCache.Add(ICircuitConnectLayout.Create(layout[i]));
						}
					}
				}
				else
				{
					ICircuitConnectLevelData_SetValue pocoInterface = this.PocoInterface;
					this._LayoutCache = ((pocoInterface != null) ? pocoInterface.Layout : null);
				}
				return this._LayoutCache;
			}
			set
			{
				this.GetOrCreatePoco().Layout = value;
				this._LayoutInited = false;
			}
		}

		// Token: 0x04000B0B RID: 2827
		[Nullable(2)]
		protected ICircuitConnectLevelData FbInstance;

		// Token: 0x04000B0C RID: 2828
		[Nullable(2)]
		protected ICircuitConnectLevelData_SetValue PocoInterface;

		// Token: 0x04000B0D RID: 2829
		private List<ICircuitConnectLinkageGroup> _LinkageGroupsCache;

		// Token: 0x04000B0E RID: 2830
		private bool _LinkageGroupsInited;

		// Token: 0x04000B0F RID: 2831
		private List<ICircuitConnectLayout> _LayoutCache;

		// Token: 0x04000B10 RID: 2832
		private bool _LayoutInited;
	}
}
