using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196F RID: 6511
	public class IAudioState
	{
		// Token: 0x06008A85 RID: 35461 RVA: 0x001493E0 File Offset: 0x001475E0
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

		// Token: 0x06008A86 RID: 35462 RVA: 0x00149418 File Offset: 0x00147618
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

		// Token: 0x06008A87 RID: 35463 RVA: 0x0014942B File Offset: 0x0014762B
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

		// Token: 0x06008A88 RID: 35464 RVA: 0x0014943E File Offset: 0x0014763E
		public IAudioState_SetValue ToSetValue()
		{
			return new IAudioState_SetValue
			{
				Group = this.Group,
				State = this.State
			};
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x06008A89 RID: 35465 RVA: 0x0014945D File Offset: 0x0014765D
		// (set) Token: 0x06008A8A RID: 35466 RVA: 0x00149488 File Offset: 0x00147688
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

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x06008A8B RID: 35467 RVA: 0x00149496 File Offset: 0x00147696
		// (set) Token: 0x06008A8C RID: 35468 RVA: 0x001494C1 File Offset: 0x001476C1
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

		// Token: 0x040057AD RID: 22445
		[Nullable(2)]
		protected IAudioState FbInstance;

		// Token: 0x040057AE RID: 22446
		[Nullable(2)]
		protected IAudioState_SetValue PocoInterface;
	}
}
