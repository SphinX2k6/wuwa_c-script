using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EE7 RID: 24295
	public class ISceneTextComponentT
	{
		// Token: 0x1700B38D RID: 45965
		// (get) Token: 0x06028BD6 RID: 166870 RVA: 0x005919CA File Offset: 0x0058FBCA
		// (set) Token: 0x06028BD7 RID: 166871 RVA: 0x005919D2 File Offset: 0x0058FBD2
		public bool Disabled { get; set; }

		// Token: 0x1700B38E RID: 45966
		// (get) Token: 0x06028BD8 RID: 166872 RVA: 0x005919DB File Offset: 0x0058FBDB
		// (set) Token: 0x06028BD9 RID: 166873 RVA: 0x005919E3 File Offset: 0x0058FBE3
		public string DisplayState { get; set; }

		// Token: 0x1700B38F RID: 45967
		// (get) Token: 0x06028BDA RID: 166874 RVA: 0x005919EC File Offset: 0x0058FBEC
		// (set) Token: 0x06028BDB RID: 166875 RVA: 0x005919F4 File Offset: 0x0058FBF4
		public IPosAndRotT RelativeTransform { get; set; }

		// Token: 0x1700B390 RID: 45968
		// (get) Token: 0x06028BDC RID: 166876 RVA: 0x005919FD File Offset: 0x0058FBFD
		// (set) Token: 0x06028BDD RID: 166877 RVA: 0x00591A05 File Offset: 0x0058FC05
		public TSceneTextUnion TextConfig { get; set; }

		// Token: 0x1700B391 RID: 45969
		// (get) Token: 0x06028BDE RID: 166878 RVA: 0x00591A0E File Offset: 0x0058FC0E
		// (set) Token: 0x06028BDF RID: 166879 RVA: 0x00591A16 File Offset: 0x0058FC16
		public byte NullMask { get; set; }

		// Token: 0x06028BE0 RID: 166880 RVA: 0x00591A1F File Offset: 0x0058FC1F
		public ISceneTextComponentT()
		{
			this.Disabled = false;
			this.DisplayState = null;
			this.RelativeTransform = null;
			this.TextConfig = null;
			this.NullMask = 0;
		}
	}
}
