using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1B RID: 3355
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPathAdvanceInitiator
	{
		// Token: 0x06004C92 RID: 19602 RVA: 0x000BEBDA File Offset: 0x000BCDDA
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

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x000BEBF9 File Offset: 0x000BCDF9
		public virtual string ActiveState
		{
			get
			{
				return this.Instance.ActiveState;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x000BEC08 File Offset: 0x000BCE08
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

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06004C95 RID: 19605 RVA: 0x000BEC6C File Offset: 0x000BCE6C
		public virtual int TargetEntity
		{
			get
			{
				return this.Instance.TargetEntity;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x000BEC79 File Offset: 0x000BCE79
		public virtual float AdvanceSpeed
		{
			get
			{
				return this.Instance.AdvanceSpeed;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06004C97 RID: 19607 RVA: 0x000BEC86 File Offset: 0x000BCE86
		public virtual EConnectorPathAdvanceVisualType VisualType
		{
			get
			{
				return (EConnectorPathAdvanceVisualType)this.Instance.VisualType;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x000BEC93 File Offset: 0x000BCE93
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

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06004C99 RID: 19609 RVA: 0x000BECC8 File Offset: 0x000BCEC8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002BD2 RID: 11218
		private IConnectorPathAdvanceInitiator Instance;

		// Token: 0x04002BD3 RID: 11219
		private List<int> _PathsCache;

		// Token: 0x04002BD4 RID: 11220
		private bool _PathsInited;

		// Token: 0x04002BD5 RID: 11221
		[Nullable(2)]
		private IConnectorPathAdvanceVasePlantVisual _VisualConfigCache;

		// Token: 0x04002BD6 RID: 11222
		private bool _VisualConfigInited;

		// Token: 0x04002BD7 RID: 11223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04002BD8 RID: 11224
		private bool _KeepConditionsInited;
	}
}
