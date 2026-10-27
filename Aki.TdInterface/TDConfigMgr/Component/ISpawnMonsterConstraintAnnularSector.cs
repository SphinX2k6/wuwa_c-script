using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E8 RID: 1768
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterConstraintAnnularSector : ISpwanMonsterMode
	{
		// Token: 0x06002618 RID: 9752 RVA: 0x00066360 File Offset: 0x00064560
		private ISpawnMonsterConstraintAnnularSector_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterConstraintAnnularSector 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterConstraintAnnularSector_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterConstraintAnnularSector_SetValue());
			}
			return result;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00066398 File Offset: 0x00064598
		public static ISpawnMonsterConstraintAnnularSector Create([Nullable(2)] ISpawnMonsterConstraintAnnularSector instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterConstraintAnnularSector
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x000663AB File Offset: 0x000645AB
		public static ISpawnMonsterConstraintAnnularSector CreateFromSetValue([Nullable(2)] ISpawnMonsterConstraintAnnularSector_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterConstraintAnnularSector
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000663BE File Offset: 0x000645BE
		public new ISpawnMonsterConstraintAnnularSector_SetValue ToSetValue()
		{
			return new ISpawnMonsterConstraintAnnularSector_SetValue
			{
				Type = this.Type,
				InnerRadius = this.InnerRadius,
				OuterRadius = this.OuterRadius,
				Angle = this.Angle
			};
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000663F5 File Offset: 0x000645F5
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x00066420 File Offset: 0x00064620
		public override ESpawnMonsterConstraint Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterConstraint.CharacterForwardAnnularSector;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x0006642E File Offset: 0x0006462E
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0006645D File Offset: 0x0006465D
		public virtual float InnerRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InnerRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.InnerRadius;
			}
			set
			{
				this.GetOrCreatePoco().InnerRadius = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x0006646B File Offset: 0x0006466B
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0006649A File Offset: 0x0006469A
		public virtual float OuterRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OuterRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.OuterRadius;
			}
			set
			{
				this.GetOrCreatePoco().OuterRadius = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000664A8 File Offset: 0x000646A8
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x000664D7 File Offset: 0x000646D7
		public virtual float Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x040019EB RID: 6635
		[Nullable(2)]
		protected new ISpawnMonsterConstraintAnnularSector FbInstance;

		// Token: 0x040019EC RID: 6636
		[Nullable(2)]
		protected new ISpawnMonsterConstraintAnnularSector_SetValue PocoInterface;
	}
}
