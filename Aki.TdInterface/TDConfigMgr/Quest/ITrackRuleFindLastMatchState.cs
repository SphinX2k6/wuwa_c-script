using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C6 RID: 4550
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackRuleFindLastMatchState : ITrackRuleTypeBase
	{
		// Token: 0x0600676E RID: 26478 RVA: 0x000F7A48 File Offset: 0x000F5C48
		private ITrackRuleFindLastMatchState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackRuleFindLastMatchState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackRuleFindLastMatchState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackRuleFindLastMatchState_SetValue());
			}
			return result;
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x000F7A80 File Offset: 0x000F5C80
		public static ITrackRuleFindLastMatchState Create([Nullable(2)] ITrackRuleFindLastMatchState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleFindLastMatchState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x000F7A93 File Offset: 0x000F5C93
		public static ITrackRuleFindLastMatchState CreateFromSetValue([Nullable(2)] ITrackRuleFindLastMatchState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackRuleFindLastMatchState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x000F7AA6 File Offset: 0x000F5CA6
		public new ITrackRuleFindLastMatchState_SetValue ToSetValue()
		{
			return new ITrackRuleFindLastMatchState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06006772 RID: 26482 RVA: 0x000F7AC5 File Offset: 0x000F5CC5
		// (set) Token: 0x06006773 RID: 26483 RVA: 0x000F7AF0 File Offset: 0x000F5CF0
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

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06006774 RID: 26484 RVA: 0x000F7AFE File Offset: 0x000F5CFE
		// (set) Token: 0x06006775 RID: 26485 RVA: 0x000F7B29 File Offset: 0x000F5D29
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

		// Token: 0x04003E16 RID: 15894
		[Nullable(2)]
		protected new ITrackRuleFindLastMatchState FbInstance;

		// Token: 0x04003E17 RID: 15895
		[Nullable(2)]
		protected new ITrackRuleFindLastMatchState_SetValue PocoInterface;
	}
}
