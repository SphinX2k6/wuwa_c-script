using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417C RID: 16764
	public class ITakePhoto2ConditionT
	{
		// Token: 0x170076BE RID: 30398
		// (get) Token: 0x06018A31 RID: 100913 RVA: 0x0038C8DC File Offset: 0x0038AADC
		// (set) Token: 0x06018A32 RID: 100914 RVA: 0x0038C8E4 File Offset: 0x0038AAE4
		public EChildQuest Type { get; set; }

		// Token: 0x170076BF RID: 30399
		// (get) Token: 0x06018A33 RID: 100915 RVA: 0x0038C8ED File Offset: 0x0038AAED
		// (set) Token: 0x06018A34 RID: 100916 RVA: 0x0038C8F5 File Offset: 0x0038AAF5
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170076C0 RID: 30400
		// (get) Token: 0x06018A35 RID: 100917 RVA: 0x0038C8FE File Offset: 0x0038AAFE
		// (set) Token: 0x06018A36 RID: 100918 RVA: 0x0038C906 File Offset: 0x0038AB06
		public string TidConditionDescription { get; set; }

		// Token: 0x170076C1 RID: 30401
		// (get) Token: 0x06018A37 RID: 100919 RVA: 0x0038C90F File Offset: 0x0038AB0F
		// (set) Token: 0x06018A38 RID: 100920 RVA: 0x0038C917 File Offset: 0x0038AB17
		public string TargetPreviewImagePath { get; set; }

		// Token: 0x170076C2 RID: 30402
		// (get) Token: 0x06018A39 RID: 100921 RVA: 0x0038C920 File Offset: 0x0038AB20
		// (set) Token: 0x06018A3A RID: 100922 RVA: 0x0038C928 File Offset: 0x0038AB28
		public ITakePhoto2TimeConditionT TimeCondition { get; set; }

		// Token: 0x170076C3 RID: 30403
		// (get) Token: 0x06018A3B RID: 100923 RVA: 0x0038C931 File Offset: 0x0038AB31
		// (set) Token: 0x06018A3C RID: 100924 RVA: 0x0038C939 File Offset: 0x0038AB39
		public ITakePhoto2PosConditionT PosCondition { get; set; }

		// Token: 0x170076C4 RID: 30404
		// (get) Token: 0x06018A3D RID: 100925 RVA: 0x0038C942 File Offset: 0x0038AB42
		// (set) Token: 0x06018A3E RID: 100926 RVA: 0x0038C94A File Offset: 0x0038AB4A
		public ITakePhoto2CameraFovConditionT FovCondition { get; set; }

		// Token: 0x170076C5 RID: 30405
		// (get) Token: 0x06018A3F RID: 100927 RVA: 0x0038C953 File Offset: 0x0038AB53
		// (set) Token: 0x06018A40 RID: 100928 RVA: 0x0038C95B File Offset: 0x0038AB5B
		public ITakePhoto2SequenceConditionT SequenceCondition { get; set; }

		// Token: 0x170076C6 RID: 30406
		// (get) Token: 0x06018A41 RID: 100929 RVA: 0x0038C964 File Offset: 0x0038AB64
		// (set) Token: 0x06018A42 RID: 100930 RVA: 0x0038C96C File Offset: 0x0038AB6C
		public string BoundCameraSeqPath { get; set; }

		// Token: 0x170076C7 RID: 30407
		// (get) Token: 0x06018A43 RID: 100931 RVA: 0x0038C975 File Offset: 0x0038AB75
		// (set) Token: 0x06018A44 RID: 100932 RVA: 0x0038C97D File Offset: 0x0038AB7D
		public List<TTakePhoto2TargetConfigUnion> PhotoTargets { get; set; }

		// Token: 0x06018A45 RID: 100933 RVA: 0x0038C988 File Offset: 0x0038AB88
		public ITakePhoto2ConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TidConditionDescription = null;
			this.TargetPreviewImagePath = null;
			this.TimeCondition = null;
			this.PosCondition = null;
			this.FovCondition = null;
			this.SequenceCondition = null;
			this.BoundCameraSeqPath = null;
			this.PhotoTargets = null;
		}
	}
}
