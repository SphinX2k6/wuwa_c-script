using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001170 RID: 4464
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2PosCondition
	{
		// Token: 0x0600656A RID: 25962 RVA: 0x000F36B0 File Offset: 0x000F18B0
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

		// Token: 0x0600656B RID: 25963 RVA: 0x000F36E8 File Offset: 0x000F18E8
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

		// Token: 0x0600656C RID: 25964 RVA: 0x000F36FB File Offset: 0x000F18FB
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

		// Token: 0x0600656D RID: 25965 RVA: 0x000F370E File Offset: 0x000F190E
		public ITakePhoto2PosCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2PosCondition_SetValue
			{
				RangeEntity = this.RangeEntity
			};
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600656E RID: 25966 RVA: 0x000F3721 File Offset: 0x000F1921
		// (set) Token: 0x0600656F RID: 25967 RVA: 0x000F374C File Offset: 0x000F194C
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

		// Token: 0x04003CE1 RID: 15585
		[Nullable(2)]
		protected ITakePhoto2PosCondition FbInstance;

		// Token: 0x04003CE2 RID: 15586
		[Nullable(2)]
		protected ITakePhoto2PosCondition_SetValue PocoInterface;
	}
}
