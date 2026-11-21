using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB4 RID: 7348
	public class IHideSpecifyEntity : IHideRangeType
	{
		// Token: 0x06009C06 RID: 39942 RVA: 0x0016802C File Offset: 0x0016622C
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

		// Token: 0x06009C07 RID: 39943 RVA: 0x00168064 File Offset: 0x00166264
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

		// Token: 0x06009C08 RID: 39944 RVA: 0x00168077 File Offset: 0x00166277
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

		// Token: 0x06009C09 RID: 39945 RVA: 0x0016808A File Offset: 0x0016628A
		public new IHideSpecifyEntity_SetValue ToSetValue()
		{
			return new IHideSpecifyEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x06009C0A RID: 39946 RVA: 0x001680A9 File Offset: 0x001662A9
		// (set) Token: 0x06009C0B RID: 39947 RVA: 0x001680D4 File Offset: 0x001662D4
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

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x06009C0C RID: 39948 RVA: 0x001680E2 File Offset: 0x001662E2
		// (set) Token: 0x06009C0D RID: 39949 RVA: 0x00168109 File Offset: 0x00166309
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

		// Token: 0x04005F7D RID: 24445
		[Nullable(2)]
		protected new IHideSpecifyEntity FbInstance;

		// Token: 0x04005F7E RID: 24446
		[Nullable(2)]
		protected new IHideSpecifyEntity_SetValue PocoInterface;
	}
}
