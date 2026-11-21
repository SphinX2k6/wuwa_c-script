using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001452 RID: 5202
	public class IFastReturnGravityEntityPos : IFastReturnPosBase
	{
		// Token: 0x060075B7 RID: 30135 RVA: 0x0011AA0B File Offset: 0x00118C0B
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

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x060075B8 RID: 30136 RVA: 0x0011AA2A File Offset: 0x00118C2A
		public override EFastReturnPosType Type
		{
			get
			{
				return (EFastReturnPosType)this.Instance.Type;
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x060075B9 RID: 30137 RVA: 0x0011AA37 File Offset: 0x00118C37
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x060075BA RID: 30138 RVA: 0x0011AA44 File Offset: 0x00118C44
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

		// Token: 0x0400433E RID: 17214
		private IFastReturnGravityEntityPos Instance;

		// Token: 0x0400433F RID: 17215
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x04004340 RID: 17216
		private bool _TransitionOptionInited;
	}
}
