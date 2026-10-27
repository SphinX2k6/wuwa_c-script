using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200180E RID: 6158
	[NullableContext(1)]
	[Nullable(0)]
	public class IBlendAnimTypeBase
	{
		// Token: 0x0600842D RID: 33837 RVA: 0x0013B0D8 File Offset: 0x001392D8
		private IBlendAnimTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBlendAnimTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBlendAnimTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBlendAnimTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x0013B110 File Offset: 0x00139310
		public static IBlendAnimTypeBase Create([Nullable(2)] IBlendAnimTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendAnimTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x0013B123 File Offset: 0x00139323
		public static IBlendAnimTypeBase CreateFromSetValue([Nullable(2)] IBlendAnimTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBlendAnimTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x0013B136 File Offset: 0x00139336
		public IBlendAnimTypeBase_SetValue ToSetValue()
		{
			return new IBlendAnimTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x06008431 RID: 33841 RVA: 0x0013B149 File Offset: 0x00139349
		// (set) Token: 0x06008432 RID: 33842 RVA: 0x0013B174 File Offset: 0x00139374
		public virtual EBlendAnimType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimType.StateMachine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040053B3 RID: 21427
		[Nullable(2)]
		protected IBlendAnimTypeBase FbInstance;

		// Token: 0x040053B4 RID: 21428
		[Nullable(2)]
		protected IBlendAnimTypeBase_SetValue PocoInterface;
	}
}
