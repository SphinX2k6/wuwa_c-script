using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D5B RID: 7515
	public class ILiveInteractDanmakuTriggerBattleEvent : ILiveInteractDanmakuTrigger
	{
		// Token: 0x06009F91 RID: 40849 RVA: 0x0016E594 File Offset: 0x0016C794
		private ILiveInteractDanmakuTriggerBattleEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveInteractDanmakuTriggerBattleEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveInteractDanmakuTriggerBattleEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveInteractDanmakuTriggerBattleEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x0016E5CC File Offset: 0x0016C7CC
		public static ILiveInteractDanmakuTriggerBattleEvent Create([Nullable(2)] ILiveInteractDanmakuTriggerBattleEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerBattleEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x0016E5DF File Offset: 0x0016C7DF
		public static ILiveInteractDanmakuTriggerBattleEvent CreateFromSetValue([Nullable(2)] ILiveInteractDanmakuTriggerBattleEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerBattleEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x0016E5F2 File Offset: 0x0016C7F2
		public new ILiveInteractDanmakuTriggerBattleEvent_SetValue ToSetValue()
		{
			return new ILiveInteractDanmakuTriggerBattleEvent_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				BattleEventId = this.BattleEventId
			};
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x06009F95 RID: 40853 RVA: 0x0016E61D File Offset: 0x0016C81D
		// (set) Token: 0x06009F96 RID: 40854 RVA: 0x0016E648 File Offset: 0x0016C848
		public override ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveInteractDanmakuTriggerType.SkillGenre;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x06009F97 RID: 40855 RVA: 0x0016E656 File Offset: 0x0016C856
		// (set) Token: 0x06009F98 RID: 40856 RVA: 0x0016E681 File Offset: 0x0016C881
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x06009F99 RID: 40857 RVA: 0x0016E68F File Offset: 0x0016C88F
		// (set) Token: 0x06009F9A RID: 40858 RVA: 0x0016E6BA File Offset: 0x0016C8BA
		public virtual int BattleEventId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BattleEventId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BattleEventId;
			}
			set
			{
				this.GetOrCreatePoco().BattleEventId = value;
			}
		}

		// Token: 0x0400611B RID: 24859
		[Nullable(2)]
		protected new ILiveInteractDanmakuTriggerBattleEvent FbInstance;

		// Token: 0x0400611C RID: 24860
		[Nullable(2)]
		protected new ILiveInteractDanmakuTriggerBattleEvent_SetValue PocoInterface;
	}
}
