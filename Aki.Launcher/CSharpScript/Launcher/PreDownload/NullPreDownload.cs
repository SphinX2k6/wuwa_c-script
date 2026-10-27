using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x02000116 RID: 278
	[NullableContext(1)]
	[Nullable(0)]
	public class NullPreDownload : IPreDownload
	{
		// Token: 0x060008D6 RID: 2262 RVA: 0x00040A3A File Offset: 0x0003EC3A
		public bool IsPreDownloadEnabled()
		{
			return false;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00040A3D File Offset: 0x0003EC3D
		public void CheckEnabledWithTick()
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00040A3F File Offset: 0x0003EC3F
		public void TryRemoveTick()
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00040A41 File Offset: 0x0003EC41
		public void AddEnabledEvent(Action cb)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00040A43 File Offset: 0x0003EC43
		public void RemoveEnabledEvent(Action cb)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00040A45 File Offset: 0x0003EC45
		public void AddCompleteEvent(Action cb)
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00040A47 File Offset: 0x0003EC47
		public void RemoveCompleteEvent(Action cb)
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00040A49 File Offset: 0x0003EC49
		public void SetView(IPreDownloadUiEvent ui)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00040A4B File Offset: 0x0003EC4B
		public void ClearView()
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00040A4D File Offset: 0x0003EC4D
		public long GetDownloadSize()
		{
			return 0L;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00040A51 File Offset: 0x0003EC51
		public long GetNeedSpace()
		{
			return 0L;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00040A55 File Offset: 0x0003EC55
		public void Start(EPreDownloadMode mode)
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00040A57 File Offset: 0x0003EC57
		public void Stop()
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00040A59 File Offset: 0x0003EC59
		public void Resume()
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00040A5B File Offset: 0x0003EC5B
		public bool IsDownloading()
		{
			return false;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00040A5E File Offset: 0x0003EC5E
		public bool IsComplete()
		{
			return false;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00040A61 File Offset: 0x0003EC61
		public EPreDownloadState GetState()
		{
			return EPreDownloadState.Disabled;
		}
	}
}
