using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021DC RID: 8668
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSportsState : ActionParams
	{
		// Token: 0x0600BE77 RID: 48759 RVA: 0x001B6824 File Offset: 0x001B4A24
		private SetSportsState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetSportsState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetSportsState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetSportsState_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x001B685C File Offset: 0x001B4A5C
		public static SetSportsState Create([Nullable(2)] SetSportsState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSportsState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE79 RID: 48761 RVA: 0x001B686F File Offset: 0x001B4A6F
		public static SetSportsState CreateFromSetValue([Nullable(2)] SetSportsState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetSportsState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE7A RID: 48762 RVA: 0x001B6882 File Offset: 0x001B4A82
		public SetSportsState_SetValue ToSetValue()
		{
			return new SetSportsState_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600BE7B RID: 48763 RVA: 0x001B6895 File Offset: 0x001B4A95
		// (set) Token: 0x0600BE7C RID: 48764 RVA: 0x001B68BC File Offset: 0x001B4ABC
		public virtual ISportConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				SetSportsState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040071AB RID: 29099
		[Nullable(2)]
		protected new SetSportsState FbInstance;

		// Token: 0x040071AC RID: 29100
		[Nullable(2)]
		protected SetSportsState_SetValue PocoInterface;
	}
}
