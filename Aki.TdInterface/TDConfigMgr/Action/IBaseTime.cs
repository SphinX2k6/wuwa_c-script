using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017FC RID: 6140
	[NullableContext(1)]
	[Nullable(0)]
	public class IBaseTime
	{
		// Token: 0x060083DB RID: 33755 RVA: 0x0013A8C8 File Offset: 0x00138AC8
		private IBaseTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBaseTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBaseTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBaseTime_SetValue());
			}
			return result;
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x0013A900 File Offset: 0x00138B00
		public static IBaseTime Create([Nullable(2)] IBaseTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x0013A913 File Offset: 0x00138B13
		public static IBaseTime CreateFromSetValue([Nullable(2)] IBaseTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBaseTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x0013A926 File Offset: 0x00138B26
		public IBaseTime_SetValue ToSetValue()
		{
			return new IBaseTime_SetValue
			{
				Hour = this.Hour,
				Minute = this.Minute
			};
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x060083DF RID: 33759 RVA: 0x0013A945 File Offset: 0x00138B45
		// (set) Token: 0x060083E0 RID: 33760 RVA: 0x0013A970 File Offset: 0x00138B70
		public virtual int Hour
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Hour;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Hour;
			}
			set
			{
				this.GetOrCreatePoco().Hour = value;
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x060083E1 RID: 33761 RVA: 0x0013A97E File Offset: 0x00138B7E
		// (set) Token: 0x060083E2 RID: 33762 RVA: 0x0013A9A9 File Offset: 0x00138BA9
		public virtual int Minute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Minute;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Minute;
			}
			set
			{
				this.GetOrCreatePoco().Minute = value;
			}
		}

		// Token: 0x04005393 RID: 21395
		[Nullable(2)]
		protected IBaseTime FbInstance;

		// Token: 0x04005394 RID: 21396
		[Nullable(2)]
		protected IBaseTime_SetValue PocoInterface;
	}
}
