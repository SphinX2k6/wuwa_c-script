using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002842 RID: 10306
	public class IProjectionMachinePhotoFilter
	{
		// Token: 0x0600E47A RID: 58490 RVA: 0x0021A0DE File Offset: 0x002182DE
		[NullableContext(1)]
		public static IProjectionMachinePhotoFilter Create(IProjectionMachinePhotoFilter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectionMachinePhotoFilter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x0600E47B RID: 58491 RVA: 0x0021A0FD File Offset: 0x002182FD
		public virtual float DefaultParam1
		{
			get
			{
				return this.Instance.DefaultParam1;
			}
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x0600E47C RID: 58492 RVA: 0x0021A10A File Offset: 0x0021830A
		public virtual float DefaultParam2
		{
			get
			{
				return this.Instance.DefaultParam2;
			}
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x0600E47D RID: 58493 RVA: 0x0021A117 File Offset: 0x00218317
		public virtual float TargetParam1
		{
			get
			{
				return this.Instance.TargetParam1;
			}
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x0600E47E RID: 58494 RVA: 0x0021A124 File Offset: 0x00218324
		public virtual float TargetParam2
		{
			get
			{
				return this.Instance.TargetParam2;
			}
		}

		// Token: 0x04007E6A RID: 32362
		private IProjectionMachinePhotoFilter Instance;
	}
}
