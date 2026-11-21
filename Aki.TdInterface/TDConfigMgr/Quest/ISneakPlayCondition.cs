using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001270 RID: 4720
	public class ISneakPlayCondition
	{
		// Token: 0x06006A4D RID: 27213 RVA: 0x000FE5A0 File Offset: 0x000FC7A0
		private ISneakPlayCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISneakPlayCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISneakPlayCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISneakPlayCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x000FE5D8 File Offset: 0x000FC7D8
		public static ISneakPlayCondition Create([Nullable(2)] ISneakPlayCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISneakPlayCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x000FE5EB File Offset: 0x000FC7EB
		public static ISneakPlayCondition CreateFromSetValue([Nullable(2)] ISneakPlayCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISneakPlayCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x000FE5FE File Offset: 0x000FC7FE
		public ISneakPlayCondition_SetValue ToSetValue()
		{
			return new ISneakPlayCondition_SetValue
			{
				Time = this.Time
			};
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x000FE611 File Offset: 0x000FC811
		// (set) Token: 0x06006A52 RID: 27218 RVA: 0x000FE63C File Offset: 0x000FC83C
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x04003F98 RID: 16280
		[Nullable(2)]
		protected ISneakPlayCondition FbInstance;

		// Token: 0x04003F99 RID: 16281
		[Nullable(2)]
		protected ISneakPlayCondition_SetValue PocoInterface;
	}
}
