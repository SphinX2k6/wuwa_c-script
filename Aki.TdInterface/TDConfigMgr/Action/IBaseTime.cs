using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001985 RID: 6533
	public class IBaseTime
	{
		// Token: 0x06008AF7 RID: 35575 RVA: 0x00149FB0 File Offset: 0x001481B0
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

		// Token: 0x06008AF8 RID: 35576 RVA: 0x00149FE8 File Offset: 0x001481E8
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

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00149FFB File Offset: 0x001481FB
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

		// Token: 0x06008AFA RID: 35578 RVA: 0x0014A00E File Offset: 0x0014820E
		public IBaseTime_SetValue ToSetValue()
		{
			return new IBaseTime_SetValue
			{
				Hour = this.Hour,
				Minute = this.Minute
			};
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x06008AFB RID: 35579 RVA: 0x0014A02D File Offset: 0x0014822D
		// (set) Token: 0x06008AFC RID: 35580 RVA: 0x0014A058 File Offset: 0x00148258
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

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x06008AFD RID: 35581 RVA: 0x0014A066 File Offset: 0x00148266
		// (set) Token: 0x06008AFE RID: 35582 RVA: 0x0014A091 File Offset: 0x00148291
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

		// Token: 0x040057DB RID: 22491
		[Nullable(2)]
		protected IBaseTime FbInstance;

		// Token: 0x040057DC RID: 22492
		[Nullable(2)]
		protected IBaseTime_SetValue PocoInterface;
	}
}
