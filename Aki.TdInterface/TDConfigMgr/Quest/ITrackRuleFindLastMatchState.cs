using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001302 RID: 4866
	public class ITrackRuleFindLastMatchState : ITrackRuleTypeBase
	{
		// Token: 0x06006DAF RID: 28079 RVA: 0x00105354 File Offset: 0x00103554
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

		// Token: 0x06006DB0 RID: 28080 RVA: 0x0010538C File Offset: 0x0010358C
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

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0010539F File Offset: 0x0010359F
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

		// Token: 0x06006DB2 RID: 28082 RVA: 0x001053B2 File Offset: 0x001035B2
		public new ITrackRuleFindLastMatchState_SetValue ToSetValue()
		{
			return new ITrackRuleFindLastMatchState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x001053D1 File Offset: 0x001035D1
		// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x001053FC File Offset: 0x001035FC
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

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x0010540A File Offset: 0x0010360A
		// (set) Token: 0x06006DB6 RID: 28086 RVA: 0x00105435 File Offset: 0x00103635
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

		// Token: 0x04004184 RID: 16772
		[Nullable(2)]
		protected new ITrackRuleFindLastMatchState FbInstance;

		// Token: 0x04004185 RID: 16773
		[Nullable(2)]
		protected new ITrackRuleFindLastMatchState_SetValue PocoInterface;
	}
}
