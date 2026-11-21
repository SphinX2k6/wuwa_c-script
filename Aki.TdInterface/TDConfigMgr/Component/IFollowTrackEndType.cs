using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003FB RID: 1019
	public class IFollowTrackEndType
	{
		// Token: 0x0600142B RID: 5163 RVA: 0x000411EC File Offset: 0x0003F3EC
		private IFollowTrackEndType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowTrackEndType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowTrackEndType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowTrackEndType_SetValue());
			}
			return result;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00041224 File Offset: 0x0003F424
		public static IFollowTrackEndType Create([Nullable(2)] IFollowTrackEndType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackEndType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00041237 File Offset: 0x0003F437
		public static IFollowTrackEndType CreateFromSetValue([Nullable(2)] IFollowTrackEndType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowTrackEndType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0004124A File Offset: 0x0003F44A
		public IFollowTrackEndType_SetValue ToSetValue()
		{
			return new IFollowTrackEndType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0004125D File Offset: 0x0003F45D
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x00041288 File Offset: 0x0003F488
		public virtual EFollowTrackEndType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFollowTrackEndType.ToStart;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001018 RID: 4120
		[Nullable(2)]
		protected IFollowTrackEndType FbInstance;

		// Token: 0x04001019 RID: 4121
		[Nullable(2)]
		protected IFollowTrackEndType_SetValue PocoInterface;
	}
}
