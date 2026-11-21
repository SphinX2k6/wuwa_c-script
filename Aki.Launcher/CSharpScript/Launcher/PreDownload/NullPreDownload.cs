using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x0200011A RID: 282
	[NullableContext(1)]
	[Nullable(0)]
	public class NullPreDownload : IPreDownload
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x00042E02 File Offset: 0x00041002
		public bool IsPreDownloadEnabled()
		{
			return false;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00042E05 File Offset: 0x00041005
		public void CheckEnabledWithTick()
		{
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00042E07 File Offset: 0x00041007
		public void TryRemoveTick()
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00042E09 File Offset: 0x00041009
		public void AddEnabledEvent(Action cb)
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00042E0B File Offset: 0x0004100B
		public void RemoveEnabledEvent(Action cb)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00042E0D File Offset: 0x0004100D
		public void AddCompleteEvent(Action cb)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00042E0F File Offset: 0x0004100F
		public void RemoveCompleteEvent(Action cb)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00042E11 File Offset: 0x00041011
		public void SetView(IPreDownloadUiEvent ui)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00042E13 File Offset: 0x00041013
		public void ClearView()
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00042E15 File Offset: 0x00041015
		public long GetDownloadSize()
		{
			return 0L;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00042E19 File Offset: 0x00041019
		public long GetNeedSpace()
		{
			return 0L;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00042E1D File Offset: 0x0004101D
		public void Start(EPreDownloadMode mode)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00042E1F File Offset: 0x0004101F
		public void Stop()
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00042E21 File Offset: 0x00041021
		public void Resume()
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00042E23 File Offset: 0x00041023
		public bool IsDownloading()
		{
			return false;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00042E26 File Offset: 0x00041026
		public bool IsComplete()
		{
			return false;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00042E29 File Offset: 0x00041029
		public EPreDownloadState GetState()
		{
			return EPreDownloadState.Disabled;
		}
	}
}
