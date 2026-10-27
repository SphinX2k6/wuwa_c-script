using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005627 RID: 22055
	public class INpcModelT
	{
		// Token: 0x1700A337 RID: 41783
		// (get) Token: 0x060249E3 RID: 149987 RVA: 0x0050D60E File Offset: 0x0050B80E
		// (set) Token: 0x060249E4 RID: 149988 RVA: 0x0050D616 File Offset: 0x0050B816
		public EModelType Type { get; set; }

		// Token: 0x1700A338 RID: 41784
		// (get) Token: 0x060249E5 RID: 149989 RVA: 0x0050D61F File Offset: 0x0050B81F
		// (set) Token: 0x060249E6 RID: 149990 RVA: 0x0050D627 File Offset: 0x0050B827
		public string BlueprintPath { get; set; }

		// Token: 0x1700A339 RID: 41785
		// (get) Token: 0x060249E7 RID: 149991 RVA: 0x0050D630 File Offset: 0x0050B830
		// (set) Token: 0x060249E8 RID: 149992 RVA: 0x0050D638 File Offset: 0x0050B838
		public TNpcModelTypeUnion NpcModel { get; set; }

		// Token: 0x1700A33A RID: 41786
		// (get) Token: 0x060249E9 RID: 149993 RVA: 0x0050D641 File Offset: 0x0050B841
		// (set) Token: 0x060249EA RID: 149994 RVA: 0x0050D649 File Offset: 0x0050B849
		public string Abp { get; set; }

		// Token: 0x1700A33B RID: 41787
		// (get) Token: 0x060249EB RID: 149995 RVA: 0x0050D652 File Offset: 0x0050B852
		// (set) Token: 0x060249EC RID: 149996 RVA: 0x0050D65A File Offset: 0x0050B85A
		public List<string> BattleSockets { get; set; }

		// Token: 0x1700A33C RID: 41788
		// (get) Token: 0x060249ED RID: 149997 RVA: 0x0050D663 File Offset: 0x0050B863
		// (set) Token: 0x060249EE RID: 149998 RVA: 0x0050D66B File Offset: 0x0050B86B
		public List<string> NormalSockets { get; set; }

		// Token: 0x1700A33D RID: 41789
		// (get) Token: 0x060249EF RID: 149999 RVA: 0x0050D674 File Offset: 0x0050B874
		// (set) Token: 0x060249F0 RID: 150000 RVA: 0x0050D67C File Offset: 0x0050B87C
		public float LookingUpAngle { get; set; }

		// Token: 0x1700A33E RID: 41790
		// (get) Token: 0x060249F1 RID: 150001 RVA: 0x0050D685 File Offset: 0x0050B885
		// (set) Token: 0x060249F2 RID: 150002 RVA: 0x0050D68D File Offset: 0x0050B88D
		public EBodyType BodyType { get; set; }

		// Token: 0x1700A33F RID: 41791
		// (get) Token: 0x060249F3 RID: 150003 RVA: 0x0050D696 File Offset: 0x0050B896
		// (set) Token: 0x060249F4 RID: 150004 RVA: 0x0050D69E File Offset: 0x0050B89E
		public float NameZaxisOffset { get; set; }

		// Token: 0x1700A340 RID: 41792
		// (get) Token: 0x060249F5 RID: 150005 RVA: 0x0050D6A7 File Offset: 0x0050B8A7
		// (set) Token: 0x060249F6 RID: 150006 RVA: 0x0050D6AF File Offset: 0x0050B8AF
		public byte NullMask { get; set; }

		// Token: 0x060249F7 RID: 150007 RVA: 0x0050D6B8 File Offset: 0x0050B8B8
		public INpcModelT()
		{
			this.Type = EModelType.LevelPrefab;
			this.BlueprintPath = null;
			this.NpcModel = null;
			this.Abp = null;
			this.BattleSockets = null;
			this.NormalSockets = null;
			this.LookingUpAngle = 0f;
			this.BodyType = EBodyType.None;
			this.NameZaxisOffset = 0f;
			this.NullMask = 0;
		}
	}
}
