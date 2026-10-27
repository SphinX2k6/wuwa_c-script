using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB9 RID: 7865
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateProgramSpecialProcessBase
	{
		// Token: 0x0600A868 RID: 43112 RVA: 0x0017C4E8 File Offset: 0x0017A6E8
		private IStateProgramSpecialProcessBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateProgramSpecialProcessBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateProgramSpecialProcessBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateProgramSpecialProcessBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x0017C520 File Offset: 0x0017A720
		public static IStateProgramSpecialProcessBase Create([Nullable(2)] IStateProgramSpecialProcessBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateProgramSpecialProcessBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x0017C533 File Offset: 0x0017A733
		public static IStateProgramSpecialProcessBase CreateFromSetValue([Nullable(2)] IStateProgramSpecialProcessBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateProgramSpecialProcessBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x0017C546 File Offset: 0x0017A746
		public IStateProgramSpecialProcessBase_SetValue ToSetValue()
		{
			return new IStateProgramSpecialProcessBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600A86C RID: 43116 RVA: 0x0017C559 File Offset: 0x0017A759
		// (set) Token: 0x0600A86D RID: 43117 RVA: 0x0017C584 File Offset: 0x0017A784
		public virtual ELogicProgramSpecialProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELogicProgramSpecialProcess.ChangeTeamOptimization;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006459 RID: 25689
		[Nullable(2)]
		protected IStateProgramSpecialProcessBase FbInstance;

		// Token: 0x0400645A RID: 25690
		[Nullable(2)]
		protected IStateProgramSpecialProcessBase_SetValue PocoInterface;
	}
}
