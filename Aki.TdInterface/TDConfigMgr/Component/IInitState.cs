using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000464 RID: 1124
	[NullableContext(1)]
	[Nullable(0)]
	public class IInitState
	{
		// Token: 0x060016AF RID: 5807 RVA: 0x00045A98 File Offset: 0x00043C98
		private IInitState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitState_SetValue());
			}
			return result;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00045AD0 File Offset: 0x00043CD0
		public static IInitState Create([Nullable(2)] IInitState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00045AE3 File Offset: 0x00043CE3
		public static IInitState CreateFromSetValue([Nullable(2)] IInitState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00045AF6 File Offset: 0x00043CF6
		public IInitState_SetValue ToSetValue()
		{
			return new IInitState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x00045B09 File Offset: 0x00043D09
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x00045B34 File Offset: 0x00043D34
		public virtual EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400113A RID: 4410
		[Nullable(2)]
		protected IInitState FbInstance;

		// Token: 0x0400113B RID: 4411
		[Nullable(2)]
		protected IInitState_SetValue PocoInterface;
	}
}
