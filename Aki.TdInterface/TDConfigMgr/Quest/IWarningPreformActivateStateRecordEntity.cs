using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001346 RID: 4934
	public class IWarningPreformActivateStateRecordEntity : IWarningPreformType
	{
		// Token: 0x06006F11 RID: 28433 RVA: 0x00107A28 File Offset: 0x00105C28
		private IWarningPreformActivateStateRecordEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWarningPreformActivateStateRecordEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWarningPreformActivateStateRecordEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWarningPreformActivateStateRecordEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x00107A60 File Offset: 0x00105C60
		public static IWarningPreformActivateStateRecordEntity Create([Nullable(2)] IWarningPreformActivateStateRecordEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformActivateStateRecordEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x00107A73 File Offset: 0x00105C73
		public static IWarningPreformActivateStateRecordEntity CreateFromSetValue([Nullable(2)] IWarningPreformActivateStateRecordEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWarningPreformActivateStateRecordEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x00107A86 File Offset: 0x00105C86
		public new IWarningPreformActivateStateRecordEntity_SetValue ToSetValue()
		{
			return new IWarningPreformActivateStateRecordEntity_SetValue
			{
				Type = this.Type,
				TargetEntityIds = this.TargetEntityIds
			};
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x06006F15 RID: 28437 RVA: 0x00107AA5 File Offset: 0x00105CA5
		// (set) Token: 0x06006F16 RID: 28438 RVA: 0x00107AD0 File Offset: 0x00105CD0
		public override EWarningPreformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x06006F17 RID: 28439 RVA: 0x00107ADE File Offset: 0x00105CDE
		// (set) Token: 0x06006F18 RID: 28440 RVA: 0x00107B05 File Offset: 0x00105D05
		public virtual List<int> TargetEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntityIds;
				}
				IWarningPreformActivateStateRecordEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntityIds = value;
			}
		}

		// Token: 0x04004225 RID: 16933
		[Nullable(2)]
		protected new IWarningPreformActivateStateRecordEntity FbInstance;

		// Token: 0x04004226 RID: 16934
		[Nullable(2)]
		protected new IWarningPreformActivateStateRecordEntity_SetValue PocoInterface;
	}
}
