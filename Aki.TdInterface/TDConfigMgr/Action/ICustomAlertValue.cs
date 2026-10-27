using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001946 RID: 6470
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomAlertValue : ISetAlertValueType
	{
		// Token: 0x06008AA7 RID: 35495 RVA: 0x00146748 File Offset: 0x00144948
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

		// Token: 0x06008AA8 RID: 35496 RVA: 0x00146780 File Offset: 0x00144980
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

		// Token: 0x06008AA9 RID: 35497 RVA: 0x00146793 File Offset: 0x00144993
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

		// Token: 0x06008AAA RID: 35498 RVA: 0x001467A6 File Offset: 0x001449A6
		public new ICustomAlertValue_SetValue ToSetValue()
		{
			return new ICustomAlertValue_SetValue
			{
				Type = this.Type,
				CustomValue = this.CustomValue
			};
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x06008AAB RID: 35499 RVA: 0x001467C5 File Offset: 0x001449C5
		// (set) Token: 0x06008AAC RID: 35500 RVA: 0x001467F0 File Offset: 0x001449F0
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

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x06008AAD RID: 35501 RVA: 0x001467FE File Offset: 0x001449FE
		// (set) Token: 0x06008AAE RID: 35502 RVA: 0x0014682D File Offset: 0x00144A2D
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

		// Token: 0x040056A0 RID: 22176
		[Nullable(2)]
		protected new ICustomAlertValue FbInstance;

		// Token: 0x040056A1 RID: 22177
		[Nullable(2)]
		protected new ICustomAlertValue_SetValue PocoInterface;
	}
}
