using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CE RID: 10446
	[NullableContext(2)]
	[Nullable(0)]
	public class UsePhantomSkill : ActionParams
	{
		// Token: 0x0600E803 RID: 59395 RVA: 0x00220E7E File Offset: 0x0021F07E
		[NullableContext(1)]
		public static UsePhantomSkill Create(IUsePhantomSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UsePhantomSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x0600E804 RID: 59396 RVA: 0x00220E9D File Offset: 0x0021F09D
		public virtual EPhantomSkillType SkillType
		{
			get
			{
				return (EPhantomSkillType)this.Instance.SkillType;
			}
		}

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x0600E805 RID: 59397 RVA: 0x00220EAA File Offset: 0x0021F0AA
		public virtual ISkillBlackboardVector BlackboardPos
		{
			get
			{
				if (this._BlackboardPosInited)
				{
					return this._BlackboardPosCache;
				}
				this._BlackboardPosInited = true;
				this._BlackboardPosCache = ISkillBlackboardVector.Create(this.Instance.BlackboardPos);
				return this._BlackboardPosCache;
			}
		}

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x0600E806 RID: 59398 RVA: 0x00220EDE File Offset: 0x0021F0DE
		public virtual ISkillBlackboardVector BlackboardRot
		{
			get
			{
				if (this._BlackboardRotInited)
				{
					return this._BlackboardRotCache;
				}
				this._BlackboardRotInited = true;
				this._BlackboardRotCache = ISkillBlackboardVector.Create(this.Instance.BlackboardRot);
				return this._BlackboardRotCache;
			}
		}

		// Token: 0x04008042 RID: 32834
		private IUsePhantomSkill Instance;

		// Token: 0x04008043 RID: 32835
		private ISkillBlackboardVector _BlackboardPosCache;

		// Token: 0x04008044 RID: 32836
		private bool _BlackboardPosInited;

		// Token: 0x04008045 RID: 32837
		private ISkillBlackboardVector _BlackboardRotCache;

		// Token: 0x04008046 RID: 32838
		private bool _BlackboardRotInited;
	}
}
