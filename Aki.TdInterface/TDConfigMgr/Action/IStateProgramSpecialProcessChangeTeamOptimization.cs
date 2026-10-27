using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EBB RID: 7867
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateProgramSpecialProcessChangeTeamOptimization : IStateProgramSpecialProcessBase
	{
		// Token: 0x0600A870 RID: 43120 RVA: 0x0017C5A4 File Offset: 0x0017A7A4
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

		// Token: 0x0600A871 RID: 43121 RVA: 0x0017C5DC File Offset: 0x0017A7DC
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

		// Token: 0x0600A872 RID: 43122 RVA: 0x0017C5EF File Offset: 0x0017A7EF
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

		// Token: 0x0600A873 RID: 43123 RVA: 0x0017C602 File Offset: 0x0017A802
		public new IStateProgramSpecialProcessChangeTeamOptimization_SetValue ToSetValue()
		{
			return new IStateProgramSpecialProcessChangeTeamOptimization_SetValue
			{
				Type = this.Type,
				IsOpenBlackScreen = this.IsOpenBlackScreen
			};
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600A874 RID: 43124 RVA: 0x0017C621 File Offset: 0x0017A821
		// (set) Token: 0x0600A875 RID: 43125 RVA: 0x0017C64C File Offset: 0x0017A84C
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

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600A876 RID: 43126 RVA: 0x0017C65C File Offset: 0x0017A85C
		// (set) Token: 0x0600A877 RID: 43127 RVA: 0x0017C696 File Offset: 0x0017A896
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

		// Token: 0x0400645C RID: 25692
		[Nullable(2)]
		protected new IStateProgramSpecialProcessChangeTeamOptimization FbInstance;

		// Token: 0x0400645D RID: 25693
		[Nullable(2)]
		protected new IStateProgramSpecialProcessChangeTeamOptimization_SetValue PocoInterface;
	}
}
