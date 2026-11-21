using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F2 RID: 8434
	public class IStateProgramSpecialProcessBase
	{
		// Token: 0x0600B33A RID: 45882 RVA: 0x001924E0 File Offset: 0x001906E0
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

		// Token: 0x0600B33B RID: 45883 RVA: 0x00192518 File Offset: 0x00190718
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

		// Token: 0x0600B33C RID: 45884 RVA: 0x0019252B File Offset: 0x0019072B
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

		// Token: 0x0600B33D RID: 45885 RVA: 0x0019253E File Offset: 0x0019073E
		public IStateProgramSpecialProcessBase_SetValue ToSetValue()
		{
			return new IStateProgramSpecialProcessBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600B33E RID: 45886 RVA: 0x00192551 File Offset: 0x00190751
		// (set) Token: 0x0600B33F RID: 45887 RVA: 0x0019257C File Offset: 0x0019077C
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

		// Token: 0x04006A48 RID: 27208
		[Nullable(2)]
		protected IStateProgramSpecialProcessBase FbInstance;

		// Token: 0x04006A49 RID: 27209
		[Nullable(2)]
		protected IStateProgramSpecialProcessBase_SetValue PocoInterface;
	}
}
