using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780A RID: 30730
	public class ISetNpcSequencePerformT
	{
		// Token: 0x1700E141 RID: 57665
		// (get) Token: 0x06035FFB RID: 221179 RVA: 0x0073BBC3 File Offset: 0x00739DC3
		// (set) Token: 0x06035FFC RID: 221180 RVA: 0x0073BBCB File Offset: 0x00739DCB
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700E142 RID: 57666
		// (get) Token: 0x06035FFD RID: 221181 RVA: 0x0073BBD4 File Offset: 0x00739DD4
		// (set) Token: 0x06035FFE RID: 221182 RVA: 0x0073BBDC File Offset: 0x00739DDC
		public string Sequence { get; set; }

		// Token: 0x1700E143 RID: 57667
		// (get) Token: 0x06035FFF RID: 221183 RVA: 0x0073BBE5 File Offset: 0x00739DE5
		// (set) Token: 0x06036000 RID: 221184 RVA: 0x0073BBED File Offset: 0x00739DED
		public List<INpcGroupSequencePlaySettingT> PlaySettings { get; set; }

		// Token: 0x1700E144 RID: 57668
		// (get) Token: 0x06036001 RID: 221185 RVA: 0x0073BBF6 File Offset: 0x00739DF6
		// (set) Token: 0x06036002 RID: 221186 RVA: 0x0073BBFE File Offset: 0x00739DFE
		public INpcGroupSequenceStaticEntityBindingT Binding { get; set; }

		// Token: 0x1700E145 RID: 57669
		// (get) Token: 0x06036003 RID: 221187 RVA: 0x0073BC07 File Offset: 0x00739E07
		// (set) Token: 0x06036004 RID: 221188 RVA: 0x0073BC0F File Offset: 0x00739E0F
		public List<INpcGroupSequenceBlendAnimT> BlendOutAnim { get; set; }

		// Token: 0x1700E146 RID: 57670
		// (get) Token: 0x06036005 RID: 221189 RVA: 0x0073BC18 File Offset: 0x00739E18
		// (set) Token: 0x06036006 RID: 221190 RVA: 0x0073BC20 File Offset: 0x00739E20
		public byte NullMask { get; set; }

		// Token: 0x06036007 RID: 221191 RVA: 0x0073BC29 File Offset: 0x00739E29
		public ISetNpcSequencePerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Sequence = null;
			this.PlaySettings = null;
			this.Binding = null;
			this.BlendOutAnim = null;
			this.NullMask = 0;
		}
	}
}
