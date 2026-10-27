using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B05 RID: 6917
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyEntity : IHideRangeType
	{
		// Token: 0x0600941C RID: 37916 RVA: 0x00157350 File Offset: 0x00155550
		private IHideSpecifyEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideSpecifyEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideSpecifyEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideSpecifyEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00157388 File Offset: 0x00155588
		public static IHideSpecifyEntity Create([Nullable(2)] IHideSpecifyEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x0015739B File Offset: 0x0015559B
		public static IHideSpecifyEntity CreateFromSetValue([Nullable(2)] IHideSpecifyEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideSpecifyEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x001573AE File Offset: 0x001555AE
		public new IHideSpecifyEntity_SetValue ToSetValue()
		{
			return new IHideSpecifyEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x06009420 RID: 37920 RVA: 0x001573CD File Offset: 0x001555CD
		// (set) Token: 0x06009421 RID: 37921 RVA: 0x001573F8 File Offset: 0x001555F8
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

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x06009422 RID: 37922 RVA: 0x00157406 File Offset: 0x00155606
		// (set) Token: 0x06009423 RID: 37923 RVA: 0x0015742D File Offset: 0x0015562D
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IHideSpecifyEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04005ADF RID: 23263
		[Nullable(2)]
		protected new IHideSpecifyEntity FbInstance;

		// Token: 0x04005AE0 RID: 23264
		[Nullable(2)]
		protected new IHideSpecifyEntity_SetValue PocoInterface;
	}
}
