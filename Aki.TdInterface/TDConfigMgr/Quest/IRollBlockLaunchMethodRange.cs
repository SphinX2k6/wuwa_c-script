using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200111C RID: 4380
	[NullableContext(1)]
	[Nullable(0)]
	public class IRollBlockLaunchMethodRange : IRollBlockStartupMethodBase
	{
		// Token: 0x060062E0 RID: 25312 RVA: 0x000EDC70 File Offset: 0x000EBE70
		private IRollBlockLaunchMethodRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRollBlockLaunchMethodRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRollBlockLaunchMethodRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRollBlockLaunchMethodRange_SetValue());
			}
			return result;
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x000EDCA8 File Offset: 0x000EBEA8
		public static IRollBlockLaunchMethodRange Create([Nullable(2)] IRollBlockLaunchMethodRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x000EDCBB File Offset: 0x000EBEBB
		public static IRollBlockLaunchMethodRange CreateFromSetValue([Nullable(2)] IRollBlockLaunchMethodRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x000EDCCE File Offset: 0x000EBECE
		public new IRollBlockLaunchMethodRange_SetValue ToSetValue()
		{
			return new IRollBlockLaunchMethodRange_SetValue
			{
				Type = this.Type,
				TargetId = this.TargetId
			};
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x060062E4 RID: 25316 RVA: 0x000EDCED File Offset: 0x000EBEED
		// (set) Token: 0x060062E5 RID: 25317 RVA: 0x000EDD18 File Offset: 0x000EBF18
		public override ERollBlockLaunchMethod Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERollBlockLaunchMethod.Interact;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x060062E6 RID: 25318 RVA: 0x000EDD26 File Offset: 0x000EBF26
		// (set) Token: 0x060062E7 RID: 25319 RVA: 0x000EDD51 File Offset: 0x000EBF51
		public virtual int TargetId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetId;
			}
			set
			{
				this.GetOrCreatePoco().TargetId = value;
			}
		}

		// Token: 0x04003B4B RID: 15179
		[Nullable(2)]
		protected new IRollBlockLaunchMethodRange FbInstance;

		// Token: 0x04003B4C RID: 15180
		[Nullable(2)]
		protected new IRollBlockLaunchMethodRange_SetValue PocoInterface;
	}
}
