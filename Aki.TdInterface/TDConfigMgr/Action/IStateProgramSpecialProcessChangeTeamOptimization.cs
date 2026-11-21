using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F4 RID: 8436
	public class IStateProgramSpecialProcessChangeTeamOptimization : IStateProgramSpecialProcessBase
	{
		// Token: 0x0600B342 RID: 45890 RVA: 0x0019259C File Offset: 0x0019079C
		private IStateProgramSpecialProcessChangeTeamOptimization_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateProgramSpecialProcessChangeTeamOptimization 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateProgramSpecialProcessChangeTeamOptimization_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateProgramSpecialProcessChangeTeamOptimization_SetValue());
			}
			return result;
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x001925D4 File Offset: 0x001907D4
		public static IStateProgramSpecialProcessChangeTeamOptimization Create([Nullable(2)] IStateProgramSpecialProcessChangeTeamOptimization instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateProgramSpecialProcessChangeTeamOptimization
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x001925E7 File Offset: 0x001907E7
		public static IStateProgramSpecialProcessChangeTeamOptimization CreateFromSetValue([Nullable(2)] IStateProgramSpecialProcessChangeTeamOptimization_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateProgramSpecialProcessChangeTeamOptimization
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x001925FA File Offset: 0x001907FA
		public new IStateProgramSpecialProcessChangeTeamOptimization_SetValue ToSetValue()
		{
			return new IStateProgramSpecialProcessChangeTeamOptimization_SetValue
			{
				Type = this.Type,
				IsOpenBlackScreen = this.IsOpenBlackScreen
			};
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600B346 RID: 45894 RVA: 0x00192619 File Offset: 0x00190819
		// (set) Token: 0x0600B347 RID: 45895 RVA: 0x00192644 File Offset: 0x00190844
		public override ELogicProgramSpecialProcess Type
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

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x00192654 File Offset: 0x00190854
		// (set) Token: 0x0600B349 RID: 45897 RVA: 0x0019268E File Offset: 0x0019088E
		public virtual bool? IsOpenBlackScreen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOpenBlackScreen;
				}
				IStateProgramSpecialProcessChangeTeamOptimization_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOpenBlackScreen;
			}
			set
			{
				this.GetOrCreatePoco().IsOpenBlackScreen = value;
			}
		}

		// Token: 0x04006A4B RID: 27211
		[Nullable(2)]
		protected new IStateProgramSpecialProcessChangeTeamOptimization FbInstance;

		// Token: 0x04006A4C RID: 27212
		[Nullable(2)]
		protected new IStateProgramSpecialProcessChangeTeamOptimization_SetValue PocoInterface;
	}
}
