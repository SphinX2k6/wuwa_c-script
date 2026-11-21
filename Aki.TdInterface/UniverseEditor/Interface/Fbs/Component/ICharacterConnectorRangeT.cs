using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B5 RID: 21685
	public class ICharacterConnectorRangeT
	{
		// Token: 0x17009A9E RID: 39582
		// (get) Token: 0x0602228D RID: 139917 RVA: 0x004B5694 File Offset: 0x004B3894
		// (set) Token: 0x0602228E RID: 139918 RVA: 0x004B569C File Offset: 0x004B389C
		public ECharacterConnectorLogicType Type { get; set; }

		// Token: 0x17009A9F RID: 39583
		// (get) Token: 0x0602228F RID: 139919 RVA: 0x004B56A5 File Offset: 0x004B38A5
		// (set) Token: 0x06022290 RID: 139920 RVA: 0x004B56AD File Offset: 0x004B38AD
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x17009AA0 RID: 39584
		// (get) Token: 0x06022291 RID: 139921 RVA: 0x004B56B6 File Offset: 0x004B38B6
		// (set) Token: 0x06022292 RID: 139922 RVA: 0x004B56BE File Offset: 0x004B38BE
		public int EnterRange { get; set; }

		// Token: 0x17009AA1 RID: 39585
		// (get) Token: 0x06022293 RID: 139923 RVA: 0x004B56C7 File Offset: 0x004B38C7
		// (set) Token: 0x06022294 RID: 139924 RVA: 0x004B56CF File Offset: 0x004B38CF
		public int LeaveRange { get; set; }

		// Token: 0x17009AA2 RID: 39586
		// (get) Token: 0x06022295 RID: 139925 RVA: 0x004B56D8 File Offset: 0x004B38D8
		// (set) Token: 0x06022296 RID: 139926 RVA: 0x004B56E0 File Offset: 0x004B38E0
		public List<int> TagConditions { get; set; }

		// Token: 0x17009AA3 RID: 39587
		// (get) Token: 0x06022297 RID: 139927 RVA: 0x004B56E9 File Offset: 0x004B38E9
		// (set) Token: 0x06022298 RID: 139928 RVA: 0x004B56F1 File Offset: 0x004B38F1
		public List<IDynamicEntityMatchT> MatchConditions { get; set; }

		// Token: 0x17009AA4 RID: 39588
		// (get) Token: 0x06022299 RID: 139929 RVA: 0x004B56FA File Offset: 0x004B38FA
		// (set) Token: 0x0602229A RID: 139930 RVA: 0x004B5702 File Offset: 0x004B3902
		public List<IDynamicEntityMatchT> KeepConditions { get; set; }

		// Token: 0x17009AA5 RID: 39589
		// (get) Token: 0x0602229B RID: 139931 RVA: 0x004B570B File Offset: 0x004B390B
		// (set) Token: 0x0602229C RID: 139932 RVA: 0x004B5713 File Offset: 0x004B3913
		public byte NullMask { get; set; }

		// Token: 0x0602229D RID: 139933 RVA: 0x004B571C File Offset: 0x004B391C
		public ICharacterConnectorRangeT()
		{
			this.Type = ECharacterConnectorLogicType.Range;
			this.EffectConfig = null;
			this.EnterRange = 0;
			this.LeaveRange = 0;
			this.TagConditions = null;
			this.MatchConditions = null;
			this.KeepConditions = null;
			this.NullMask = 0;
		}
	}
}
