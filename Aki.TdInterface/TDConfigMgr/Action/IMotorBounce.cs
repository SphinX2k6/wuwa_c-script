using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C10 RID: 7184
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorBounce : ILeisureInteractType
	{
		// Token: 0x06009A01 RID: 39425 RVA: 0x001624E4 File Offset: 0x001606E4
		[NullableContext(1)]
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

		// Token: 0x06009A02 RID: 39426 RVA: 0x0016251C File Offset: 0x0016071C
		[NullableContext(1)]
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

		// Token: 0x06009A03 RID: 39427 RVA: 0x0016252F File Offset: 0x0016072F
		[NullableContext(1)]
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

		// Token: 0x06009A04 RID: 39428 RVA: 0x00162544 File Offset: 0x00160744
		[NullableContext(1)]
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

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x06009A05 RID: 39429 RVA: 0x00162592 File Offset: 0x00160792
		// (set) Token: 0x06009A06 RID: 39430 RVA: 0x001625BD File Offset: 0x001607BD
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

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x001625CB File Offset: 0x001607CB
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x001625F6 File Offset: 0x001607F6
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

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06009A09 RID: 39433 RVA: 0x00162604 File Offset: 0x00160804
		// (set) Token: 0x06009A0A RID: 39434 RVA: 0x0016263E File Offset: 0x0016083E
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

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x0016264C File Offset: 0x0016084C
		// (set) Token: 0x06009A0C RID: 39436 RVA: 0x00162673 File Offset: 0x00160873
		public virtual string MotionCurve
		{
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
			set
			{
				this.GetOrCreatePoco().MotionCurve = value;
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06009A0D RID: 39437 RVA: 0x00162684 File Offset: 0x00160884
		// (set) Token: 0x06009A0E RID: 39438 RVA: 0x001626BE File Offset: 0x001608BE
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

		// Token: 0x04005DB6 RID: 23990
		protected new IMotorBounce FbInstance;

		// Token: 0x04005DB7 RID: 23991
		protected new IMotorBounce_SetValue PocoInterface;
	}
}
