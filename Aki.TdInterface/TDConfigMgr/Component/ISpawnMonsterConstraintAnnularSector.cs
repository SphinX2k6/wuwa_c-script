using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000789 RID: 1929
	public class ISpawnMonsterConstraintAnnularSector : ISpwanMonsterMode
	{
		// Token: 0x06002938 RID: 10552 RVA: 0x0006D3D0 File Offset: 0x0006B5D0
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

		// Token: 0x06002939 RID: 10553 RVA: 0x0006D408 File Offset: 0x0006B608
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

		// Token: 0x0600293A RID: 10554 RVA: 0x0006D41B File Offset: 0x0006B61B
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

		// Token: 0x0600293B RID: 10555 RVA: 0x0006D42E File Offset: 0x0006B62E
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

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x0006D465 File Offset: 0x0006B665
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x0006D490 File Offset: 0x0006B690
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

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x0006D49E File Offset: 0x0006B69E
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x0006D4CD File Offset: 0x0006B6CD
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

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x0006D4DB File Offset: 0x0006B6DB
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x0006D50A File Offset: 0x0006B70A
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

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x0006D518 File Offset: 0x0006B718
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x0006D547 File Offset: 0x0006B747
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

		// Token: 0x04001BEA RID: 7146
		[Nullable(2)]
		protected new ISpawnMonsterConstraintAnnularSector FbInstance;

		// Token: 0x04001BEB RID: 7147
		[Nullable(2)]
		protected new ISpawnMonsterConstraintAnnularSector_SetValue PocoInterface;
	}
}
