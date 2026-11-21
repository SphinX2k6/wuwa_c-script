using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E0 RID: 25824
	public class ICommonBtT
	{
		// Token: 0x1700BE5F RID: 48735
		// (get) Token: 0x0602BE76 RID: 179830 RVA: 0x005F8678 File Offset: 0x005F6878
		// (set) Token: 0x0602BE77 RID: 179831 RVA: 0x005F8680 File Offset: 0x005F6880
		public string ObjType { get; set; }

		// Token: 0x1700BE60 RID: 48736
		// (get) Token: 0x0602BE78 RID: 179832 RVA: 0x005F8689 File Offset: 0x005F6889
		// (set) Token: 0x0602BE79 RID: 179833 RVA: 0x005F8691 File Offset: 0x005F6891
		public List<string> Children { get; set; }

		// Token: 0x1700BE61 RID: 48737
		// (get) Token: 0x0602BE7A RID: 179834 RVA: 0x005F869A File Offset: 0x005F689A
		// (set) Token: 0x0602BE7B RID: 179835 RVA: 0x005F86A2 File Offset: 0x005F68A2
		public List<string> Reference { get; set; }

		// Token: 0x1700BE62 RID: 48738
		// (get) Token: 0x0602BE7C RID: 179836 RVA: 0x005F86AB File Offset: 0x005F68AB
		// (set) Token: 0x0602BE7D RID: 179837 RVA: 0x005F86B3 File Offset: 0x005F68B3
		public List<string> WeakReference { get; set; }

		// Token: 0x1700BE63 RID: 48739
		// (get) Token: 0x0602BE7E RID: 179838 RVA: 0x005F86BC File Offset: 0x005F68BC
		// (set) Token: 0x0602BE7F RID: 179839 RVA: 0x005F86C4 File Offset: 0x005F68C4
		public int Id { get; set; }

		// Token: 0x1700BE64 RID: 48740
		// (get) Token: 0x0602BE80 RID: 179840 RVA: 0x005F86CD File Offset: 0x005F68CD
		// (set) Token: 0x0602BE81 RID: 179841 RVA: 0x005F86D5 File Offset: 0x005F68D5
		public string Name { get; set; }

		// Token: 0x1700BE65 RID: 48741
		// (get) Token: 0x0602BE82 RID: 179842 RVA: 0x005F86DE File Offset: 0x005F68DE
		// (set) Token: 0x0602BE83 RID: 179843 RVA: 0x005F86E6 File Offset: 0x005F68E6
		public int LevelId { get; set; }

		// Token: 0x1700BE66 RID: 48742
		// (get) Token: 0x0602BE84 RID: 179844 RVA: 0x005F86EF File Offset: 0x005F68EF
		// (set) Token: 0x0602BE85 RID: 179845 RVA: 0x005F86F7 File Offset: 0x005F68F7
		public string AssetPath { get; set; }

		// Token: 0x1700BE67 RID: 48743
		// (get) Token: 0x0602BE86 RID: 179846 RVA: 0x005F8700 File Offset: 0x005F6900
		// (set) Token: 0x0602BE87 RID: 179847 RVA: 0x005F8708 File Offset: 0x005F6908
		public ICommonBtTreeT Tree { get; set; }

		// Token: 0x1700BE68 RID: 48744
		// (get) Token: 0x0602BE88 RID: 179848 RVA: 0x005F8711 File Offset: 0x005F6911
		// (set) Token: 0x0602BE89 RID: 179849 RVA: 0x005F8719 File Offset: 0x005F6919
		public List<ICommonBtPlaceholderT> Placeholders { get; set; }

		// Token: 0x1700BE69 RID: 48745
		// (get) Token: 0x0602BE8A RID: 179850 RVA: 0x005F8722 File Offset: 0x005F6922
		// (set) Token: 0x0602BE8B RID: 179851 RVA: 0x005F872A File Offset: 0x005F692A
		public bool _IsSelectBt { get; set; }

		// Token: 0x1700BE6A RID: 48746
		// (get) Token: 0x0602BE8C RID: 179852 RVA: 0x005F8733 File Offset: 0x005F6933
		// (set) Token: 0x0602BE8D RID: 179853 RVA: 0x005F873B File Offset: 0x005F693B
		public bool _IsShowTaskId { get; set; }

		// Token: 0x1700BE6B RID: 48747
		// (get) Token: 0x0602BE8E RID: 179854 RVA: 0x005F8744 File Offset: 0x005F6944
		// (set) Token: 0x0602BE8F RID: 179855 RVA: 0x005F874C File Offset: 0x005F694C
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x1700BE6C RID: 48748
		// (get) Token: 0x0602BE90 RID: 179856 RVA: 0x005F8755 File Offset: 0x005F6955
		// (set) Token: 0x0602BE91 RID: 179857 RVA: 0x005F875D File Offset: 0x005F695D
		public string _FocusDataPath { get; set; }

		// Token: 0x1700BE6D RID: 48749
		// (get) Token: 0x0602BE92 RID: 179858 RVA: 0x005F8766 File Offset: 0x005F6966
		// (set) Token: 0x0602BE93 RID: 179859 RVA: 0x005F876E File Offset: 0x005F696E
		public string _FocusPlaceholderName { get; set; }

		// Token: 0x1700BE6E RID: 48750
		// (get) Token: 0x0602BE94 RID: 179860 RVA: 0x005F8777 File Offset: 0x005F6977
		// (set) Token: 0x0602BE95 RID: 179861 RVA: 0x005F877F File Offset: 0x005F697F
		public byte NullMask { get; set; }

		// Token: 0x0602BE96 RID: 179862 RVA: 0x005F8788 File Offset: 0x005F6988
		public ICommonBtT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Id = 0;
			this.Name = null;
			this.LevelId = 0;
			this.AssetPath = null;
			this.Tree = null;
			this.Placeholders = null;
			this._IsSelectBt = false;
			this._IsShowTaskId = false;
			this._HighlightDataPaths = null;
			this._FocusDataPath = null;
			this._FocusPlaceholderName = null;
			this.NullMask = 0;
		}
	}
}
