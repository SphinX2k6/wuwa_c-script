using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200199F RID: 6559
	public class IBpActorFuncTypeBase
	{
		// Token: 0x06008B75 RID: 35701 RVA: 0x0014AC64 File Offset: 0x00148E64
		private IBpActorFuncTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBpActorFuncTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBpActorFuncTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBpActorFuncTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x0014AC9C File Offset: 0x00148E9C
		public static IBpActorFuncTypeBase Create([Nullable(2)] IBpActorFuncTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBpActorFuncTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B77 RID: 35703 RVA: 0x0014ACAF File Offset: 0x00148EAF
		public static IBpActorFuncTypeBase CreateFromSetValue([Nullable(2)] IBpActorFuncTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBpActorFuncTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x0014ACC2 File Offset: 0x00148EC2
		public IBpActorFuncTypeBase_SetValue ToSetValue()
		{
			return new IBpActorFuncTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x06008B79 RID: 35705 RVA: 0x0014ACD5 File Offset: 0x00148ED5
		// (set) Token: 0x06008B7A RID: 35706 RVA: 0x0014AD00 File Offset: 0x00148F00
		public virtual EBpActorFuncType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBpActorFuncType.CarPaintChange;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400580D RID: 22541
		[Nullable(2)]
		protected IBpActorFuncTypeBase FbInstance;

		// Token: 0x0400580E RID: 22542
		[Nullable(2)]
		protected IBpActorFuncTypeBase_SetValue PocoInterface;
	}
}
