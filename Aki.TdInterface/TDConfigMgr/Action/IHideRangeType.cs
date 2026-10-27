using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B01 RID: 6913
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideRangeType
	{
		// Token: 0x0600940A RID: 37898 RVA: 0x00157198 File Offset: 0x00155398
		private IHideRangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideRangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideRangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideRangeType_SetValue());
			}
			return result;
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x001571D0 File Offset: 0x001553D0
		public static IHideRangeType Create([Nullable(2)] IHideRangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideRangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x001571E3 File Offset: 0x001553E3
		public static IHideRangeType CreateFromSetValue([Nullable(2)] IHideRangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideRangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x001571F6 File Offset: 0x001553F6
		public IHideRangeType_SetValue ToSetValue()
		{
			return new IHideRangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600940E RID: 37902 RVA: 0x00157209 File Offset: 0x00155409
		// (set) Token: 0x0600940F RID: 37903 RVA: 0x00157234 File Offset: 0x00155434
		public virtual EHideType Type
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

		// Token: 0x04005AD8 RID: 23256
		[Nullable(2)]
		protected IHideRangeType FbInstance;

		// Token: 0x04005AD9 RID: 23257
		[Nullable(2)]
		protected IHideRangeType_SetValue PocoInterface;
	}
}
