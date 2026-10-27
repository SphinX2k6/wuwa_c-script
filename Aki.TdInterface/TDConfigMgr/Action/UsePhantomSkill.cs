using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200226B RID: 8811
	[NullableContext(2)]
	[Nullable(0)]
	public class UsePhantomSkill : ActionParams
	{
		// Token: 0x0600C14C RID: 49484 RVA: 0x001BBA48 File Offset: 0x001B9C48
		[NullableContext(1)]
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

		// Token: 0x0600C14D RID: 49485 RVA: 0x001BBA80 File Offset: 0x001B9C80
		[NullableContext(1)]
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

		// Token: 0x0600C14E RID: 49486 RVA: 0x001BBA93 File Offset: 0x001B9C93
		[NullableContext(1)]
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

		// Token: 0x0600C14F RID: 49487 RVA: 0x001BBAA6 File Offset: 0x001B9CA6
		[NullableContext(1)]
		public UsePhantomSkill_SetValue ToSetValue()
		{
			return new UsePhantomSkill_SetValue
			{
				SkillType = this.SkillType,
				BlackboardPos = this.BlackboardPos,
				BlackboardRot = this.BlackboardRot
			};
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0600C150 RID: 49488 RVA: 0x001BBAD1 File Offset: 0x001B9CD1
		// (set) Token: 0x0600C151 RID: 49489 RVA: 0x001BBAFC File Offset: 0x001B9CFC
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

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x0600C152 RID: 49490 RVA: 0x001BBB0C File Offset: 0x001B9D0C
		// (set) Token: 0x0600C153 RID: 49491 RVA: 0x001BBB6D File Offset: 0x001B9D6D
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

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600C154 RID: 49492 RVA: 0x001BBB84 File Offset: 0x001B9D84
		// (set) Token: 0x0600C155 RID: 49493 RVA: 0x001BBBE5 File Offset: 0x001B9DE5
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

		// Token: 0x0400732C RID: 29484
		protected new UsePhantomSkill FbInstance;

		// Token: 0x0400732D RID: 29485
		protected UsePhantomSkill_SetValue PocoInterface;

		// Token: 0x0400732E RID: 29486
		[Nullable(1)]
		private ISkillBlackboardVector _BlackboardPosCache;

		// Token: 0x0400732F RID: 29487
		private bool _BlackboardPosInited;

		// Token: 0x04007330 RID: 29488
		[Nullable(1)]
		private ISkillBlackboardVector _BlackboardRotCache;

		// Token: 0x04007331 RID: 29489
		private bool _BlackboardRotInited;
	}
}
