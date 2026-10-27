using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A88 RID: 2696
	[NullableContext(2)]
	[Nullable(0)]
	public class IPatrol : IComponentBase
	{
		// Token: 0x06003E15 RID: 15893 RVA: 0x0009F105 File Offset: 0x0009D305
		[NullableContext(1)]
		public static IPatrol Create(IPatrol? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrol
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x0009F124 File Offset: 0x0009D324
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x0009F15C File Offset: 0x0009D35C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x0009F172 File Offset: 0x0009D372
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06003E19 RID: 15897 RVA: 0x0009F180 File Offset: 0x0009D380
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this._SplineEntityIdsInited)
				{
					return this._SplineEntityIdsCache;
				}
				this._SplineEntityIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int splineEntityIdsLength = this.Instance.SplineEntityIdsLength;
				this._SplineEntityIdsCache = new List<int>(splineEntityIdsLength);
				for (int i = 0; i < splineEntityIdsLength; i++)
				{
					this._SplineEntityIdsCache.Add(this.Instance.SplineEntityIds(i));
				}
				return this._SplineEntityIdsCache;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x0009F1F5 File Offset: 0x0009D3F5
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x0009F204 File Offset: 0x0009D404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IPatrolAction> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<IPatrolAction>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(IPatrolAction.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x04002297 RID: 8855
		private IPatrol Instance;

		// Token: 0x04002298 RID: 8856
		private List<int> _SplineEntityIdsCache;

		// Token: 0x04002299 RID: 8857
		private bool _SplineEntityIdsInited;

		// Token: 0x0400229A RID: 8858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPatrolAction> _ActionsCache;

		// Token: 0x0400229B RID: 8859
		private bool _ActionsInited;
	}
}
