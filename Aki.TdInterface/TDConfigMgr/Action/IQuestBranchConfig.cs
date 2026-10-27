using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D80 RID: 7552
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestBranchConfig
	{
		// Token: 0x0600A1DD RID: 41437 RVA: 0x00170704 File Offset: 0x0016E904
		private IQuestBranchConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestBranchConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestBranchConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestBranchConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x0017073C File Offset: 0x0016E93C
		public static IQuestBranchConfig Create([Nullable(2)] IQuestBranchConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestBranchConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x0017074F File Offset: 0x0016E94F
		public static IQuestBranchConfig CreateFromSetValue([Nullable(2)] IQuestBranchConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestBranchConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x00170762 File Offset: 0x0016E962
		public IQuestBranchConfig_SetValue ToSetValue()
		{
			return new IQuestBranchConfig_SetValue
			{
				EnableAnimation = this.EnableAnimation
			};
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x00170778 File Offset: 0x0016E978
		// (set) Token: 0x0600A1E2 RID: 41442 RVA: 0x001707B2 File Offset: 0x0016E9B2
		public virtual bool? EnableAnimation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableAnimation;
				}
				IQuestBranchConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableAnimation;
			}
			set
			{
				this.GetOrCreatePoco().EnableAnimation = value;
			}
		}

		// Token: 0x04006150 RID: 24912
		[Nullable(2)]
		protected IQuestBranchConfig FbInstance;

		// Token: 0x04006151 RID: 24913
		[Nullable(2)]
		protected IQuestBranchConfig_SetValue PocoInterface;
	}
}
