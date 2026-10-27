using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002907 RID: 10503
	public class ILevelSequenceTransitionType
	{
		// Token: 0x0600E92A RID: 59690 RVA: 0x00223180 File Offset: 0x00221380
		[NullableContext(1)]
		public static ILevelSequenceTransitionType Create(ILevelSequenceTransitionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelSequenceTransitionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x0600E92B RID: 59691 RVA: 0x0022319F File Offset: 0x0022139F
		public virtual ELevelSequenceTransition Type
		{
			get
			{
				return (ELevelSequenceTransition)this.Instance.Type;
			}
		}

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x0600E92C RID: 59692 RVA: 0x002231AC File Offset: 0x002213AC
		public virtual float? Duration
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

		// Token: 0x040080B9 RID: 32953
		private ILevelSequenceTransitionType Instance;
	}
}
