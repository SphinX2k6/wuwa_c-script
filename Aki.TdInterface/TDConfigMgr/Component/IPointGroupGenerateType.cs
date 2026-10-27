using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000612 RID: 1554
	[NullableContext(1)]
	[Nullable(0)]
	public class IPointGroupGenerateType
	{
		// Token: 0x06002128 RID: 8488 RVA: 0x0005BF3C File Offset: 0x0005A13C
		private IPointGroupGenerateType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPointGroupGenerateType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPointGroupGenerateType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPointGroupGenerateType_SetValue());
			}
			return result;
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0005BF74 File Offset: 0x0005A174
		public static IPointGroupGenerateType Create([Nullable(2)] IPointGroupGenerateType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointGroupGenerateType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0005BF87 File Offset: 0x0005A187
		public static IPointGroupGenerateType CreateFromSetValue([Nullable(2)] IPointGroupGenerateType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPointGroupGenerateType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0005BF9A File Offset: 0x0005A19A
		public IPointGroupGenerateType_SetValue ToSetValue()
		{
			return new IPointGroupGenerateType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0005BFAD File Offset: 0x0005A1AD
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x0005BFD8 File Offset: 0x0005A1D8
		public virtual EPointGroupGenerateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPointGroupGenerateType.Layer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001730 RID: 5936
		[Nullable(2)]
		protected IPointGroupGenerateType FbInstance;

		// Token: 0x04001731 RID: 5937
		[Nullable(2)]
		protected IPointGroupGenerateType_SetValue PocoInterface;
	}
}
