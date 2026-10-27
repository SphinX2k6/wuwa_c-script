using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200145A RID: 5210
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByEntityType : IRecallConditionBase
	{
		// Token: 0x06007667 RID: 30311 RVA: 0x0011AC35 File Offset: 0x00118E35
		public static IRecallConditionByEntityType Create(IRecallConditionByEntityType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByEntityType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x0011AC54 File Offset: 0x00118E54
		public override ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x06007669 RID: 30313 RVA: 0x0011AC61 File Offset: 0x00118E61
		public override ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600766A RID: 30314 RVA: 0x0011AC70 File Offset: 0x00118E70
		public virtual List<string> EntityTypes
		{
			get
			{
				if (this._EntityTypesInited)
				{
					return this._EntityTypesCache;
				}
				this._EntityTypesInited = true;
				int entityTypesLength = this.Instance.EntityTypesLength;
				this._EntityTypesCache = new List<string>(entityTypesLength);
				for (int i = 0; i < entityTypesLength; i++)
				{
					this._EntityTypesCache.Add(this.Instance.EntityTypes(i));
				}
				return this._EntityTypesCache;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600766B RID: 30315 RVA: 0x0011ACD4 File Offset: 0x00118ED4
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x040044BE RID: 17598
		private IRecallConditionByEntityType Instance;

		// Token: 0x040044BF RID: 17599
		private List<string> _EntityTypesCache;

		// Token: 0x040044C0 RID: 17600
		private bool _EntityTypesInited;

		// Token: 0x040044C1 RID: 17601
		private List<int> _AreaIdsCache;

		// Token: 0x040044C2 RID: 17602
		private bool _AreaIdsInited;
	}
}
