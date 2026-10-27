using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001302 RID: 4866
	[NullableContext(1)]
	[Nullable(0)]
	public class IFastReturnGravityEntityPos : IFastReturnPosBase
	{
		// Token: 0x06006F17 RID: 28439 RVA: 0x0010C49F File Offset: 0x0010A69F
		public static IFastReturnGravityEntityPos Create(IFastReturnGravityEntityPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnGravityEntityPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x0010C4BE File Offset: 0x0010A6BE
		public override EFastReturnPosType Type
		{
			get
			{
				return (EFastReturnPosType)this.Instance.Type;
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x06006F19 RID: 28441 RVA: 0x0010C4CB File Offset: 0x0010A6CB
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x06006F1A RID: 28442 RVA: 0x0010C4D8 File Offset: 0x0010A6D8
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = QuestReadHelper.ReadIFastReturnGravityEntityPos_TransitionOption(this.Instance);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x04003FC2 RID: 16322
		private IFastReturnGravityEntityPos Instance;

		// Token: 0x04003FC3 RID: 16323
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x04003FC4 RID: 16324
		private bool _TransitionOptionInited;
	}
}
