using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x02000115 RID: 277
	[NullableContext(1)]
	public interface IPreDownload
	{
		// Token: 0x060008C5 RID: 2245
		bool IsPreDownloadEnabled();

		// Token: 0x060008C6 RID: 2246
		void CheckEnabledWithTick();

		// Token: 0x060008C7 RID: 2247
		void TryRemoveTick();

		// Token: 0x060008C8 RID: 2248
		void AddEnabledEvent(Action cb);

		// Token: 0x060008C9 RID: 2249
		void RemoveEnabledEvent(Action cb);

		// Token: 0x060008CA RID: 2250
		void AddCompleteEvent(Action cb);

		// Token: 0x060008CB RID: 2251
		void RemoveCompleteEvent(Action cb);

		// Token: 0x060008CC RID: 2252
		void SetView(IPreDownloadUiEvent ui);

		// Token: 0x060008CD RID: 2253
		void ClearView();

		// Token: 0x060008CE RID: 2254
		long GetDownloadSize();

		// Token: 0x060008CF RID: 2255
		long GetNeedSpace();

		// Token: 0x060008D0 RID: 2256
		void Start(EPreDownloadMode mode);

		// Token: 0x060008D1 RID: 2257
		void Stop();

		// Token: 0x060008D2 RID: 2258
		void Resume();

		// Token: 0x060008D3 RID: 2259
		bool IsDownloading();

		// Token: 0x060008D4 RID: 2260
		bool IsComplete();

		// Token: 0x060008D5 RID: 2261
		EPreDownloadState GetState();
	}
}
