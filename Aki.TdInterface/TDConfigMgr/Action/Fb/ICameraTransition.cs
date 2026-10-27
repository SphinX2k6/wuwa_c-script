using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002908 RID: 10504
	public class ICameraTransition : ILevelSequenceTransitionType
	{
		// Token: 0x0600E92E RID: 59694 RVA: 0x002231EA File Offset: 0x002213EA
		[NullableContext(1)]
		public static ICameraTransition Create(ICameraTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x0600E92F RID: 59695 RVA: 0x00223209 File Offset: 0x00221409
		public override ELevelSequenceTransition Type
		{
			get
			{
				return (ELevelSequenceTransition)this.Instance.Type;
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x0600E930 RID: 59696 RVA: 0x00223218 File Offset: 0x00221418
		public override float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x040080BA RID: 32954
		private ICameraTransition Instance;
	}
}
