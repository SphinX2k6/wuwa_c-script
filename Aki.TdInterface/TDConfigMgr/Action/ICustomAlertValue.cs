using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD1 RID: 6865
	public class ICustomAlertValue : ISetAlertValueType
	{
		// Token: 0x060091DB RID: 37339 RVA: 0x00156144 File Offset: 0x00154344
		private ICustomAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x0015617C File Offset: 0x0015437C
		public static ICustomAlertValue Create([Nullable(2)] ICustomAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x0015618F File Offset: 0x0015438F
		public static ICustomAlertValue CreateFromSetValue([Nullable(2)] ICustomAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x001561A2 File Offset: 0x001543A2
		public new ICustomAlertValue_SetValue ToSetValue()
		{
			return new ICustomAlertValue_SetValue
			{
				Type = this.Type,
				CustomValue = this.CustomValue
			};
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x060091DF RID: 37343 RVA: 0x001561C1 File Offset: 0x001543C1
		// (set) Token: 0x060091E0 RID: 37344 RVA: 0x001561EC File Offset: 0x001543EC
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x060091E1 RID: 37345 RVA: 0x001561FA File Offset: 0x001543FA
		// (set) Token: 0x060091E2 RID: 37346 RVA: 0x00156229 File Offset: 0x00154429
		public virtual float CustomValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomValue;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.CustomValue;
			}
			set
			{
				this.GetOrCreatePoco().CustomValue = value;
			}
		}

		// Token: 0x04005AF3 RID: 23283
		[Nullable(2)]
		protected new ICustomAlertValue FbInstance;

		// Token: 0x04005AF4 RID: 23284
		[Nullable(2)]
		protected new ICustomAlertValue_SetValue PocoInterface;
	}
}
