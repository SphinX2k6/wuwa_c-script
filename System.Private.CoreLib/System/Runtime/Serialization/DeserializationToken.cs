using System;

namespace System.Runtime.Serialization
{
	// Token: 0x02000519 RID: 1305
	public readonly struct DeserializationToken : IDisposable
	{
		// Token: 0x06004876 RID: 18550 RVA: 0x000F12AD File Offset: 0x000EF4AD
		internal DeserializationToken(DeserializationTracker tracker)
		{
			this._tracker = tracker;
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x000F12B8 File Offset: 0x000EF4B8
		public void Dispose()
		{
			if (this._tracker != null && this._tracker.DeserializationInProgress)
			{
				DeserializationTracker tracker = this._tracker;
				lock (tracker)
				{
					if (this._tracker.DeserializationInProgress)
					{
						this._tracker.DeserializationInProgress = false;
						SerializationInfo.AsyncDeserializationInProgress.Value = false;
					}
				}
			}
		}

		// Token: 0x04001158 RID: 4440
		private readonly DeserializationTracker _tracker;
	}
}
