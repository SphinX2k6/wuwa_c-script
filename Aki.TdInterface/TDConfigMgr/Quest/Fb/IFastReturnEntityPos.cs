using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001301 RID: 4865
	[NullableContext(1)]
	[Nullable(0)]
	public class IFastReturnEntityPos : IFastReturnPosBase
	{
		// Token: 0x06006F12 RID: 28434 RVA: 0x0010C42F File Offset: 0x0010A62F
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

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x06006F13 RID: 28435 RVA: 0x0010C44E File Offset: 0x0010A64E
		public override EFastReturnPosType Type
		{
			get
			{
				return (EFastReturnPosType)this.Instance.Type;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x0010C45B File Offset: 0x0010A65B
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x06006F15 RID: 28437 RVA: 0x0010C468 File Offset: 0x0010A668
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

		// Token: 0x04003FBF RID: 16319
		private IFastReturnEntityPos Instance;

		// Token: 0x04003FC0 RID: 16320
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x04003FC1 RID: 16321
		private bool _TransitionOptionInited;
	}
}
