using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001304 RID: 4868
	public class ITrackRuleTypeBase
	{
		// Token: 0x06006DB9 RID: 28089 RVA: 0x00105454 File Offset: 0x00103654
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

		// Token: 0x06006DBA RID: 28090 RVA: 0x0010548C File Offset: 0x0010368C
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

		// Token: 0x06006DBB RID: 28091 RVA: 0x0010549F File Offset: 0x0010369F
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

		// Token: 0x06006DBC RID: 28092 RVA: 0x001054B2 File Offset: 0x001036B2
		public ITrackRuleTypeBase_SetValue ToSetValue()
		{
			return new ITrackRuleTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x06006DBD RID: 28093 RVA: 0x001054C5 File Offset: 0x001036C5
		// (set) Token: 0x06006DBE RID: 28094 RVA: 0x001054F0 File Offset: 0x001036F0
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

		// Token: 0x04004188 RID: 16776
		[Nullable(2)]
		protected ITrackRuleTypeBase FbInstance;

		// Token: 0x04004189 RID: 16777
		[Nullable(2)]
		protected ITrackRuleTypeBase_SetValue PocoInterface;
	}
}
