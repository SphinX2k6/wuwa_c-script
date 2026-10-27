using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E6 RID: 6118
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioState
	{
		// Token: 0x06008369 RID: 33641 RVA: 0x00139CF8 File Offset: 0x00137EF8
		private IAudioState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioState_SetValue());
			}
			return result;
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x00139D30 File Offset: 0x00137F30
		public static IAudioState Create([Nullable(2)] IAudioState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x00139D43 File Offset: 0x00137F43
		public static IAudioState CreateFromSetValue([Nullable(2)] IAudioState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x00139D56 File Offset: 0x00137F56
		public IAudioState_SetValue ToSetValue()
		{
			return new IAudioState_SetValue
			{
				Group = this.Group,
				State = this.State
			};
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600836D RID: 33645 RVA: 0x00139D75 File Offset: 0x00137F75
		// (set) Token: 0x0600836E RID: 33646 RVA: 0x00139DA0 File Offset: 0x00137FA0
		public virtual string Group
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Group;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Group;
			}
			set
			{
				this.GetOrCreatePoco().Group = value;
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600836F RID: 33647 RVA: 0x00139DAE File Offset: 0x00137FAE
		// (set) Token: 0x06008370 RID: 33648 RVA: 0x00139DD9 File Offset: 0x00137FD9
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

		// Token: 0x04005365 RID: 21349
		[Nullable(2)]
		protected IAudioState FbInstance;

		// Token: 0x04005366 RID: 21350
		[Nullable(2)]
		protected IAudioState_SetValue PocoInterface;
	}
}
