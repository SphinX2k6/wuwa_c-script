using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017D2 RID: 6098
	[NullableContext(1)]
	[Nullable(0)]
	public class IAlertSystemOption
	{
		// Token: 0x060082F1 RID: 33521 RVA: 0x00138FF4 File Offset: 0x001371F4
		private IAlertSystemOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAlertSystemOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAlertSystemOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAlertSystemOption_SetValue());
			}
			return result;
		}

		// Token: 0x060082F2 RID: 33522 RVA: 0x0013902C File Offset: 0x0013722C
		public static IAlertSystemOption Create([Nullable(2)] IAlertSystemOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAlertSystemOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x0013903F File Offset: 0x0013723F
		public static IAlertSystemOption CreateFromSetValue([Nullable(2)] IAlertSystemOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAlertSystemOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x00139052 File Offset: 0x00137252
		public IAlertSystemOption_SetValue ToSetValue()
		{
			return new IAlertSystemOption_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId
			};
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x060082F5 RID: 33525 RVA: 0x00139071 File Offset: 0x00137271
		// (set) Token: 0x060082F6 RID: 33526 RVA: 0x0013909C File Offset: 0x0013729C
		public virtual EAlertSystemOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x060082F7 RID: 33527 RVA: 0x001390AA File Offset: 0x001372AA
		// (set) Token: 0x060082F8 RID: 33528 RVA: 0x001390D5 File Offset: 0x001372D5
		public virtual int AreaId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AreaId;
			}
			set
			{
				this.GetOrCreatePoco().AreaId = value;
			}
		}

		// Token: 0x04005331 RID: 21297
		[Nullable(2)]
		protected IAlertSystemOption FbInstance;

		// Token: 0x04005332 RID: 21298
		[Nullable(2)]
		protected IAlertSystemOption_SetValue PocoInterface;
	}
}
