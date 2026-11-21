using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x02000119 RID: 281
	[NullableContext(1)]
	public interface IPreDownload
	{
		// Token: 0x060008F9 RID: 2297
		bool IsPreDownloadEnabled();

		// Token: 0x060008FA RID: 2298
		void CheckEnabledWithTick();

		// Token: 0x060008FB RID: 2299
		void TryRemoveTick();

		// Token: 0x060008FC RID: 2300
		void AddEnabledEvent(Action cb);

		// Token: 0x060008FD RID: 2301
		void RemoveEnabledEvent(Action cb);

		// Token: 0x060008FE RID: 2302
		void AddCompleteEvent(Action cb);

		// Token: 0x060008FF RID: 2303
		void RemoveCompleteEvent(Action cb);

		// Token: 0x06000900 RID: 2304
		void SetView(IPreDownloadUiEvent ui);

		// Token: 0x06000901 RID: 2305
		void ClearView();

		// Token: 0x06000902 RID: 2306
		long GetDownloadSize();

		// Token: 0x06000903 RID: 2307
		long GetNeedSpace();

		// Token: 0x06000904 RID: 2308
		void Start(EPreDownloadMode mode);

		// Token: 0x06000905 RID: 2309
		void Stop();

		// Token: 0x06000906 RID: 2310
		void Resume();

		// Token: 0x06000907 RID: 2311
		bool IsDownloading();

		// Token: 0x06000908 RID: 2312
		bool IsComplete();

		// Token: 0x06000909 RID: 2313
		EPreDownloadState GetState();
	}
}
