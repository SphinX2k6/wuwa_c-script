using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A21 RID: 6689
	public class ICheckFlowLookAtPlayer : ICheckFlowLookAtTarget
	{
		// Token: 0x06008E53 RID: 36435 RVA: 0x00150288 File Offset: 0x0014E488
		private ICheckFlowLookAtPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckFlowLookAtPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckFlowLookAtPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckFlowLookAtPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x001502C0 File Offset: 0x0014E4C0
		public static ICheckFlowLookAtPlayer Create([Nullable(2)] ICheckFlowLookAtPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x001502D3 File Offset: 0x0014E4D3
		public static ICheckFlowLookAtPlayer CreateFromSetValue([Nullable(2)] ICheckFlowLookAtPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckFlowLookAtPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x001502E6 File Offset: 0x0014E4E6
		public new ICheckFlowLookAtPlayer_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x06008E57 RID: 36439 RVA: 0x001502F9 File Offset: 0x0014E4F9
		// (set) Token: 0x06008E58 RID: 36440 RVA: 0x00150324 File Offset: 0x0014E524
		public override ECheckFlowLookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400596F RID: 22895
		[Nullable(2)]
		protected new ICheckFlowLookAtPlayer FbInstance;

		// Token: 0x04005970 RID: 22896
		[Nullable(2)]
		protected new ICheckFlowLookAtPlayer_SetValue PocoInterface;
	}
}
