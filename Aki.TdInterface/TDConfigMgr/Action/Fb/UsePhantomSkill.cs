using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA3 RID: 11171
	[NullableContext(2)]
	[Nullable(0)]
	public class UsePhantomSkill : ActionParams
	{
		// Token: 0x0600F632 RID: 63026 RVA: 0x0023DDFE File Offset: 0x0023BFFE
		[NullableContext(0)]
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

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x0600F633 RID: 63027 RVA: 0x0023DE1D File Offset: 0x0023C01D
		public virtual EPhantomSkillType SkillType
		{
			get
			{
				return (EPhantomSkillType)this.Instance.SkillType;
			}
		}

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x0600F634 RID: 63028 RVA: 0x0023DE2A File Offset: 0x0023C02A
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

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x0600F635 RID: 63029 RVA: 0x0023DE5E File Offset: 0x0023C05E
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

		// Token: 0x04008701 RID: 34561
		private IUsePhantomSkill Instance;

		// Token: 0x04008702 RID: 34562
		private ISkillBlackboardVector _BlackboardPosCache;

		// Token: 0x04008703 RID: 34563
		private bool _BlackboardPosInited;

		// Token: 0x04008704 RID: 34564
		private ISkillBlackboardVector _BlackboardRotCache;

		// Token: 0x04008705 RID: 34565
		private bool _BlackboardRotInited;
	}
}
