using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014BE RID: 5310
	[NullableContext(1)]
	[Nullable(0)]
	public class CallFunction : ActionParams
	{
		// Token: 0x060078DC RID: 30940 RVA: 0x00121930 File Offset: 0x0011FB30
		private CallFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CallFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CallFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CallFunction_SetValue());
			}
			return result;
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x00121968 File Offset: 0x0011FB68
		public static CallFunction Create([Nullable(2)] CallFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CallFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x0012197B File Offset: 0x0011FB7B
		public static CallFunction CreateFromSetValue([Nullable(2)] CallFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CallFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x0012198E File Offset: 0x0011FB8E
		public CallFunction_SetValue ToSetValue()
		{
			return new CallFunction_SetValue
			{
				Name = this.Name
			};
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x001219A1 File Offset: 0x0011FBA1
		// (set) Token: 0x060078E1 RID: 30945 RVA: 0x001219CC File Offset: 0x0011FBCC
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x04004634 RID: 17972
		[Nullable(2)]
		protected new CallFunction FbInstance;

		// Token: 0x04004635 RID: 17973
		[Nullable(2)]
		protected CallFunction_SetValue PocoInterface;
	}
}
