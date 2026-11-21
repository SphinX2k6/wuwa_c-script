using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B79 RID: 7033
	[JsonConverter(typeof(IEnablePlayerAiControlConverter))]
	public class IEnablePlayerAiControl : IPlayerAiControlBase
	{
		// Token: 0x06009559 RID: 38233 RVA: 0x0015C2F0 File Offset: 0x0015A4F0
		private IEnablePlayerAiControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnablePlayerAiControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnablePlayerAiControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnablePlayerAiControl_SetValue());
			}
			return result;
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x0015C328 File Offset: 0x0015A528
		public static IEnablePlayerAiControl Create([Nullable(2)] IEnablePlayerAiControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnablePlayerAiControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x0015C33B File Offset: 0x0015A53B
		public static IEnablePlayerAiControl CreateFromSetValue([Nullable(2)] IEnablePlayerAiControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnablePlayerAiControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600955C RID: 38236 RVA: 0x0015C34E File Offset: 0x0015A54E
		public new IEnablePlayerAiControl_SetValue ToSetValue()
		{
			return new IEnablePlayerAiControl_SetValue
			{
				Type = this.Type,
				BehaviorTree = this.BehaviorTree
			};
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x0015C36D File Offset: 0x0015A56D
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x0015C398 File Offset: 0x0015A598
		public override EPlayerAiControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerAiControlType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x0015C3A6 File Offset: 0x0015A5A6
		// (set) Token: 0x06009560 RID: 38240 RVA: 0x0015C3D1 File Offset: 0x0015A5D1
		public virtual int BehaviorTree
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BehaviorTree;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BehaviorTree;
			}
			set
			{
				this.GetOrCreatePoco().BehaviorTree = value;
			}
		}

		// Token: 0x04005C7A RID: 23674
		[Nullable(2)]
		protected new IEnablePlayerAiControl FbInstance;

		// Token: 0x04005C7B RID: 23675
		[Nullable(2)]
		protected new IEnablePlayerAiControl_SetValue PocoInterface;
	}
}
