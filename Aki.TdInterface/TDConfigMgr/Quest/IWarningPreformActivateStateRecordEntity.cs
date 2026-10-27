using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200120A RID: 4618
	[NullableContext(1)]
	[Nullable(0)]
	public class IWarningPreformActivateStateRecordEntity : IWarningPreformType
	{
		// Token: 0x060068D0 RID: 26832 RVA: 0x000FA11C File Offset: 0x000F831C
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

		// Token: 0x060068D1 RID: 26833 RVA: 0x000FA154 File Offset: 0x000F8354
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

		// Token: 0x060068D2 RID: 26834 RVA: 0x000FA167 File Offset: 0x000F8367
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

		// Token: 0x060068D3 RID: 26835 RVA: 0x000FA17A File Offset: 0x000F837A
		public new IWarningPreformActivateStateRecordEntity_SetValue ToSetValue()
		{
			return new IWarningPreformActivateStateRecordEntity_SetValue
			{
				Type = this.Type,
				TargetEntityIds = this.TargetEntityIds
			};
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x060068D4 RID: 26836 RVA: 0x000FA199 File Offset: 0x000F8399
		// (set) Token: 0x060068D5 RID: 26837 RVA: 0x000FA1C4 File Offset: 0x000F83C4
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

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x060068D6 RID: 26838 RVA: 0x000FA1D2 File Offset: 0x000F83D2
		// (set) Token: 0x060068D7 RID: 26839 RVA: 0x000FA1F9 File Offset: 0x000F83F9
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

		// Token: 0x04003EB7 RID: 16055
		[Nullable(2)]
		protected new IWarningPreformActivateStateRecordEntity FbInstance;

		// Token: 0x04003EB8 RID: 16056
		[Nullable(2)]
		protected new IWarningPreformActivateStateRecordEntity_SetValue PocoInterface;
	}
}
