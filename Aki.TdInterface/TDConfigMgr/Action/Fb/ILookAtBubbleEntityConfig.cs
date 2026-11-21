using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D5C RID: 11612
	public class ILookAtBubbleEntityConfig
	{
		// Token: 0x0600FD7A RID: 64890 RVA: 0x00249A4E File Offset: 0x00247C4E
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

		// Token: 0x17004F70 RID: 20336
		// (get) Token: 0x0600FD7B RID: 64891 RVA: 0x00249A6D File Offset: 0x00247C6D
		public virtual int BubbleEntity
		{
			get
			{
				return this.Instance.BubbleEntity;
			}
		}

		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x0600FD7C RID: 64892 RVA: 0x00249A7C File Offset: 0x00247C7C
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

		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x0600FD7D RID: 64893 RVA: 0x00249AE0 File Offset: 0x00247CE0
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

		// Token: 0x04008A5C RID: 35420
		private ILookAtBubbleEntityConfig Instance;

		// Token: 0x04008A5D RID: 35421
		private List<int> _RangeEntitiesCache;

		// Token: 0x04008A5E RID: 35422
		private bool _RangeEntitiesInited;

		// Token: 0x04008A5F RID: 35423
		[Nullable(2)]
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x04008A60 RID: 35424
		private bool _EntityLookAtPerformInited;
	}
}
