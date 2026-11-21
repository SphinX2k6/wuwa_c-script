using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A8 RID: 4776
	public class ITakePhoto2PosCondition
	{
		// Token: 0x06006B99 RID: 27545 RVA: 0x00100DC0 File Offset: 0x000FEFC0
		private ITakePhoto2PosCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2PosCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2PosCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2PosCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00100DF8 File Offset: 0x000FEFF8
		public static ITakePhoto2PosCondition Create([Nullable(2)] ITakePhoto2PosCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2PosCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00100E0B File Offset: 0x000FF00B
		public static ITakePhoto2PosCondition CreateFromSetValue([Nullable(2)] ITakePhoto2PosCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2PosCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x00100E1E File Offset: 0x000FF01E
		public ITakePhoto2PosCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2PosCondition_SetValue
			{
				RangeEntity = this.RangeEntity
			};
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x06006B9D RID: 27549 RVA: 0x00100E31 File Offset: 0x000FF031
		// (set) Token: 0x06006B9E RID: 27550 RVA: 0x00100E5C File Offset: 0x000FF05C
		public virtual int RangeEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RangeEntity;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntity = value;
			}
		}

		// Token: 0x04004046 RID: 16454
		[Nullable(2)]
		protected ITakePhoto2PosCondition FbInstance;

		// Token: 0x04004047 RID: 16455
		[Nullable(2)]
		protected ITakePhoto2PosCondition_SetValue PocoInterface;
	}
}
