using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200156B RID: 5483
	public class ICheckSpringFestivalGuessJokerCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x06007B95 RID: 31637 RVA: 0x00125DBE File Offset: 0x00123FBE
		public static ICheckSpringFestivalGuessJokerCompleted Create(ICheckSpringFestivalGuessJokerCompleted? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckSpringFestivalGuessJokerCompleted
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x06007B96 RID: 31638 RVA: 0x00125DDD File Offset: 0x00123FDD
		public override ESpringFestivalGameplayType Type
		{
			get
			{
				return (ESpringFestivalGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x06007B97 RID: 31639 RVA: 0x00125DEC File Offset: 0x00123FEC
		public virtual int? Id
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Id);
			}
		}

		// Token: 0x04004733 RID: 18227
		private ICheckSpringFestivalGuessJokerCompleted Instance;
	}
}
