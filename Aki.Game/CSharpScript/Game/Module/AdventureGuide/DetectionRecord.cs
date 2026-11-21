using System;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004E9E RID: 20126
	public class DetectionRecord<T> where T : struct
	{
		// Token: 0x06032A8A RID: 207498 RVA: 0x00E36725 File Offset: 0x00E34925
		public DetectionRecord(in T conf, bool isLock, long? refreshTime)
		{
			this.IsLock = isLock;
			this.RefreshTime = refreshTime;
			this.ConfInternal = new T?(conf);
		}

		// Token: 0x1700628B RID: 25227
		// (get) Token: 0x06032A8B RID: 207499 RVA: 0x00E36759 File Offset: 0x00E34959
		public T Conf
		{
			get
			{
				return this.ConfInternal.Value;
			}
		}

		// Token: 0x0401ADDF RID: 110047
		private readonly T? ConfInternal;

		// Token: 0x0401ADE0 RID: 110048
		public bool IsLock;

		// Token: 0x0401ADE1 RID: 110049
		public long? RefreshTime = new long?(0L);

		// Token: 0x0401ADE2 RID: 110050
		public bool IsTargeting;
	}
}
