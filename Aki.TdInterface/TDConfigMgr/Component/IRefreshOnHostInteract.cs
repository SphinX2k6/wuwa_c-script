using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000670 RID: 1648
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshOnHostInteract : IRefreshConditionBase
	{
		// Token: 0x0600233E RID: 9022 RVA: 0x00060668 File Offset: 0x0005E868
		private IRefreshOnHostInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshOnHostInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshOnHostInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshOnHostInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x000606A0 File Offset: 0x0005E8A0
		public static IRefreshOnHostInteract Create([Nullable(2)] IRefreshOnHostInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnHostInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x000606B3 File Offset: 0x0005E8B3
		public static IRefreshOnHostInteract CreateFromSetValue([Nullable(2)] IRefreshOnHostInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshOnHostInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000606C6 File Offset: 0x0005E8C6
		public new IRefreshOnHostInteract_SetValue ToSetValue()
		{
			return new IRefreshOnHostInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000606D9 File Offset: 0x0005E8D9
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x00060704 File Offset: 0x0005E904
		public override ERewardDropType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERewardDropType.Death;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001862 RID: 6242
		[Nullable(2)]
		protected new IRefreshOnHostInteract FbInstance;

		// Token: 0x04001863 RID: 6243
		[Nullable(2)]
		protected new IRefreshOnHostInteract_SetValue PocoInterface;
	}
}
