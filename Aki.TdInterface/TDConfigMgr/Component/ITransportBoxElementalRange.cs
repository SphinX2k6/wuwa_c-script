using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007A0 RID: 1952
	[NullableContext(1)]
	[Nullable(0)]
	public class ITransportBoxElementalRange : IElementalRangeTypeBase
	{
		// Token: 0x06002A50 RID: 10832 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
		private ITransportBoxElementalRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransportBoxElementalRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransportBoxElementalRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransportBoxElementalRange_SetValue());
			}
			return result;
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x0006F108 File Offset: 0x0006D308
		public static ITransportBoxElementalRange Create([Nullable(2)] ITransportBoxElementalRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransportBoxElementalRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x0006F11B File Offset: 0x0006D31B
		public static ITransportBoxElementalRange CreateFromSetValue([Nullable(2)] ITransportBoxElementalRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransportBoxElementalRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0006F12E File Offset: 0x0006D32E
		public new ITransportBoxElementalRange_SetValue ToSetValue()
		{
			return new ITransportBoxElementalRange_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x0006F141 File Offset: 0x0006D341
		// (set) Token: 0x06002A55 RID: 10837 RVA: 0x0006F16C File Offset: 0x0006D36C
		public override EElementalRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EElementalRangeType.BaseShape;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001C44 RID: 7236
		[Nullable(2)]
		protected new ITransportBoxElementalRange FbInstance;

		// Token: 0x04001C45 RID: 7237
		[Nullable(2)]
		protected new ITransportBoxElementalRange_SetValue PocoInterface;
	}
}
