using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000366 RID: 870
	[NullableContext(1)]
	[Nullable(0)]
	public class IExtraRangeType
	{
		// Token: 0x06001147 RID: 4423 RVA: 0x0003AB10 File Offset: 0x00038D10
		private IExtraRangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExtraRangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExtraRangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExtraRangeType_SetValue());
			}
			return result;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0003AB48 File Offset: 0x00038D48
		public static IExtraRangeType Create([Nullable(2)] IExtraRangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExtraRangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0003AB5B File Offset: 0x00038D5B
		public static IExtraRangeType CreateFromSetValue([Nullable(2)] IExtraRangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExtraRangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0003AB6E File Offset: 0x00038D6E
		public IExtraRangeType_SetValue ToSetValue()
		{
			return new IExtraRangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0003AB81 File Offset: 0x00038D81
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x0003ABAC File Offset: 0x00038DAC
		public virtual EExtraRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExtraRangeType.SunSpiritBlock;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E45 RID: 3653
		[Nullable(2)]
		protected IExtraRangeType FbInstance;

		// Token: 0x04000E46 RID: 3654
		[Nullable(2)]
		protected IExtraRangeType_SetValue PocoInterface;
	}
}
