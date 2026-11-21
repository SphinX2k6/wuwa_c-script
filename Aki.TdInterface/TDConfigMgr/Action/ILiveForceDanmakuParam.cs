using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D53 RID: 7507
	public class ILiveForceDanmakuParam : ILiveParamConfig
	{
		// Token: 0x06009F65 RID: 40805 RVA: 0x0016E10C File Offset: 0x0016C30C
		private ILiveForceDanmakuParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveForceDanmakuParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveForceDanmakuParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveForceDanmakuParam_SetValue());
			}
			return result;
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x0016E144 File Offset: 0x0016C344
		public static ILiveForceDanmakuParam Create([Nullable(2)] ILiveForceDanmakuParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveForceDanmakuParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x0016E157 File Offset: 0x0016C357
		public static ILiveForceDanmakuParam CreateFromSetValue([Nullable(2)] ILiveForceDanmakuParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveForceDanmakuParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x0016E16A File Offset: 0x0016C36A
		public new ILiveForceDanmakuParam_SetValue ToSetValue()
		{
			return new ILiveForceDanmakuParam_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x06009F69 RID: 40809 RVA: 0x0016E189 File Offset: 0x0016C389
		// (set) Token: 0x06009F6A RID: 40810 RVA: 0x0016E1B4 File Offset: 0x0016C3B4
		public override ELiveParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveParamType.Heat;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x06009F6B RID: 40811 RVA: 0x0016E1C2 File Offset: 0x0016C3C2
		// (set) Token: 0x06009F6C RID: 40812 RVA: 0x0016E1ED File Offset: 0x0016C3ED
		public virtual ELiveForceDanmakuState State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return ELiveForceDanmakuState.Force;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04006109 RID: 24841
		[Nullable(2)]
		protected new ILiveForceDanmakuParam FbInstance;

		// Token: 0x0400610A RID: 24842
		[Nullable(2)]
		protected new ILiveForceDanmakuParam_SetValue PocoInterface;
	}
}
