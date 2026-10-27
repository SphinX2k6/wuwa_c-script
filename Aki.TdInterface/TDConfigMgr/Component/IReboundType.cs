using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000664 RID: 1636
	[NullableContext(1)]
	[Nullable(0)]
	public class IReboundType
	{
		// Token: 0x06002302 RID: 8962 RVA: 0x0005FF9C File Offset: 0x0005E19C
		private IReboundType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IReboundType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IReboundType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IReboundType_SetValue());
			}
			return result;
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0005FFD4 File Offset: 0x0005E1D4
		public static IReboundType Create([Nullable(2)] IReboundType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReboundType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0005FFE7 File Offset: 0x0005E1E7
		public static IReboundType CreateFromSetValue([Nullable(2)] IReboundType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IReboundType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0005FFFA File Offset: 0x0005E1FA
		public IReboundType_SetValue ToSetValue()
		{
			return new IReboundType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x0006000D File Offset: 0x0005E20D
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x00060038 File Offset: 0x0005E238
		public virtual EReboundOptionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EReboundOptionType.ForwardFront;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001846 RID: 6214
		[Nullable(2)]
		protected IReboundType FbInstance;

		// Token: 0x04001847 RID: 6215
		[Nullable(2)]
		protected IReboundType_SetValue PocoInterface;
	}
}
