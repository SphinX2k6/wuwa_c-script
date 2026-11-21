using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A43 RID: 6723
	public class IClientExecEntityPrefabOption
	{
		// Token: 0x06008EF3 RID: 36595 RVA: 0x001512FC File Offset: 0x0014F4FC
		private IClientExecEntityPrefabOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientExecEntityPrefabOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientExecEntityPrefabOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientExecEntityPrefabOption_SetValue());
			}
			return result;
		}

		// Token: 0x06008EF4 RID: 36596 RVA: 0x00151334 File Offset: 0x0014F534
		public static IClientExecEntityPrefabOption Create([Nullable(2)] IClientExecEntityPrefabOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientExecEntityPrefabOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x00151347 File Offset: 0x0014F547
		public static IClientExecEntityPrefabOption CreateFromSetValue([Nullable(2)] IClientExecEntityPrefabOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientExecEntityPrefabOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x0015135A File Offset: 0x0014F55A
		public IClientExecEntityPrefabOption_SetValue ToSetValue()
		{
			return new IClientExecEntityPrefabOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x0015136D File Offset: 0x0014F56D
		// (set) Token: 0x06008EF8 RID: 36600 RVA: 0x00151398 File Offset: 0x0014F598
		public virtual EClientExecEntityPrefabOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientExecEntityPrefabOption.ModifyPrefabParams;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040059B4 RID: 22964
		[Nullable(2)]
		protected IClientExecEntityPrefabOption FbInstance;

		// Token: 0x040059B5 RID: 22965
		[Nullable(2)]
		protected IClientExecEntityPrefabOption_SetValue PocoInterface;
	}
}
