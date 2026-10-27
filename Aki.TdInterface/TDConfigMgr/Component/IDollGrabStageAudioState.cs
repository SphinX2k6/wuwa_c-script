using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C9 RID: 713
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabStageAudioState
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x00032200 File Offset: 0x00030400
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

		// Token: 0x06000D6E RID: 3438 RVA: 0x00032238 File Offset: 0x00030438
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

		// Token: 0x06000D6F RID: 3439 RVA: 0x0003224B File Offset: 0x0003044B
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

		// Token: 0x06000D70 RID: 3440 RVA: 0x0003225E File Offset: 0x0003045E
		public IDollGrabStageAudioState_SetValue ToSetValue()
		{
			return new IDollGrabStageAudioState_SetValue
			{
				Group = this.Group,
				State = this.State
			};
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0003227D File Offset: 0x0003047D
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x000322A8 File Offset: 0x000304A8
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

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x000322B6 File Offset: 0x000304B6
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x000322E1 File Offset: 0x000304E1
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

		// Token: 0x04000C2F RID: 3119
		[Nullable(2)]
		protected IDollGrabStageAudioState FbInstance;

		// Token: 0x04000C30 RID: 3120
		[Nullable(2)]
		protected IDollGrabStageAudioState_SetValue PocoInterface;
	}
}
