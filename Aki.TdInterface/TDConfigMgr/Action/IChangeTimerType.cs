using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200187A RID: 6266
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeTimerType
	{
		// Token: 0x060086A7 RID: 34471 RVA: 0x0013FBE8 File Offset: 0x0013DDE8
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

		// Token: 0x060086A8 RID: 34472 RVA: 0x0013FC20 File Offset: 0x0013DE20
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

		// Token: 0x060086A9 RID: 34473 RVA: 0x0013FC33 File Offset: 0x0013DE33
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

		// Token: 0x060086AA RID: 34474 RVA: 0x0013FC46 File Offset: 0x0013DE46
		public IChangeTimerType_SetValue ToSetValue()
		{
			return new IChangeTimerType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x0013FC59 File Offset: 0x0013DE59
		// (set) Token: 0x060086AC RID: 34476 RVA: 0x0013FC84 File Offset: 0x0013DE84
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

		// Token: 0x040054E4 RID: 21732
		[Nullable(2)]
		protected IChangeTimerType FbInstance;

		// Token: 0x040054E5 RID: 21733
		[Nullable(2)]
		protected IChangeTimerType_SetValue PocoInterface;
	}
}
