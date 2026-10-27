using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200193E RID: 6462
	[NullableContext(1)]
	[Nullable(0)]
	public class IControlTrackingType
	{
		// Token: 0x06008A87 RID: 35463 RVA: 0x00146458 File Offset: 0x00144658
		private IControlTrackingType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlTrackingType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlTrackingType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlTrackingType_SetValue());
			}
			return result;
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x00146490 File Offset: 0x00144690
		public static IControlTrackingType Create([Nullable(2)] IControlTrackingType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x001464A3 File Offset: 0x001446A3
		public static IControlTrackingType CreateFromSetValue([Nullable(2)] IControlTrackingType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlTrackingType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x001464B6 File Offset: 0x001446B6
		public IControlTrackingType_SetValue ToSetValue()
		{
			return new IControlTrackingType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x06008A8B RID: 35467 RVA: 0x001464C9 File Offset: 0x001446C9
		// (set) Token: 0x06008A8C RID: 35468 RVA: 0x001464F4 File Offset: 0x001446F4
		public virtual EControlTrackingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlTrackingType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005694 RID: 22164
		[Nullable(2)]
		protected IControlTrackingType FbInstance;

		// Token: 0x04005695 RID: 22165
		[Nullable(2)]
		protected IControlTrackingType_SetValue PocoInterface;
	}
}
