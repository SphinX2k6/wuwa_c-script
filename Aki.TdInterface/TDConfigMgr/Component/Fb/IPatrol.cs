using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B52 RID: 2898
	[NullableContext(2)]
	[Nullable(0)]
	public class IPatrol : IComponentBase
	{
		// Token: 0x0600423E RID: 16958 RVA: 0x000A86BD File Offset: 0x000A68BD
		[NullableContext(0)]
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

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x000A86DC File Offset: 0x000A68DC
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

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x000A8714 File Offset: 0x000A6914
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x000A872A File Offset: 0x000A692A
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x000A8738 File Offset: 0x000A6938
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

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x000A87AD File Offset: 0x000A69AD
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x000A87BC File Offset: 0x000A69BC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPatrolAction> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x040024B3 RID: 9395
		private IPatrol Instance;

		// Token: 0x040024B4 RID: 9396
		private List<int> _SplineEntityIdsCache;

		// Token: 0x040024B5 RID: 9397
		private bool _SplineEntityIdsInited;

		// Token: 0x040024B6 RID: 9398
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPatrolAction> _ActionsCache;

		// Token: 0x040024B7 RID: 9399
		private bool _ActionsInited;
	}
}
