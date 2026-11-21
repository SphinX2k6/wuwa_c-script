using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002063 RID: 8291
	public class ISetNpcGroupPerformType
	{
		// Token: 0x0600AFF7 RID: 45047 RVA: 0x0018C248 File Offset: 0x0018A448
		private ISetNpcGroupPerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcGroupPerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcGroupPerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcGroupPerformType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x0018C280 File Offset: 0x0018A480
		public static ISetNpcGroupPerformType Create([Nullable(2)] ISetNpcGroupPerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcGroupPerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x0018C293 File Offset: 0x0018A493
		public static ISetNpcGroupPerformType CreateFromSetValue([Nullable(2)] ISetNpcGroupPerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcGroupPerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x0018C2A6 File Offset: 0x0018A4A6
		public ISetNpcGroupPerformType_SetValue ToSetValue()
		{
			return new ISetNpcGroupPerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x0018C2B9 File Offset: 0x0018A4B9
		// (set) Token: 0x0600AFFC RID: 45052 RVA: 0x0018C2E4 File Offset: 0x0018A4E4
		public virtual ENpcGroupPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040068B2 RID: 26802
		[Nullable(2)]
		protected ISetNpcGroupPerformType FbInstance;

		// Token: 0x040068B3 RID: 26803
		[Nullable(2)]
		protected ISetNpcGroupPerformType_SetValue PocoInterface;
	}
}
