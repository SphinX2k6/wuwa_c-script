using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032A RID: 810
	public class IDynamicEntityRewardType
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x000369B4 File Offset: 0x00034BB4
		private IDynamicEntityRewardType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicEntityRewardType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicEntityRewardType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicEntityRewardType_SetValue());
			}
			return result;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000369EC File Offset: 0x00034BEC
		public static IDynamicEntityRewardType Create([Nullable(2)] IDynamicEntityRewardType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicEntityRewardType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000369FF File Offset: 0x00034BFF
		public static IDynamicEntityRewardType CreateFromSetValue([Nullable(2)] IDynamicEntityRewardType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicEntityRewardType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00036A12 File Offset: 0x00034C12
		public IDynamicEntityRewardType_SetValue ToSetValue()
		{
			return new IDynamicEntityRewardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00036A25 File Offset: 0x00034C25
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00036A50 File Offset: 0x00034C50
		public virtual EDynamicEntityRewardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000D7D RID: 3453
		[Nullable(2)]
		protected IDynamicEntityRewardType FbInstance;

		// Token: 0x04000D7E RID: 3454
		[Nullable(2)]
		protected IDynamicEntityRewardType_SetValue PocoInterface;
	}
}
