using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B82 RID: 2946
	public class ISpawnMonsterConstraintAnnularSector : ISpwanMonsterMode
	{
		// Token: 0x060043CC RID: 17356 RVA: 0x000AC938 File Offset: 0x000AAB38
		[NullableContext(1)]
		public static ISpawnMonsterConstraintAnnularSector Create(ISpawnMonsterConstraintAnnularSector? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterConstraintAnnularSector
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x000AC957 File Offset: 0x000AAB57
		public override ESpawnMonsterConstraint Type
		{
			get
			{
				return (ESpawnMonsterConstraint)this.Instance.Type;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x060043CE RID: 17358 RVA: 0x000AC964 File Offset: 0x000AAB64
		public virtual float InnerRadius
		{
			get
			{
				return this.Instance.InnerRadius;
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x000AC971 File Offset: 0x000AAB71
		public virtual float OuterRadius
		{
			get
			{
				return this.Instance.OuterRadius;
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x060043D0 RID: 17360 RVA: 0x000AC97E File Offset: 0x000AAB7E
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x0400263B RID: 9787
		private ISpawnMonsterConstraintAnnularSector Instance;
	}
}
