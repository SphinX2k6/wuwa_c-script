using System;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EB9 RID: 24249
	public class DetectionRecord<T> where T : struct
	{
		// Token: 0x0603DAFA RID: 252666 RVA: 0x00EE51D9 File Offset: 0x00EE33D9
		public DetectionRecord(in T conf, bool isLock, long? refreshTime)
		{
			this.IsLock = isLock;
			this.RefreshTime = refreshTime;
			this.ConfInternal = new T?(conf);
		}

		// Token: 0x17008EB9 RID: 36537
		// (get) Token: 0x0603DAFB RID: 252667 RVA: 0x00EE520D File Offset: 0x00EE340D
		public T Conf
		{
			get
			{
				return this.ConfInternal.Value;
			}
		}

		// Token: 0x04020318 RID: 131864
		private readonly T? ConfInternal;

		// Token: 0x04020319 RID: 131865
		public bool IsLock;

		// Token: 0x0402031A RID: 131866
		public long? RefreshTime = new long?(0L);

		// Token: 0x0402031B RID: 131867
		public bool IsTargeting;
	}
}
