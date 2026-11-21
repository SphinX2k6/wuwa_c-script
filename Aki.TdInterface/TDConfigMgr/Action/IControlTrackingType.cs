using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC7 RID: 6855
	public class IControlTrackingType
	{
		// Token: 0x060091B3 RID: 37299 RVA: 0x00155D98 File Offset: 0x00153F98
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

		// Token: 0x060091B4 RID: 37300 RVA: 0x00155DD0 File Offset: 0x00153FD0
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

		// Token: 0x060091B5 RID: 37301 RVA: 0x00155DE3 File Offset: 0x00153FE3
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

		// Token: 0x060091B6 RID: 37302 RVA: 0x00155DF6 File Offset: 0x00153FF6
		public IControlTrackingType_SetValue ToSetValue()
		{
			return new IControlTrackingType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x060091B7 RID: 37303 RVA: 0x00155E09 File Offset: 0x00154009
		// (set) Token: 0x060091B8 RID: 37304 RVA: 0x00155E34 File Offset: 0x00154034
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

		// Token: 0x04005AE4 RID: 23268
		[Nullable(2)]
		protected IControlTrackingType FbInstance;

		// Token: 0x04005AE5 RID: 23269
		[Nullable(2)]
		protected IControlTrackingType_SetValue PocoInterface;
	}
}
