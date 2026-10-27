using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EA RID: 10730
	[NullableContext(2)]
	[Nullable(0)]
	public class IRemovePreloadResourcePhantomCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600ECF2 RID: 60658 RVA: 0x00229448 File Offset: 0x00227648
		[NullableContext(1)]
		public static IRemovePreloadResourcePhantomCharacter Create(IRemovePreloadResourcePhantomCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourcePhantomCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AE0 RID: 19168
		// (get) Token: 0x0600ECF3 RID: 60659 RVA: 0x00229467 File Offset: 0x00227667
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004AE1 RID: 19169
		// (get) Token: 0x0600ECF4 RID: 60660 RVA: 0x00229474 File Offset: 0x00227674
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004AE2 RID: 19170
		// (get) Token: 0x0600ECF5 RID: 60661 RVA: 0x00229481 File Offset: 0x00227681
		public virtual IDelayRemoveAfterSkillFinish DelayReMove
		{
			get
			{
				if (this._DelayReMoveInited)
				{
					return this._DelayReMoveCache;
				}
				this._DelayReMoveInited = true;
				this._DelayReMoveCache = IDelayRemoveAfterSkillFinish.Create(this.Instance.DelayReMove);
				return this._DelayReMoveCache;
			}
		}

		// Token: 0x0400827E RID: 33406
		private IRemovePreloadResourcePhantomCharacter Instance;

		// Token: 0x0400827F RID: 33407
		private IDelayRemoveAfterSkillFinish _DelayReMoveCache;

		// Token: 0x04008280 RID: 33408
		private bool _DelayReMoveInited;
	}
}
