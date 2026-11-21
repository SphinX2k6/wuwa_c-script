using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC0 RID: 7360
	public class IHideWorldMonsterAndMonsterTreasureGroup : IHideGroupType
	{
		// Token: 0x06009C4A RID: 40010 RVA: 0x00168738 File Offset: 0x00166938
		private IHideWorldMonsterAndMonsterTreasureGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideWorldMonsterAndMonsterTreasureGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideWorldMonsterAndMonsterTreasureGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideWorldMonsterAndMonsterTreasureGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x00168770 File Offset: 0x00166970
		public static IHideWorldMonsterAndMonsterTreasureGroup Create([Nullable(2)] IHideWorldMonsterAndMonsterTreasureGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasureGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x00168783 File Offset: 0x00166983
		public static IHideWorldMonsterAndMonsterTreasureGroup CreateFromSetValue([Nullable(2)] IHideWorldMonsterAndMonsterTreasureGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasureGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x00168796 File Offset: 0x00166996
		public new IHideWorldMonsterAndMonsterTreasureGroup_SetValue ToSetValue()
		{
			return new IHideWorldMonsterAndMonsterTreasureGroup_SetValue
			{
				Type = this.Type,
				HideRangeEntities = this.HideRangeEntities
			};
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x06009C4E RID: 40014 RVA: 0x001687B5 File Offset: 0x001669B5
		// (set) Token: 0x06009C4F RID: 40015 RVA: 0x001687E0 File Offset: 0x001669E0
		public override EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x06009C50 RID: 40016 RVA: 0x001687EE File Offset: 0x001669EE
		// (set) Token: 0x06009C51 RID: 40017 RVA: 0x00168815 File Offset: 0x00166A15
		public virtual List<int> HideRangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideRangeEntities;
				}
				IHideWorldMonsterAndMonsterTreasureGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideRangeEntities;
			}
			set
			{
				this.GetOrCreatePoco().HideRangeEntities = value;
			}
		}

		// Token: 0x04005F99 RID: 24473
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasureGroup FbInstance;

		// Token: 0x04005F9A RID: 24474
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasureGroup_SetValue PocoInterface;
	}
}
