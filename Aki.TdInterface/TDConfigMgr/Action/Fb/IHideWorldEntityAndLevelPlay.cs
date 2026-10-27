using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278B RID: 10123
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlay : IHideRangeType
	{
		// Token: 0x0600E161 RID: 57697 RVA: 0x00214D93 File Offset: 0x00212F93
		[NullableContext(1)]
		public static IHideWorldEntityAndLevelPlay Create(IHideWorldEntityAndLevelPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldEntityAndLevelPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700440D RID: 17421
		// (get) Token: 0x0600E162 RID: 57698 RVA: 0x00214DB2 File Offset: 0x00212FB2
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x1700440E RID: 17422
		// (get) Token: 0x0600E163 RID: 57699 RVA: 0x00214DC0 File Offset: 0x00212FC0
		public virtual List<int> ExcludeEntities
		{
			get
			{
				if (this._ExcludeEntitiesInited)
				{
					return this._ExcludeEntitiesCache;
				}
				this._ExcludeEntitiesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int excludeEntitiesLength = this.Instance.ExcludeEntitiesLength;
				this._ExcludeEntitiesCache = new List<int>(excludeEntitiesLength);
				for (int i = 0; i < excludeEntitiesLength; i++)
				{
					this._ExcludeEntitiesCache.Add(this.Instance.ExcludeEntities(i));
				}
				return this._ExcludeEntitiesCache;
			}
		}

		// Token: 0x04007CEF RID: 31983
		private IHideWorldEntityAndLevelPlay Instance;

		// Token: 0x04007CF0 RID: 31984
		private List<int> _ExcludeEntitiesCache;

		// Token: 0x04007CF1 RID: 31985
		private bool _ExcludeEntitiesInited;
	}
}
