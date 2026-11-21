using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DFF RID: 7679
	public class IMotorBounce : ILeisureInteractType
	{
		// Token: 0x0600A331 RID: 41777 RVA: 0x00175430 File Offset: 0x00173630
		private IMotorBounce_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorBounce 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorBounce_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorBounce_SetValue());
			}
			return result;
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x00175468 File Offset: 0x00173668
		public static IMotorBounce Create([Nullable(2)] IMotorBounce instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorBounce
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x0017547B File Offset: 0x0017367B
		public static IMotorBounce CreateFromSetValue([Nullable(2)] IMotorBounce_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorBounce
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x00175490 File Offset: 0x00173690
		public new IMotorBounce_SetValue ToSetValue()
		{
			return new IMotorBounce_SetValue
			{
				Type = this.Type,
				Height = this.Height,
				Time = this.Time,
				MotionCurve = this.MotionCurve,
				SkillType = this.SkillType
			};
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600A335 RID: 41781 RVA: 0x001754DE File Offset: 0x001736DE
		// (set) Token: 0x0600A336 RID: 41782 RVA: 0x00175509 File Offset: 0x00173709
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600A337 RID: 41783 RVA: 0x00175517 File Offset: 0x00173717
		// (set) Token: 0x0600A338 RID: 41784 RVA: 0x00175542 File Offset: 0x00173742
		public virtual int Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600A339 RID: 41785 RVA: 0x00175550 File Offset: 0x00173750
		// (set) Token: 0x0600A33A RID: 41786 RVA: 0x0017558A File Offset: 0x0017378A
		public virtual float? Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				IMotorBounce_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600A33B RID: 41787 RVA: 0x00175598 File Offset: 0x00173798
		// (set) Token: 0x0600A33C RID: 41788 RVA: 0x001755BF File Offset: 0x001737BF
		[Nullable(2)]
		public virtual string MotionCurve
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotionCurve;
				}
				IMotorBounce_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MotionCurve;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MotionCurve = value;
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600A33D RID: 41789 RVA: 0x001755D0 File Offset: 0x001737D0
		// (set) Token: 0x0600A33E RID: 41790 RVA: 0x0017560A File Offset: 0x0017380A
		public virtual EMotorBounceSkillType? SkillType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillType;
				}
				IMotorBounce_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkillType;
			}
			set
			{
				this.GetOrCreatePoco().SkillType = value;
			}
		}

		// Token: 0x040062DD RID: 25309
		[Nullable(2)]
		protected new IMotorBounce FbInstance;

		// Token: 0x040062DE RID: 25310
		[Nullable(2)]
		protected new IMotorBounce_SetValue PocoInterface;
	}
}
