using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000348 RID: 840
	public class IElementalRangeTypeBase
	{
		// Token: 0x06001009 RID: 4105 RVA: 0x0003817C File Offset: 0x0003637C
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

		// Token: 0x0600100A RID: 4106 RVA: 0x000381B4 File Offset: 0x000363B4
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

		// Token: 0x0600100B RID: 4107 RVA: 0x000381C7 File Offset: 0x000363C7
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

		// Token: 0x0600100C RID: 4108 RVA: 0x000381DA File Offset: 0x000363DA
		public IElementalRangeTypeBase_SetValue ToSetValue()
		{
			return new IElementalRangeTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x000381ED File Offset: 0x000363ED
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x00038218 File Offset: 0x00036418
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

		// Token: 0x04000DE7 RID: 3559
		[Nullable(2)]
		protected IElementalRangeTypeBase FbInstance;

		// Token: 0x04000DE8 RID: 3560
		[Nullable(2)]
		protected IElementalRangeTypeBase_SetValue PocoInterface;
	}
}
