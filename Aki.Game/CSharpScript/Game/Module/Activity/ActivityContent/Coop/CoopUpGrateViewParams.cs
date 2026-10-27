using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068E7 RID: 26855
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopUpGrateViewParams
	{
		// Token: 0x170097DF RID: 38879
		// (get) Token: 0x06042FE5 RID: 274405 RVA: 0x01051938 File Offset: 0x0104FB38
		// (set) Token: 0x06042FE6 RID: 274406 RVA: 0x01051940 File Offset: 0x0104FB40
		public CoopActivityData ActivityData { get; set; }

		// Token: 0x170097E0 RID: 38880
		// (get) Token: 0x06042FE7 RID: 274407 RVA: 0x01051949 File Offset: 0x0104FB49
		// (set) Token: 0x06042FE8 RID: 274408 RVA: 0x01051951 File Offset: 0x0104FB51
		public int RoleId { get; set; }

		// Token: 0x170097E1 RID: 38881
		// (get) Token: 0x06042FE9 RID: 274409 RVA: 0x0105195A File Offset: 0x0104FB5A
		// (set) Token: 0x06042FEA RID: 274410 RVA: 0x01051962 File Offset: 0x0104FB62
		public int PreLevel { get; set; }

		// Token: 0x170097E2 RID: 38882
		// (get) Token: 0x06042FEB RID: 274411 RVA: 0x0105196B File Offset: 0x0104FB6B
		// (set) Token: 0x06042FEC RID: 274412 RVA: 0x01051973 File Offset: 0x0104FB73
		public int NextLevel { get; set; }

		// Token: 0x170097E3 RID: 38883
		// (get) Token: 0x06042FED RID: 274413 RVA: 0x0105197C File Offset: 0x0104FB7C
		// (set) Token: 0x06042FEE RID: 274414 RVA: 0x01051984 File Offset: 0x0104FB84
		public bool IsMaxLevel { get; set; }

		// Token: 0x170097E4 RID: 38884
		// (get) Token: 0x06042FEF RID: 274415 RVA: 0x0105198D File Offset: 0x0104FB8D
		// (set) Token: 0x06042FF0 RID: 274416 RVA: 0x01051995 File Offset: 0x0104FB95
		public bool IsNew { get; set; }
	}
}
