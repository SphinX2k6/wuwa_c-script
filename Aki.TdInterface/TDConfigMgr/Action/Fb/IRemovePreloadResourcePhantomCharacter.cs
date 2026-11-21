using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD7 RID: 11479
	[NullableContext(2)]
	[Nullable(0)]
	public class IRemovePreloadResourcePhantomCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600FB89 RID: 64393 RVA: 0x00246DCC File Offset: 0x00244FCC
		[NullableContext(0)]
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

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x0600FB8A RID: 64394 RVA: 0x00246DEB File Offset: 0x00244FEB
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x0600FB8B RID: 64395 RVA: 0x00246DF8 File Offset: 0x00244FF8
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x0600FB8C RID: 64396 RVA: 0x00246E05 File Offset: 0x00245005
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

		// Token: 0x0400896F RID: 35183
		private IRemovePreloadResourcePhantomCharacter Instance;

		// Token: 0x04008970 RID: 35184
		private IDelayRemoveAfterSkillFinish _DelayReMoveCache;

		// Token: 0x04008971 RID: 35185
		private bool _DelayReMoveInited;
	}
}
