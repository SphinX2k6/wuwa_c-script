using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000310 RID: 784
	public class IDollGrabStageAudioState
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x00035134 File Offset: 0x00033334
		private IDollGrabStageAudioState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabStageAudioState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabStageAudioState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabStageAudioState_SetValue());
			}
			return result;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0003516C File Offset: 0x0003336C
		public static IDollGrabStageAudioState Create([Nullable(2)] IDollGrabStageAudioState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabStageAudioState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0003517F File Offset: 0x0003337F
		public static IDollGrabStageAudioState CreateFromSetValue([Nullable(2)] IDollGrabStageAudioState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabStageAudioState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00035192 File Offset: 0x00033392
		public IDollGrabStageAudioState_SetValue ToSetValue()
		{
			return new IDollGrabStageAudioState_SetValue
			{
				Group = this.Group,
				State = this.State
			};
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x000351B1 File Offset: 0x000333B1
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x000351DC File Offset: 0x000333DC
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

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000351EA File Offset: 0x000333EA
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00035215 File Offset: 0x00033415
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

		// Token: 0x04000D19 RID: 3353
		[Nullable(2)]
		protected IDollGrabStageAudioState FbInstance;

		// Token: 0x04000D1A RID: 3354
		[Nullable(2)]
		protected IDollGrabStageAudioState_SetValue PocoInterface;
	}
}
