using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C8 RID: 4552
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackRuleTypeBase
	{
		// Token: 0x06006778 RID: 26488 RVA: 0x000F7B48 File Offset: 0x000F5D48
		private ITrackRuleTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackRuleTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackRuleTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackRuleTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x000F7B80 File Offset: 0x000F5D80
		public static ITrackRuleTypeBase Create([Nullable(2)] ITrackRuleTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x000F7B93 File Offset: 0x000F5D93
		public static ITrackRuleTypeBase CreateFromSetValue([Nullable(2)] ITrackRuleTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackRuleTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x000F7BA6 File Offset: 0x000F5DA6
		public ITrackRuleTypeBase_SetValue ToSetValue()
		{
			return new ITrackRuleTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x000F7BB9 File Offset: 0x000F5DB9
		// (set) Token: 0x0600677D RID: 26493 RVA: 0x000F7BE4 File Offset: 0x000F5DE4
		public virtual ETrackRuleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackRuleType.FindLastMatchState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E1A RID: 15898
		[Nullable(2)]
		protected ITrackRuleTypeBase FbInstance;

		// Token: 0x04003E1B RID: 15899
		[Nullable(2)]
		protected ITrackRuleTypeBase_SetValue PocoInterface;
	}
}
