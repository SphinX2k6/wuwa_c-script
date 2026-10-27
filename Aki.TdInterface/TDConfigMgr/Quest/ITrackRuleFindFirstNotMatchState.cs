using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C4 RID: 4548
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackRuleFindFirstNotMatchState : ITrackRuleTypeBase
	{
		// Token: 0x06006764 RID: 26468 RVA: 0x000F7948 File Offset: 0x000F5B48
		private ITrackRuleFindFirstNotMatchState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackRuleFindFirstNotMatchState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackRuleFindFirstNotMatchState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackRuleFindFirstNotMatchState_SetValue());
			}
			return result;
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x000F7980 File Offset: 0x000F5B80
		public static ITrackRuleFindFirstNotMatchState Create([Nullable(2)] ITrackRuleFindFirstNotMatchState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleFindFirstNotMatchState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x000F7993 File Offset: 0x000F5B93
		public static ITrackRuleFindFirstNotMatchState CreateFromSetValue([Nullable(2)] ITrackRuleFindFirstNotMatchState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackRuleFindFirstNotMatchState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x000F79A6 File Offset: 0x000F5BA6
		public new ITrackRuleFindFirstNotMatchState_SetValue ToSetValue()
		{
			return new ITrackRuleFindFirstNotMatchState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x000F79C5 File Offset: 0x000F5BC5
		// (set) Token: 0x06006769 RID: 26473 RVA: 0x000F79F0 File Offset: 0x000F5BF0
		public override ETrackRuleType Type
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

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x000F79FE File Offset: 0x000F5BFE
		// (set) Token: 0x0600676B RID: 26475 RVA: 0x000F7A29 File Offset: 0x000F5C29
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04003E12 RID: 15890
		[Nullable(2)]
		protected new ITrackRuleFindFirstNotMatchState FbInstance;

		// Token: 0x04003E13 RID: 15891
		[Nullable(2)]
		protected new ITrackRuleFindFirstNotMatchState_SetValue PocoInterface;
	}
}
