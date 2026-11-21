using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000841 RID: 2113
	public class ITransportBoxElementalRange : IElementalRangeTypeBase
	{
		// Token: 0x06002D78 RID: 11640 RVA: 0x00076378 File Offset: 0x00074578
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

		// Token: 0x06002D79 RID: 11641 RVA: 0x000763B0 File Offset: 0x000745B0
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

		// Token: 0x06002D7A RID: 11642 RVA: 0x000763C3 File Offset: 0x000745C3
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

		// Token: 0x06002D7B RID: 11643 RVA: 0x000763D6 File Offset: 0x000745D6
		public new ITransportBoxElementalRange_SetValue ToSetValue()
		{
			return new ITransportBoxElementalRange_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x000763E9 File Offset: 0x000745E9
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x00076414 File Offset: 0x00074614
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

		// Token: 0x04001E4D RID: 7757
		[Nullable(2)]
		protected new ITransportBoxElementalRange FbInstance;

		// Token: 0x04001E4E RID: 7758
		[Nullable(2)]
		protected new ITransportBoxElementalRange_SetValue PocoInterface;
	}
}
