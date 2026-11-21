using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E15 RID: 3605
	public class IConnectorPathAdvanceInitiator
	{
		// Token: 0x060051AC RID: 20908 RVA: 0x000CA2AE File Offset: 0x000C84AE
		public static IConnectorPathAdvanceInitiator Create(IConnectorPathAdvanceInitiator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceInitiator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x000CA2CD File Offset: 0x000C84CD
		public virtual string ActiveState
		{
			get
			{
				return this.Instance.ActiveState;
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x000CA2DC File Offset: 0x000C84DC
		public virtual List<int> Paths
		{
			get
			{
				if (this._PathsInited)
				{
					return this._PathsCache;
				}
				this._PathsInited = true;
				int pathsLength = this.Instance.PathsLength;
				this._PathsCache = new List<int>(pathsLength);
				for (int i = 0; i < pathsLength; i++)
				{
					this._PathsCache.Add(this.Instance.Paths(i));
				}
				return this._PathsCache;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x000CA340 File Offset: 0x000C8540
		public virtual int TargetEntity
		{
			get
			{
				return this.Instance.TargetEntity;
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x000CA34D File Offset: 0x000C854D
		public virtual float AdvanceSpeed
		{
			get
			{
				return this.Instance.AdvanceSpeed;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x000CA35A File Offset: 0x000C855A
		public virtual EConnectorPathAdvanceVisualType VisualType
		{
			get
			{
				return (EConnectorPathAdvanceVisualType)this.Instance.VisualType;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x000CA367 File Offset: 0x000C8567
		[Nullable(2)]
		public virtual IConnectorPathAdvanceVasePlantVisual VisualConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._VisualConfigInited)
				{
					return this._VisualConfigCache;
				}
				this._VisualConfigInited = true;
				this._VisualConfigCache = IConnectorPathAdvanceVasePlantVisual.Create(this.Instance.VisualConfig);
				return this._VisualConfigCache;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060051B3 RID: 20915 RVA: 0x000CA39C File Offset: 0x000C859C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._KeepConditionsInited)
				{
					return this._KeepConditionsCache;
				}
				this._KeepConditionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int keepConditionsLength = this.Instance.KeepConditionsLength;
				this._KeepConditionsCache = new List<IDynamicEntityMatch>(keepConditionsLength);
				for (int i = 0; i < keepConditionsLength; i++)
				{
					this._KeepConditionsCache.Add(IDynamicEntityMatch.Create(this.Instance.KeepConditions(i)));
				}
				return this._KeepConditionsCache;
			}
		}

		// Token: 0x04002E92 RID: 11922
		private IConnectorPathAdvanceInitiator Instance;

		// Token: 0x04002E93 RID: 11923
		private List<int> _PathsCache;

		// Token: 0x04002E94 RID: 11924
		private bool _PathsInited;

		// Token: 0x04002E95 RID: 11925
		[Nullable(2)]
		private IConnectorPathAdvanceVasePlantVisual _VisualConfigCache;

		// Token: 0x04002E96 RID: 11926
		private bool _VisualConfigInited;

		// Token: 0x04002E97 RID: 11927
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04002E98 RID: 11928
		private bool _KeepConditionsInited;
	}
}
