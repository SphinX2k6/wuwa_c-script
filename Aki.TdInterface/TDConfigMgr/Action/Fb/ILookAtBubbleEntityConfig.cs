using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A68 RID: 10856
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtBubbleEntityConfig
	{
		// Token: 0x0600EEC4 RID: 61124 RVA: 0x0022BD42 File Offset: 0x00229F42
		public static ILookAtBubbleEntityConfig Create(ILookAtBubbleEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtBubbleEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x0600EEC5 RID: 61125 RVA: 0x0022BD61 File Offset: 0x00229F61
		public virtual int BubbleEntity
		{
			get
			{
				return this.Instance.BubbleEntity;
			}
		}

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x0600EEC6 RID: 61126 RVA: 0x0022BD70 File Offset: 0x00229F70
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this._RangeEntitiesInited)
				{
					return this._RangeEntitiesCache;
				}
				this._RangeEntitiesInited = true;
				int rangeEntitiesLength = this.Instance.RangeEntitiesLength;
				this._RangeEntitiesCache = new List<int>(rangeEntitiesLength);
				for (int i = 0; i < rangeEntitiesLength; i++)
				{
					this._RangeEntitiesCache.Add(this.Instance.RangeEntities(i));
				}
				return this._RangeEntitiesCache;
			}
		}

		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x0600EEC7 RID: 61127 RVA: 0x0022BDD4 File Offset: 0x00229FD4
		[Nullable(2)]
		public virtual IEntityLookAtPerform EntityLookAtPerform
		{
			[NullableContext(2)]
			get
			{
				if (this._EntityLookAtPerformInited)
				{
					return this._EntityLookAtPerformCache;
				}
				this._EntityLookAtPerformInited = true;
				this._EntityLookAtPerformCache = IEntityLookAtPerform.Create(this.Instance.EntityLookAtPerform);
				return this._EntityLookAtPerformCache;
			}
		}

		// Token: 0x04008358 RID: 33624
		private ILookAtBubbleEntityConfig Instance;

		// Token: 0x04008359 RID: 33625
		private List<int> _RangeEntitiesCache;

		// Token: 0x0400835A RID: 33626
		private bool _RangeEntitiesInited;

		// Token: 0x0400835B RID: 33627
		[Nullable(2)]
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x0400835C RID: 33628
		private bool _EntityLookAtPerformInited;
	}
}
