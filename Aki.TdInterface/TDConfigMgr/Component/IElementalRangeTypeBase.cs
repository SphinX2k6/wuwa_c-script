using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000301 RID: 769
	[NullableContext(1)]
	[Nullable(0)]
	public class IElementalRangeTypeBase
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x00035248 File Offset: 0x00033448
		private IElementalRangeTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IElementalRangeTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IElementalRangeTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IElementalRangeTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00035280 File Offset: 0x00033480
		public static IElementalRangeTypeBase Create([Nullable(2)] IElementalRangeTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalRangeTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00035293 File Offset: 0x00033493
		public static IElementalRangeTypeBase CreateFromSetValue([Nullable(2)] IElementalRangeTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IElementalRangeTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000352A6 File Offset: 0x000334A6
		public IElementalRangeTypeBase_SetValue ToSetValue()
		{
			return new IElementalRangeTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000352B9 File Offset: 0x000334B9
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x000352E4 File Offset: 0x000334E4
		public virtual EElementalRangeType Type
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

		// Token: 0x04000CFD RID: 3325
		[Nullable(2)]
		protected IElementalRangeTypeBase FbInstance;

		// Token: 0x04000CFE RID: 3326
		[Nullable(2)]
		protected IElementalRangeTypeBase_SetValue PocoInterface;
	}
}
