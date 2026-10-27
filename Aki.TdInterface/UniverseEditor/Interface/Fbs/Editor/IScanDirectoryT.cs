using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A5 RID: 18597
	public class IScanDirectoryT
	{
		// Token: 0x170086DB RID: 34523
		// (get) Token: 0x0601D072 RID: 118898 RVA: 0x004198D3 File Offset: 0x00417AD3
		// (set) Token: 0x0601D073 RID: 118899 RVA: 0x004198DB File Offset: 0x00417ADB
		public bool IsEnable { get; set; }

		// Token: 0x170086DC RID: 34524
		// (get) Token: 0x0601D074 RID: 118900 RVA: 0x004198E4 File Offset: 0x00417AE4
		// (set) Token: 0x0601D075 RID: 118901 RVA: 0x004198EC File Offset: 0x00417AEC
		public string Path { get; set; }

		// Token: 0x0601D076 RID: 118902 RVA: 0x004198F5 File Offset: 0x00417AF5
		public IScanDirectoryT()
		{
			this.IsEnable = false;
			this.Path = null;
		}
	}
}
