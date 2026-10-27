using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F3 RID: 8691
	[NullableContext(1)]
	[Nullable(0)]
	public class SetWuYinQuState : ActionParams
	{
		// Token: 0x0600BEE1 RID: 48865 RVA: 0x001B7294 File Offset: 0x001B5494
		private SetWuYinQuState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetWuYinQuState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetWuYinQuState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetWuYinQuState_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x001B72CC File Offset: 0x001B54CC
		public static SetWuYinQuState Create([Nullable(2)] SetWuYinQuState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWuYinQuState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEE3 RID: 48867 RVA: 0x001B72DF File Offset: 0x001B54DF
		public static SetWuYinQuState CreateFromSetValue([Nullable(2)] SetWuYinQuState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetWuYinQuState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEE4 RID: 48868 RVA: 0x001B72F2 File Offset: 0x001B54F2
		public SetWuYinQuState_SetValue ToSetValue()
		{
			return new SetWuYinQuState_SetValue
			{
				WuYinQuName = this.WuYinQuName,
				State = this.State
			};
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0600BEE5 RID: 48869 RVA: 0x001B7311 File Offset: 0x001B5511
		// (set) Token: 0x0600BEE6 RID: 48870 RVA: 0x001B733C File Offset: 0x001B553C
		public virtual string WuYinQuName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WuYinQuName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WuYinQuName;
			}
			set
			{
				this.GetOrCreatePoco().WuYinQuName = value;
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0600BEE7 RID: 48871 RVA: 0x001B734A File Offset: 0x001B554A
		// (set) Token: 0x0600BEE8 RID: 48872 RVA: 0x001B7375 File Offset: 0x001B5575
		public virtual EWuYinQuState State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return EWuYinQuState.End;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x040071D7 RID: 29143
		[Nullable(2)]
		protected new SetWuYinQuState FbInstance;

		// Token: 0x040071D8 RID: 29144
		[Nullable(2)]
		protected SetWuYinQuState_SetValue PocoInterface;
	}
}
