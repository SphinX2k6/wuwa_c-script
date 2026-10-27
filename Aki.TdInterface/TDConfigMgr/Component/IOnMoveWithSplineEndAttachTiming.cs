using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005AE RID: 1454
	[NullableContext(1)]
	[Nullable(0)]
	public class IOnMoveWithSplineEndAttachTiming : IAttachTiming
	{
		// Token: 0x06001EB2 RID: 7858 RVA: 0x00056B9C File Offset: 0x00054D9C
		private IOnMoveWithSplineEndAttachTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnMoveWithSplineEndAttachTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnMoveWithSplineEndAttachTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnMoveWithSplineEndAttachTiming_SetValue());
			}
			return result;
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00056BD4 File Offset: 0x00054DD4
		public static IOnMoveWithSplineEndAttachTiming Create([Nullable(2)] IOnMoveWithSplineEndAttachTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnMoveWithSplineEndAttachTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00056BE7 File Offset: 0x00054DE7
		public static IOnMoveWithSplineEndAttachTiming CreateFromSetValue([Nullable(2)] IOnMoveWithSplineEndAttachTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnMoveWithSplineEndAttachTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00056BFA File Offset: 0x00054DFA
		public new IOnMoveWithSplineEndAttachTiming_SetValue ToSetValue()
		{
			return new IOnMoveWithSplineEndAttachTiming_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00056C19 File Offset: 0x00054E19
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00056C44 File Offset: 0x00054E44
		public override EAttachTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachTimingType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00056C52 File Offset: 0x00054E52
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00056C7D File Offset: 0x00054E7D
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x040015D5 RID: 5589
		[Nullable(2)]
		protected new IOnMoveWithSplineEndAttachTiming FbInstance;

		// Token: 0x040015D6 RID: 5590
		[Nullable(2)]
		protected new IOnMoveWithSplineEndAttachTiming_SetValue PocoInterface;
	}
}
