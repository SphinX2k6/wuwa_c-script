using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A3 RID: 24995
	public class IWoodenOxenAndFlowingHorsesPerformT
	{
		// Token: 0x1700BA67 RID: 47719
		// (get) Token: 0x0602A7BF RID: 174015 RVA: 0x005CB883 File Offset: 0x005C9A83
		// (set) Token: 0x0602A7C0 RID: 174016 RVA: 0x005CB88B File Offset: 0x005C9A8B
		public EVehicleType Type { get; set; }

		// Token: 0x1700BA68 RID: 47720
		// (get) Token: 0x0602A7C1 RID: 174017 RVA: 0x005CB894 File Offset: 0x005C9A94
		// (set) Token: 0x0602A7C2 RID: 174018 RVA: 0x005CB89C File Offset: 0x005C9A9C
		public string Montage { get; set; }

		// Token: 0x1700BA69 RID: 47721
		// (get) Token: 0x0602A7C3 RID: 174019 RVA: 0x005CB8A5 File Offset: 0x005C9AA5
		// (set) Token: 0x0602A7C4 RID: 174020 RVA: 0x005CB8AD File Offset: 0x005C9AAD
		public IWoodenOxenAndFlowingHorsesPerformConfigT MountPerformLeft { get; set; }

		// Token: 0x1700BA6A RID: 47722
		// (get) Token: 0x0602A7C5 RID: 174021 RVA: 0x005CB8B6 File Offset: 0x005C9AB6
		// (set) Token: 0x0602A7C6 RID: 174022 RVA: 0x005CB8BE File Offset: 0x005C9ABE
		public IWoodenOxenAndFlowingHorsesPerformConfigT MountPerformRight { get; set; }

		// Token: 0x1700BA6B RID: 47723
		// (get) Token: 0x0602A7C7 RID: 174023 RVA: 0x005CB8C7 File Offset: 0x005C9AC7
		// (set) Token: 0x0602A7C8 RID: 174024 RVA: 0x005CB8CF File Offset: 0x005C9ACF
		public IWoodenOxenAndFlowingHorsesPerformConfigT DismountPerformLeft { get; set; }

		// Token: 0x1700BA6C RID: 47724
		// (get) Token: 0x0602A7C9 RID: 174025 RVA: 0x005CB8D8 File Offset: 0x005C9AD8
		// (set) Token: 0x0602A7CA RID: 174026 RVA: 0x005CB8E0 File Offset: 0x005C9AE0
		public IWoodenOxenAndFlowingHorsesPerformConfigT DismountPerformRight { get; set; }

		// Token: 0x0602A7CB RID: 174027 RVA: 0x005CB8E9 File Offset: 0x005C9AE9
		public IWoodenOxenAndFlowingHorsesPerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
			this.MountPerformLeft = null;
			this.MountPerformRight = null;
			this.DismountPerformLeft = null;
			this.DismountPerformRight = null;
		}
	}
}
