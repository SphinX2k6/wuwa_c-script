using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001451 RID: 5201
	public class IFastReturnEntityPos : IFastReturnPosBase
	{
		// Token: 0x060075B2 RID: 30130 RVA: 0x0011A99B File Offset: 0x00118B9B
		public static IFastReturnEntityPos Create(IFastReturnEntityPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnEntityPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x060075B3 RID: 30131 RVA: 0x0011A9BA File Offset: 0x00118BBA
		public override EFastReturnPosType Type
		{
			get
			{
				return (EFastReturnPosType)this.Instance.Type;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x060075B4 RID: 30132 RVA: 0x0011A9C7 File Offset: 0x00118BC7
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x060075B5 RID: 30133 RVA: 0x0011A9D4 File Offset: 0x00118BD4
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = QuestReadHelper.ReadIFastReturnEntityPos_TransitionOption(this.Instance);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x0400433B RID: 17211
		private IFastReturnEntityPos Instance;

		// Token: 0x0400433C RID: 17212
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x0400433D RID: 17213
		private bool _TransitionOptionInited;
	}
}
