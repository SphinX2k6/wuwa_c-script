using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024D8 RID: 9432
	[NullableContext(2)]
	[Nullable(0)]
	public class UsePhantomSkill : ActionParams
	{
		// Token: 0x0600CD12 RID: 52498 RVA: 0x001D31CC File Offset: 0x001D13CC
		[NullableContext(0)]
		private UsePhantomSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UsePhantomSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UsePhantomSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UsePhantomSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD13 RID: 52499 RVA: 0x001D3204 File Offset: 0x001D1404
		[NullableContext(0)]
		public static UsePhantomSkill Create([Nullable(2)] UsePhantomSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UsePhantomSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD14 RID: 52500 RVA: 0x001D3217 File Offset: 0x001D1417
		[NullableContext(0)]
		public static UsePhantomSkill CreateFromSetValue([Nullable(2)] UsePhantomSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UsePhantomSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD15 RID: 52501 RVA: 0x001D322A File Offset: 0x001D142A
		[NullableContext(0)]
		public UsePhantomSkill_SetValue ToSetValue()
		{
			return new UsePhantomSkill_SetValue
			{
				SkillType = this.SkillType,
				BlackboardPos = this.BlackboardPos,
				BlackboardRot = this.BlackboardRot
			};
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x001D3255 File Offset: 0x001D1455
		// (set) Token: 0x0600CD17 RID: 52503 RVA: 0x001D3280 File Offset: 0x001D1480
		public virtual EPhantomSkillType SkillType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillType;
				}
				if (this.PocoInterface == null)
				{
					return EPhantomSkillType.ChallengeSuccess;
				}
				return this.PocoInterface.SkillType;
			}
			set
			{
				this.GetOrCreatePoco().SkillType = value;
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x0600CD18 RID: 52504 RVA: 0x001D3290 File Offset: 0x001D1490
		// (set) Token: 0x0600CD19 RID: 52505 RVA: 0x001D32F1 File Offset: 0x001D14F1
		public virtual ISkillBlackboardVector BlackboardPos
		{
			get
			{
				if (this._BlackboardPosInited)
				{
					return this._BlackboardPosCache;
				}
				this._BlackboardPosInited = true;
				if (this.FbInstance != null)
				{
					this._BlackboardPosCache = ISkillBlackboardVector.Create(this.FbInstance.BlackboardPos);
				}
				else
				{
					UsePhantomSkill_SetValue pocoInterface = this.PocoInterface;
					this._BlackboardPosCache = ((pocoInterface != null) ? pocoInterface.BlackboardPos : null);
				}
				return this._BlackboardPosCache;
			}
			set
			{
				this.GetOrCreatePoco().BlackboardPos = value;
				this._BlackboardPosInited = false;
			}
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x001D3308 File Offset: 0x001D1508
		// (set) Token: 0x0600CD1B RID: 52507 RVA: 0x001D3369 File Offset: 0x001D1569
		public virtual ISkillBlackboardVector BlackboardRot
		{
			get
			{
				if (this._BlackboardRotInited)
				{
					return this._BlackboardRotCache;
				}
				this._BlackboardRotInited = true;
				if (this.FbInstance != null)
				{
					this._BlackboardRotCache = ISkillBlackboardVector.Create(this.FbInstance.BlackboardRot);
				}
				else
				{
					UsePhantomSkill_SetValue pocoInterface = this.PocoInterface;
					this._BlackboardRotCache = ((pocoInterface != null) ? pocoInterface.BlackboardRot : null);
				}
				return this._BlackboardRotCache;
			}
			set
			{
				this.GetOrCreatePoco().BlackboardRot = value;
				this._BlackboardRotInited = false;
			}
		}

		// Token: 0x04007979 RID: 31097
		protected new UsePhantomSkill FbInstance;

		// Token: 0x0400797A RID: 31098
		protected UsePhantomSkill_SetValue PocoInterface;

		// Token: 0x0400797B RID: 31099
		[Nullable(0)]
		private ISkillBlackboardVector _BlackboardPosCache;

		// Token: 0x0400797C RID: 31100
		private bool _BlackboardPosInited;

		// Token: 0x0400797D RID: 31101
		[Nullable(0)]
		private ISkillBlackboardVector _BlackboardRotCache;

		// Token: 0x0400797E RID: 31102
		private bool _BlackboardRotInited;
	}
}
