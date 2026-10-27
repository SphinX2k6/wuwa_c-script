using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001414 RID: 5140
	public class ICheckSpringFestivalGuessJokerCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x060074D4 RID: 29908 RVA: 0x001173DA File Offset: 0x001155DA
		[NullableContext(1)]
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

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x060074D5 RID: 29909 RVA: 0x001173F9 File Offset: 0x001155F9
		public override ESpringFestivalGameplayType Type
		{
			get
			{
				return (ESpringFestivalGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x060074D6 RID: 29910 RVA: 0x00117408 File Offset: 0x00115608
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

		// Token: 0x040043A2 RID: 17314
		private ICheckSpringFestivalGuessJokerCompleted Instance;
	}
}
