using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005984 RID: 22916
	public class ISplineMoveT
	{
		// Token: 0x1700ABFA RID: 44026
		// (get) Token: 0x06026CDC RID: 158940 RVA: 0x00557843 File Offset: 0x00555A43
		// (set) Token: 0x06026CDD RID: 158941 RVA: 0x0055784B File Offset: 0x00555A4B
		public List<IEntityStateConditionT> StateConditions { get; set; }

		// Token: 0x1700ABFB RID: 44027
		// (get) Token: 0x06026CDE RID: 158942 RVA: 0x00557854 File Offset: 0x00555A54
		// (set) Token: 0x06026CDF RID: 158943 RVA: 0x0055785C File Offset: 0x00555A5C
		public int Speed { get; set; }

		// Token: 0x1700ABFC RID: 44028
		// (get) Token: 0x06026CE0 RID: 158944 RVA: 0x00557865 File Offset: 0x00555A65
		// (set) Token: 0x06026CE1 RID: 158945 RVA: 0x0055786D File Offset: 0x00555A6D
		public int SplineEntityId { get; set; }

		// Token: 0x1700ABFD RID: 44029
		// (get) Token: 0x06026CE2 RID: 158946 RVA: 0x00557876 File Offset: 0x00555A76
		// (set) Token: 0x06026CE3 RID: 158947 RVA: 0x0055787E File Offset: 0x00555A7E
		public bool IsCircle { get; set; }

		// Token: 0x1700ABFE RID: 44030
		// (get) Token: 0x06026CE4 RID: 158948 RVA: 0x00557887 File Offset: 0x00555A87
		// (set) Token: 0x06026CE5 RID: 158949 RVA: 0x0055788F File Offset: 0x00555A8F
		public bool IsLookDir { get; set; }

		// Token: 0x1700ABFF RID: 44031
		// (get) Token: 0x06026CE6 RID: 158950 RVA: 0x00557898 File Offset: 0x00555A98
		// (set) Token: 0x06026CE7 RID: 158951 RVA: 0x005578A0 File Offset: 0x00555AA0
		public byte NullMask { get; set; }

		// Token: 0x06026CE8 RID: 158952 RVA: 0x005578A9 File Offset: 0x00555AA9
		public ISplineMoveT()
		{
			this.StateConditions = null;
			this.Speed = 0;
			this.SplineEntityId = 0;
			this.IsCircle = false;
			this.IsLookDir = false;
			this.NullMask = 0;
		}
	}
}
