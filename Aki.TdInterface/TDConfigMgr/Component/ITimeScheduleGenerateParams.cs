using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200082C RID: 2092
	public class ITimeScheduleGenerateParams
	{
		// Token: 0x06002D0A RID: 11530 RVA: 0x000757A8 File Offset: 0x000739A8
		private ITimeScheduleGenerateParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleGenerateParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleGenerateParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleGenerateParams_SetValue());
			}
			return result;
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x000757E0 File Offset: 0x000739E0
		public static ITimeScheduleGenerateParams Create([Nullable(2)] ITimeScheduleGenerateParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleGenerateParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000757F3 File Offset: 0x000739F3
		public static ITimeScheduleGenerateParams CreateFromSetValue([Nullable(2)] ITimeScheduleGenerateParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleGenerateParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00075806 File Offset: 0x00073A06
		public ITimeScheduleGenerateParams_SetValue ToSetValue()
		{
			return new ITimeScheduleGenerateParams_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x00075819 File Offset: 0x00073A19
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x00075844 File Offset: 0x00073A44
		public virtual ETimeScheduleGenerateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleGenerateType.FixedIntervalRefresh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001E1C RID: 7708
		[Nullable(2)]
		protected ITimeScheduleGenerateParams FbInstance;

		// Token: 0x04001E1D RID: 7709
		[Nullable(2)]
		protected ITimeScheduleGenerateParams_SetValue PocoInterface;
	}
}
