using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F91 RID: 8081
	public class IQuestBranchConfig
	{
		// Token: 0x0600ABC9 RID: 43977 RVA: 0x00184B28 File Offset: 0x00182D28
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

		// Token: 0x0600ABCA RID: 43978 RVA: 0x00184B60 File Offset: 0x00182D60
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

		// Token: 0x0600ABCB RID: 43979 RVA: 0x00184B73 File Offset: 0x00182D73
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

		// Token: 0x0600ABCC RID: 43980 RVA: 0x00184B86 File Offset: 0x00182D86
		public IQuestBranchConfig_SetValue ToSetValue()
		{
			return new IQuestBranchConfig_SetValue
			{
				EnableAnimation = this.EnableAnimation
			};
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600ABCD RID: 43981 RVA: 0x00184B9C File Offset: 0x00182D9C
		// (set) Token: 0x0600ABCE RID: 43982 RVA: 0x00184BD6 File Offset: 0x00182DD6
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

		// Token: 0x040066CC RID: 26316
		[Nullable(2)]
		protected IQuestBranchConfig FbInstance;

		// Token: 0x040066CD RID: 26317
		[Nullable(2)]
		protected IQuestBranchConfig_SetValue PocoInterface;
	}
}
