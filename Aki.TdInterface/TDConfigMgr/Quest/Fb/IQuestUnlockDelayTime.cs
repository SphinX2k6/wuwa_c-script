using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001450 RID: 5200
	public class IQuestUnlockDelayTime
	{
		// Token: 0x0600763B RID: 30267 RVA: 0x0011A76F File Offset: 0x0011896F
		[NullableContext(1)]
		public static IQuestUnlockDelayTime Create(IQuestUnlockDelayTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestUnlockDelayTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x0011A78E File Offset: 0x0011898E
		public virtual int Day
		{
			get
			{
				return this.Instance.Day;
			}
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600763D RID: 30269 RVA: 0x0011A79B File Offset: 0x0011899B
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600763E RID: 30270 RVA: 0x0011A7A8 File Offset: 0x001189A8
		public virtual int Minute
		{
			get
			{
				return this.Instance.Minute;
			}
		}

		// Token: 0x040044AA RID: 17578
		private IQuestUnlockDelayTime Instance;
	}
}
