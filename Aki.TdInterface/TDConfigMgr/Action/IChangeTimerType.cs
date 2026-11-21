using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A05 RID: 6661
	public class IChangeTimerType
	{
		// Token: 0x06008DCF RID: 36303 RVA: 0x0014F41C File Offset: 0x0014D61C
		private IChangeTimerType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeTimerType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeTimerType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeTimerType_SetValue());
			}
			return result;
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x0014F454 File Offset: 0x0014D654
		public static IChangeTimerType Create([Nullable(2)] IChangeTimerType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTimerType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x0014F467 File Offset: 0x0014D667
		public static IChangeTimerType CreateFromSetValue([Nullable(2)] IChangeTimerType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeTimerType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x0014F47A File Offset: 0x0014D67A
		public IChangeTimerType_SetValue ToSetValue()
		{
			return new IChangeTimerType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x06008DD3 RID: 36307 RVA: 0x0014F48D File Offset: 0x0014D68D
		// (set) Token: 0x06008DD4 RID: 36308 RVA: 0x0014F4B8 File Offset: 0x0014D6B8
		public virtual EChangeTimerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeTimerType.Add;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005931 RID: 22833
		[Nullable(2)]
		protected IChangeTimerType FbInstance;

		// Token: 0x04005932 RID: 22834
		[Nullable(2)]
		protected IChangeTimerType_SetValue PocoInterface;
	}
}
